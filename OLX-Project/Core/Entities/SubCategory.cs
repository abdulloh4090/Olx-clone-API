namespace OLX_Project.Core.Entities;

public class SubCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public ICollection<Ad> Ads { get; set; }
}