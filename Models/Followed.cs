namespace Models;
//Users that the current user is following
public class Followed{
    public int Id { get; set; }

    //The current user Id
    public int CurrentUserId { get; set; }

    //The Id of the person you are following
    public int FollowedId { get; set; }
    public string? FollowedUserName { get; set; }
}