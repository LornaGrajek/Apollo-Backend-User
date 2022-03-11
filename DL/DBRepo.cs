global using Microsoft.EntityFrameworkCore;
namespace DL;

public class DBRepo : IRepo
{
    private UserDB _context;
    public DBRepo(UserDB context){
        _context = context;
    }

    
}