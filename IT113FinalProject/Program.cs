using System;
using System.Security.Cryptography;
using System.Text;

namespace IT113FinalProject
{
        class Program
        {
            static void Main(string[] args)
            {

            Console.WriteLine("Enter a word or phrase to hash for security purposes!");

                string input = Console.ReadLine();
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    Console.WriteLine("Your input has been converted to SHA256 Hash: {0}", builder.ToString());
                }
            }
        }
}


//https://youtu.be/JyfgHxe7BL4?si=XaB7_SQzDvSKAggJ  Used for reference, stoked my interest in this algorithm initially.  I have
// browsed many articles and videos learning more about different hashing, so I have not posted links to everything.
//
//I chose the SHA256 algorithm because I wanted to learn more about them, and how it could be inserted into web API and database
// functions so as to easily convert user supplied passwords to a more secure format.

//This project quickly provides a password user inputs and converts to a more secure SHA256 format

//Supposedly this algorithm provides more security than MD5 hashing functions due to collisions, but from what I have learned,
// this will probably be cracked in a few years and new iterations such as SHA3xx will be implemented and used as computing
// power increases and this algorithm is deciphered.

//Currently, this design exceeds expectations because it has not been cracked since it was created by the NSA and NIST in 2001.