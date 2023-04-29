using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;

namespace DTA_2022_23_Battleship {
    public static class Cryptography {
        public static String GenerateSalt() {
            byte[] salt =  RandomNumberGenerator.GetBytes(32);
            var builder = new StringBuilder();
            for (int i = 0; i < salt.Length; i++) {
                builder.Append(salt[i].ToString("x2"));
            }
            return builder.ToString();
        }
        public static String GenerateHash(String rawData) {
            using (var sha256Hash = SHA256.Create()) {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++) {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
