using AutionService.Models;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace AutionService.Data;

public class AuctionDBContext : DbContext {
  public AuctionDBContext(DbContextOptions options) : base(options) {}

  public DbSet<Auction> Auctions { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    base.OnModelCreating(modelBuilder);

    modelBuilder.AddInboxStateEntity();
    modelBuilder.AddOutboxMessageEntity();
    modelBuilder.AddOutboxStateEntity();
  }
}
