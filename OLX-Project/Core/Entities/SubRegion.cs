namespace OLX_Project.Core.Entities;

public class SubRegion
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int RegionId { get; set; }
    public Region Region { get; set; }
    
    public ICollection<Advertisement> Ads { get; set; }
}