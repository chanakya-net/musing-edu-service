using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace musingDayCareCore.Common.Utility
{
    public static class Uttility
    {
        public static void CreateHashedPassword(string password, out byte[] passwordHash, out byte[] passowrdSalt)
        {
            using (var passwordHMAC = new HMACSHA512())
            {
                passowrdSalt = passwordHMAC.Key;
                passwordHash = passwordHMAC.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
