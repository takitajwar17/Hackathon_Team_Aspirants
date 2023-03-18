using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackathon1
{
    public static class Utility
    {
        internal static List<User> users = new List<User>();

        public static void load_users()
        {
            string path = @"C:\Users\User\Downloads\hackathon\bin\Debug\form\TextFile1.txt";
            StreamReader srr = new StreamReader(path);

            var strr = srr.ReadLine();

            while ( strr != null )
            {
                string[] k = null;
                k = strr.Split(',');

                string username = k[0];
                string email = k[1];
                string pass = k[2];

                User u = new User(username, email, pass);
                users.Add(u);
                strr = srr.ReadLine();
                srr.Close();

            }
        }
    }
}
