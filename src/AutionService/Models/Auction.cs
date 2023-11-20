namespace AutionService.Models;

public class Auction {
  public Guid Id { get; set; }
  public int ReservePrice { get; set; } = 0;
  public string Seller { get; set; } = null!;
  public string Winner { get; set; } = "";
  public int? SoldAmount { get; set; }
  public int? CurrentHighBid { get; set; }
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
  public DateTime AuctionEnd { get; set; } = DateTime.UtcNow;
  public Status Status { get; set; } = Status.Live;
  public Item Item { get; set; } = new();
}