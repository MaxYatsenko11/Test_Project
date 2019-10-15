using DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace DAL
{
    public class Serializer
    {
        public static bool SerializeUsers(List<User> list)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                File.Create("Users.txt").Dispose();
                using (FileStream sw = new FileStream("Users.txt", FileMode.Create))
                {
                    formatter.Serialize(sw, list);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<User> DeSerializeUsers()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                if (File.Exists("Users.txt"))
                {
                    using (FileStream fs = new FileStream("Users.txt", FileMode.OpenOrCreate))
                    {
                        return formatter.Deserialize(fs) as List<User>;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SerializationException)
            {
                return null;
            }
        }

        public static bool SerializeMessages(List<Message> list)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                File.Create("Messages.txt").Dispose();
                using (FileStream sw = new FileStream("Messages.txt", FileMode.Create))
                {
                    formatter.Serialize(sw, list);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Message> DeSerializeMessages()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                if (File.Exists("Messages.txt"))
                {
                    using (FileStream fs = new FileStream("Messages.txt", FileMode.OpenOrCreate))
                    {
                        return formatter.Deserialize(fs) as List<Message>;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SerializationException)
            {
                return null;
            }
        }
    }
}
