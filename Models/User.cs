namespace Models;

public class User{
    public int Id { get; set; }

    [Required]
    public string UserName { get; set; }
    public List<FollowedPost> PostsYouFollow { get; set; }
    public List<Followed> PeopleYouFollow { get; set; }
    public List<Followers> PeopleWhoFollowYou { get; set; }
    public List<Notification> NotificationList { get; set; }

}