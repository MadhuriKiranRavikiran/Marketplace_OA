using RepositoryLayer.Repositories;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using DomainLayer.Interfaces;
using System.Runtime.Remoting.Contexts;

namespace RepositoryLayer
{
    public class UsersRepo : GenericRepo<Users>, IUsersRepo
    {
        public UsersRepo(MarketDBContext context) : base(context)
        {

        }

        public void AddUser(Users user)
        {

            Context.Set<Users>().Add(user);
            Context.SaveChanges();
        }

        public Users GetByUserNameOrEmail(string usernameOrEmail)
        {
            return Context.Users.FirstOrDefault(u => u.User_Name == usernameOrEmail || u.User_Email == usernameOrEmail);
        }

    }

}
