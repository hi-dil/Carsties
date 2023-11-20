using AutionService.Models;
using Microsoft.EntityFrameworkCore;

namespace AutionService.Data;

public class AuctionDBContext : DbContext {
  public AuctionDBContext(DbContextOptions options) : base(options) {}

  public DbSet<Auction> Auctions {get; set;}
}
