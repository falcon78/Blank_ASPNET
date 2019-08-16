using bProject_ASPNET.Models;
using System.Collections.Generic;
public class SqlUserDatabase : IUserDatabase {

    private readonly AppDbContext context;

    public SqlUserDatabase (AppDbContext context){
        this.context = context;
    }

    public User Add(User user){
        context.Users.Add(user);
        context.SaveChanges();
        return user;
    }

    public User Delete(int id){
        User user = context.Users.Find(id);
        if (user != null){
            context.Users.Remove(user);
            context.SaveChanges();
        }
        return user;
    }

    public IEnumerable<User> GetAllUsers (){
        return context.Users;
    }

    public User GetUser(int id){
        return context.Users.Find(id);
    }

    public User Update (User userUpdate){
        var user = context.Users.Attach(userUpdate);
        user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        context.SaveChanges();
        return userUpdate;
    }
}
