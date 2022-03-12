namespace Models;

public class FollowedPost{
    public int Id { get; set; }
    public int CurrentUserId { get; set; }
    public int PostId { get; set; }
    public string? PostName { get; set; }
}