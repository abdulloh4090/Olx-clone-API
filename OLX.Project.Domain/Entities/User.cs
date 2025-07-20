namespace OLX_Project.Core.Entities;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string ImageUrl { get; set; }
    public bool IsOnline { get; set; }
    public DateTime LastOnline { get; set; }
    
    public ICollection<Ad> Ads { get; set; }
    public ICollection<Chat> ChatsAsUser1 { get; set; }
    public ICollection<Chat> ChatsAsUser2 { get; set; }
    public ICollection<Message> Messages { get; set; }
}