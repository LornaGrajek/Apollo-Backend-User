namespace DL;

public class UserDB :DbContext{
    public UserDB() : base() { }
    public UserDB(DbContextOptions options) : base(options) { }
    public DbSet<User>? Users { get; set; }
    public DbSet<FollowedPost>? FollowedPosts { get; set; }
    public DbSet<Followed>? Followed { get; set; }
    public DbSet<Followers>? Followers { get; set; }
    public DbSet<Notification>? Notifications { get; set; }
}