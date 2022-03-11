namespace Models;

public class Notification{
    public int Id { get; set; }
    public int CurrentUserId { get; set; }

    //Id of the person following you
    public int? FollowersId { get; set; }

    public int? PostId { get; set; }
    public int? CommentId { get; set; }

    //Notification Message is what is sent to the user, ie "Someone has commented on this post"
    public string? NotificationMessage { get; set; }
}