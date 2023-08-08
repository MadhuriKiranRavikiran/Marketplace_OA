using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;

namespace DomainLayer.Interfaces
{
    public interface IUsersService
    {
        IEnumerable<UsersDTO> GetUsers();
        void RegisterUser(UsersDTO userDto);
        //void AddUser(UsersDTO userDto);


    }
}
