namespace Models;
//The user that is following you

public class Followers{
    public int Id { get; set; }
    
    //CurrentUserId is the id of the currently logged in user
    public int CurrentUserId { get; set; }

    //FollowersId is the id of the user following you
    public int FollowersId { get; set; }
    public string FollowersUserName { get; set; }
}