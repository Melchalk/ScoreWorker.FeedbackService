using AutoMapper;
using FeedbackService.Broker.Publishers;
using FeedbackService.Broker.Publishers.Interfaces;
using FeedbackService.Business.Feedback;
using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Business.Reviewer;
using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data;
using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;
using FeedbackService.DataProvider.PostgreSql.Ef;
using FeedbackService.Infrastructure.Mapper;
using FeedbackService.Infrastructure.Middlewares;
using MassTransit;
using MassTransit.ExtensionsDependencyInjectionIntegration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService;

internal class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services
            .AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        services.AddDbContext<FeedbackServiceDbContext>(options =>
        {
            options.UseNpgsql(Configuration.GetConnectionString("SQLConnectionString"),
                b => b.MigrationsAssembly(typeof(FeedbackServiceDbContext).Assembly.FullName));
        });

        services.AddSingleton(new MapperConfiguration(mc =>
        {
            mc.AddProfile<MappingProfile>();
        }).CreateMapper());

        services.AddControllers();

        ConfigureDI(services);

        //ConfigureMassTransit(services);

        services.AddEndpointsApiExplorer();

        services.AddHttpContextAccessor();

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme);
        services.AddAuthorization();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseCors("CorsPolicy");

        app.UseHttpsRedirection();

        app.UseMiddleware<GlobalExceptionMiddleware>();

        UpdateDatabase(app);

        app.UseRouting();

        app.UseMiddleware<TokenMiddleware>();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }

    private void ConfigureMassTransit(IServiceCollection services)
    {
        ConfigurePublishers(services);

        services.AddMassTransit(busConfigurator =>
        {
            busConfigurator.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost");
                cfg.ConfigureEndpoints(context);
            });

            ConfigureConsumers(busConfigurator);
        });
    }

    private void ConfigurePublishers(IServiceCollection services)
    {
        //services.AddScoped<IMessagePublisher<CreateLibraryRequest, CreateLibraryResponse>, CreateLibraryMessagePublisher>();
    }

    private void ConfigureConsumers(IServiceCollectionBusConfigurator x)
    {
        //x.AddConsumer<>();
    }

    private void ConfigureDI(IServiceCollection services)
    {
        services.AddScoped<IDataProvider, FeedbackServiceDbContext>();
        services.AddScoped<DbContext, FeedbackServiceDbContext>();

        services.AddScoped<IFeedbackRepository, FeedbackRepository>();
        services.AddScoped<IReviewerRepository, ReviewerRepository>();

        services.AddScoped<ICreateFeedbackCommand, CreateFeedbackCommand>();
        services.AddScoped<IDeleteFeedbackCommand, DeleteFeedbackCommand>();
        services.AddScoped<IGetFeedbackForUserCommand, GetFeedbackForUserCommand>();
        services.AddScoped<IGetFeedbackCommand, GetFeedbackCommand>();
        services.AddScoped<IUpdateFeedbackCommand, UpdateFeedbackCommand>();

        services.AddScoped<ICreateReviewerCommand, CreateReviewerCommand>();
        services.AddScoped<IDeleteReviewerCommand, DeleteReviewerCommand>();
        services.AddScoped<IGetReviewersByTeamCommand, GetReviewersByTeamCommand>();
        services.AddScoped<IGetReviewerCommand, GetReviewerCommand>();
        services.AddScoped<IUpdateReviewerCommand, UpdateReviewerCommand>();

        services.AddScoped<IUserService, UserService>();
    }

    private void UpdateDatabase(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices
            .GetRequiredService<IServiceScopeFactory>()
            .CreateScope();

        using var context = serviceScope.ServiceProvider
            .GetService<FeedbackServiceDbContext>();

        context!.Database.Migrate();
    }
}