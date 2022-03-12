global using Microsoft.EntityFrameworkCore;

namespace DL;

public class DBRepo : IRepo
{
    private UserDB _context;
    public DBRepo(UserDB context){
        _context = context;
    }

    public List<FollowedPost> GetAllFollowedPost()
    {
        throw new NotImplementedException();
    }

    public List<FollowedPost> GetAllFollowedPostByUserId(int userId)
    {
        throw new NotImplementedException();
    }

    public List<Followers> GetAllFollowersByCurrentUserId(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Notification> GetAllNotificationsByCommentId(int commentId)
    {
        throw new NotImplementedException();
    }

    public List<Notification> GetAllNotificationsByCurrentUserId(int Id)
    {
        throw new NotImplementedException();
    }

    public List<Notification> GetAllNotificationsByFollowersId(int id)
    {
        throw new NotImplementedException();
    }

    public List<Notification> GetAllNotificationsByPostId(int postId)
    {
        throw new NotImplementedException();
    }

    public List<Followed> GetAllPeopleYouFollow()
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public FollowedPost GetFollowedPostByPostId(int postId)
    {
        throw new NotImplementedException();
    }

    public Followers GetFollowerByTheirId(int Id)
    {
        throw new NotImplementedException();
    }

    public Followed GetPersonYouFollowById(int id)
    {
        throw new NotImplementedException();
    }

    public User GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    public User GetUserByUserName(string UserName)
    {
        throw new NotImplementedException();
    }
}