﻿namespace OLX_Project.Core.Entities;

public class Region
{
    public int Id { get; set; }
    public string Name { get; set; }    
    
    public ICollection<SubRegion> SubRegions { get; set; }
}