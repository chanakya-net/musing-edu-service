using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareDomain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public IEnumerable<Roles> UserRoles { get; set; }
        public UserDetailInformation UserDetails { get; set; }
    }

    public class UserDetailInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public string Email { get; set; }

    }

    public class Roles
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
