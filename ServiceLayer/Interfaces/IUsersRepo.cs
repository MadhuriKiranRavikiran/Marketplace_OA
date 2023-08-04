using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Models;

namespace DomainLayer.Interfaces
{
    public interface IUsersRepo
    {
        IEnumerable<UsersDTO> GetUsers();

    }
}
