namespace OLX_Project.Core.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Advertisement> Advertisement { get; set; }
}