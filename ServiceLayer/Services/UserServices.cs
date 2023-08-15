using DomainLayer.Interfaces;
using DomainLayer.Models;
using ServiceLayer.Models;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace ServiceLayer.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepo usersRepo;

        public UsersService(IUsersRepo usersRepo)
        {
            this.usersRepo = usersRepo;
        }

        //public void AddUser(UsersDTO userDto)
        //{
        //    // Convert DTO to domain model if needed
        //    var user = ConvertToUserDomainModel(userDto);

        //    // Call the repository to add the user
        //    usersRepo.AddUser(user);
        //}


        public IEnumerable<UsersDTO> GetUsers()
        {
            // Fetch users from the repository and map them to DTOs
            var users = usersRepo.GetAll(); // Assuming you have GetAll() or similar method in your repository
            var userDtos = users.Select(u => new UsersDTO
            {
                User_ID = u.UsersID,
                User_Name = u.User_Name,
                User_Email = u.User_Email,
                Password = u.Password
            });

            return userDtos;
        }

        public void RegisterUser(UsersDTO userDto)
        {
            // Map UsersDTO to Users (Domain model)
            var user = new Users
            {
                User_Name = userDto.User_Name,
                User_Email = userDto.User_Email,
                Password = userDto.Password
            };

            // Call the repository to add the user
            usersRepo.AddUser(user);
        }

        private Users ConvertToUserDomainModel(UsersDTO userDto)
        {
            Users user = new Users
            {
                User_Name = userDto.User_Name,
                User_Email = userDto.User_Email,
                Password = userDto.Password
            };

            return user;
        }

        public bool VerifyUserPassword(string usernameOrEmail, string providedPassword)
        {
            var user = usersRepo.GetByUserNameOrEmail(usernameOrEmail);
            if (user == null)
            {
                return false; // User not found
            }

            return VerifyPassword(providedPassword, user.Password);
        }

        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            return enteredPassword == storedPassword;
        }

    }
}