using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectNeverPass
{
    public class HashingAlgorihtm
    {
        
        const int HASH_ITERATIONS = 43;
        const string HASH_ALGORITHM = "SHA-512";
        const int SALT_LENGTH = 64;
        public static String GeneratePasswordHashAndSalt(String passwd, out String salt)
        {    // First generate the unique salt we will use to hash with    
            salt = GenerateSalt();
            // Create salted hash    
            string hashedPwd = GenerateHash(passwd, salt);
            return (hashedPwd);
        }
        private static String GenerateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_LENGTH]; rng.GetBytes(salt);
            return (Convert.ToBase64String(salt));
        }
        private static string GenerateHash(String clearTextData, String salt)
        {
            if (salt?.Length > 0)
            {
                // Combine password and salt before hashing        
                byte[] clearTextDataArray = Encoding.UTF8.GetBytes(clearTextData);
                byte[] clearTextSaltArray = Convert.FromBase64String(salt);
                byte[] clearTextDataSaltArray = new byte[clearTextDataArray.Length + clearTextSaltArray.Length];
                Array.Copy(clearTextDataArray, 0, clearTextDataSaltArray, 0, clearTextDataArray.Length);
                Array.Copy(clearTextSaltArray, 0, clearTextDataSaltArray, clearTextDataArray.Length, clearTextSaltArray.Length);
                // Use a secure hashing algorithm        
                HashAlgorithm alg = HashAlgorithm.Create(HASH_ALGORITHM);
                byte[] hashedPwd = null;
                for (int index = 0; index < HASH_ITERATIONS; index++)
                {
                    if (hashedPwd == null)
                    {
                        // Initial hash of the cleartext password                
                        hashedPwd = alg.ComputeHash(clearTextDataSaltArray);
                    }
                    else
                    {
                        // Re-hash the hash for added entropy                
                        hashedPwd = alg.ComputeHash(hashedPwd);
                    }
                }

                return Convert.ToBase64String(hashedPwd);
            }

            else
            {
                throw new ArgumentException($"Salt parameter {nameof(salt)} cannot be empty or null. " + "This is a security violation.");
            }
        }
        public static bool ComparePasswords(String storedHashedPwd, String storedSalt, String clearTextPwd)
        {
            try
            {
                // First hash the clear text pwd using the same technique       
                byte[] userEnteredHashedPwd = Convert.FromBase64String(GenerateHash(clearTextPwd, storedSalt));
                // Get the stored hashed pwd/salt       
                byte[] originalHashedPwd = Convert.FromBase64String(storedHashedPwd);
                // Now compare the two hashes        
                // If true, the user entered password is correct        
                if (userEnteredHashedPwd.SequenceEqual(originalHashedPwd))
                    return true;
            }
            catch (ArgumentException ae)
            {
                // You should log this error and return false here      
                Console.WriteLine(ae.Message);
                return false;
            }
            return false;
        }
        public static bool login(string enteredusername, string enteredpassword)
        {
            string username;
            string password;
            string salt;
            string filepath = @"C:\ProjectNeverPassSolution\Information.txt";
           
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach(var line in lines)
            {
                string[] entries = line.Split(',');
                username = entries[0];
                password = entries[1];
                salt = entries[2];

                if (username == enteredusername)
                {
                    if (ComparePasswords(password, salt, enteredpassword) == true)
                    {
                        Menu_encrypting_window mainmenu = new Menu_encrypting_window();
                        mainmenu.Show();
                        return true;
                       
                    }
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }
    }
}

