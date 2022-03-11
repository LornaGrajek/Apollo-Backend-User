global using Models;
namespace DL;

public interface IRepo{
    //---------User Functionality-------------
    public List<User> GetAllUsers();
    public User GetUserById(int userId);
    public User GetUserByUserName(string UserName);

    //------------FollowingPost Functionality--------------
    public List<FollowedPost> GetAllFollowedPost();
    public FollowedPost GetFollowedPostByPostId(int postId);
    public List<FollowedPost> GetAllFollowedPostByUserId(int userId);

    //----------Functionality for the Person You Follow-----------
    public List<Followed> GetAllPeopleYouFollow();
    public Followed GetPersonYouFollowById(int id);
    
    //-----------Functionality for the People Who Follow You --------------
    public List<Followers> GetAllFollowersByCurrentUserId(int Id);
    public Followers GetFollowerByTheirId(int Id);

    //-------------Notification Functionality-----------------------
    public List<Notification> GetAllNotificationsByCurrentUserId(int Id);
    public List<Notification> GetAllNotificationsByPostId(int postId);
    public List<Notification> GetAllNotificationsByCommentId(int commentId);
    public List<Notification> GetAllNotificationsByFollowersId(int id);


}