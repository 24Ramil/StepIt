using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Login_Registration.Wpf
{
    class JsonUser
    {
        public static void JsonSerialization(User user) 
        {
            string filePath = "Users.json";
            List<User> users;

            if (File.Exists(filePath))
            {
                string jsonFile = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(jsonFile);
            }
            else
                users = new List<User>();

            users.Add(user);

            string userSerialize = JsonSerializer.Serialize(users);

            File.WriteAllText(filePath, userSerialize);
        }       

        public static bool JsonDesirialization(string inputUserLogin, string inputUserPassword) 
        {
            string filePath = "Users.json";

            if (File.Exists(filePath))
            {
                string jsonFile = File.ReadAllText(filePath);
                List<User> users = JsonSerializer.Deserialize<List<User>>(jsonFile);

                User targetUser = users.FirstOrDefault(user => user.Login == inputUserLogin && user.Password == inputUserPassword);

                if (targetUser != null)
                    return true;
            }

            return false;
        }

        public static string JsonDesirialization(string inputUserLogin)
        {
            string filePath = "Users.json";
            string jsonFile = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonFile);

            User targetUser = null;

            foreach (User person in users)
            {
                if (person.Login == inputUserLogin)
                {
                    targetUser = person;
                    break;
                }
            }

            if (targetUser != null)
                return targetUser.Password;
            else
                return "User not found";
        }

    }
}
