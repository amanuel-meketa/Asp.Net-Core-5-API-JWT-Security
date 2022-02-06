using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityAPI.Model.DTO
{
    public class UserDTO
    {
        public UserDTO(string fullName, string email, string userName, DateTime deteCreated)
        {
            FullName = fullName;
            Email = email;
            UserName = userName;
            DeteCreated = deteCreated;
            
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public DateTime DeteCreated { get; set; }
        public string Token { get; set; }

    }
}
