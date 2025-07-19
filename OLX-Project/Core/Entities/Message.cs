﻿namespace OLX_Project.Core.Entities;

public class Message
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public int ChatId { get; set; }
    public Chat Chat { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}