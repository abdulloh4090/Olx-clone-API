namespace OLX_Project.Core.Entities;

public class Image
{
    public int Id { get; set; } 
    public string ImageUrl { get; set; }
    
    public int AdId { get; set; }
    public Advertisement Advertisement { get; set; }
}