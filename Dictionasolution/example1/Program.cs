using System;
using System.Collections.Generic;
using Bogus;
namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Dictionary<string,string>> players = new List<Dictionary<string,string>>();
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           AddUser(players);
           Console.WriteLine();
           ShowinfoUsers(players);
        }

        private static void AddUser (List<Dictionary<string , string>>origin)
        {
            var faker = new Faker("ru");
            string firstName = faker.Name.FirstName();
            string secondName= faker.Name.LastName();
            int age = faker.Random.Int(13,99);
            string phoneNumber = faker.Phone.PhoneNumber();
            string mail =faker.Internet.Email();
            string id = faker.Random.Hash();
            Dictionary<string,string> user = new Dictionary<string,string>();
            user.Add("Имя", firstName);
            user.Add("Фамилия", secondName);
            user.Add("Возраст", age.ToString());
            user.Add("Номер телефона", phoneNumber);
            user.Add("Почта", mail);
            user.Add("Id", id);

            origin.Add(user);
        }

        private static void ShowinfoUsers(List<Dictionary<string, string>> origin)
        {
            for (int i = 0; i < origin.Count; i++)
            {
                Dictionary<string , string> user = origin[i];
                Console.WriteLine(user["Имя"]);
                Console.WriteLine(user["Фамилия"]);
                Console.WriteLine(user["Возраст"]);
                Console.WriteLine(user["Номер телефона"]);
                Console.WriteLine(user["Почта"]);
                Console.WriteLine(user["Id"]);
                Console.WriteLine();
                
            }
        }
    }
}
