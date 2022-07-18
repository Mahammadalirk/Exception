using System;
using System.Collections.Generic;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> checklist = new List<string>();

            checklist.Add("Maga");
            checklist.Add("Eli");
            checklist.Add("Veli");
            checklist.Add("asasss");

            string searchText = "Maga";
            CheckString(checklist, searchText);


            LoginException("Maga", "maga123");



            List<string> listUsername = new List<string>() { "maga21", "magawe", "Maga222", "magayt" };

            List<string> listPassword = new List<string>() { "maga002", "1277", "0101maga", "maagaa12" };

            string searchUsername = "01maga";

            string searchPassword = "maga1122";

            LoginException(listUsername, searchUsername, listPassword, searchPassword);





        }



        public static void CheckString(List<string> names, string name)
        {
            try
            {
                var data = names.Find(m => m == name);
                if (data is null) throw new CheckString("Not Found Name");
                Console.WriteLine("Ugurla, Tamamlandi");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void LoginException(string username, string password)
        {
            try
            {
                if (username == "Maga" && password == "maga222")
                {
                    throw new Login("Entered");

                }
                else
                {
                    Console.WriteLine("Username or Password incorrect");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }


        public static void LoginException(List<string> username, string user, List<string> password, string pass)
        {
            try
            {
                if (!username.Contains(user) && !password.Contains(pass))
                {
                    throw new Login("Username or Password incorret");
                }

                //var data = username.Find(m => m == user);
                //var data1 = password.Find(m => m == pass);

                //if (data is null && data1 is null) throw new Login("Username or Password Incorret");

                Console.WriteLine("Entered");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }








    }
}
