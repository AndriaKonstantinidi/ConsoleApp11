using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class salaro
    {
        protected decimal balance = 0.0m;

        public void addcash(decimal add)
        {
            balance += add;
        }

        public decimal balances()
        {
            return balance;
        }

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
    public class meore : salaro
    {
        public void cashout(string pass)
        {
            var decodedpass = ComputeSha256Hash(pass);
            var password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3";
            if (decodedpass == password)
            {
                Console.WriteLine("balance was: " + balance);
                balance = 0;
            }
        }
    }
    public class myclass : myclass2 
    {
        private int ss = 1;
        private void mee()
        {
            ssm = ss;
            Console.WriteLine("ssss");
        }
    }

    public class myclass2
    {
        protected internal static int ssm = 1;
        internal void mee()
        {
            Console.WriteLine("ssss");
        }
    }
}