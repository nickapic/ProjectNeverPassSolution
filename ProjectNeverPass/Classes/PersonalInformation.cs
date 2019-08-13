using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ProjectNeverPass
{
    class PersonalInformation
    {
        private static string FirstName { get; set; }
        private static string LastName { get; set; }
        private static string Username { get; set; }
        private static string Password { get; set; }
        private static string Email { get; set; }
        private static string Salt { get; set; }
        public PersonalInformation(string usernametofill, string hashedpassword, string salt ,string firstnametofill, string lastnametofill, string emailtobefilled)
        {
            FirstName = firstnametofill;
            LastName = lastnametofill;
            Email = emailtobefilled;
            Username = usernametofill;
            Password = hashedpassword;
            Salt = salt;
            string filepath = @"‪C:\ProjectNeverPassSolution\Information.txt";
            File.Create(filepath);
            
            List<string> lines = File.ReadAllLines(filepath).ToList();
            string texttoadd = Username + "," + Password + "," + Salt+","+FirstName + "," + LastName + "," + Email;
            lines.Add(texttoadd);
            File.WriteAllLines(filepath, lines);

        }
        public void ClearAllData()
        {
           

        }
    }
}
