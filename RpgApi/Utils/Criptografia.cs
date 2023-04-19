using System;
using RpgApi.Models.Enuns;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;

namespace RpgApi.Utils
{
    public class Criptografia
    {
        public static void CriarPasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}