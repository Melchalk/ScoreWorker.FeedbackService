using FeedbackService.Data.Provider;
using FeedbackService.Models.Db;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FeedbackService.DataProvider.PostgreSql.Ef;

public class FeedbackServiceDbContext(DbContextOptions<FeedbackServiceDbContext> options)
    : DbContext(options), IDataProvider
{
    public DbSet<DbFeedback> Feedbacks { get; set; }
    public DbSet<DbReviewer> Reviewer { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load(typeof(DbFeedback).Assembly.FullName!));
    }

    public object MakeEntityDetached(object obj)
    {
        Entry(obj).State = EntityState.Detached;
        return Entry(obj).State;
    }

    async Task IBaseDataProvider.SaveAsync(CancellationToken cancellationToken)
    {
        await SaveChangesAsync(cancellationToken);
    }

    void IBaseDataProvider.Save()
    {
        SaveChanges();
    }

    public void EnsureDeleted()
    {
        Database.EnsureDeleted();
    }

    public bool IsInMemory()
    {
        return Database.IsInMemory();
    }
}