namespace OLX_Project.Core.Entities;

public class Ad
{
    public int Id { get; set; } 
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? SellAt { get; set; }
    public string State { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int SubRegionId { get; set; }
    public SubRegion SubRegion { get; set; }
    
    public int SubCategoryId { get; set; }
    public SubCategory SubCategory { get; set; }
    
    public ICollection<Image> Images { get; set; }
}