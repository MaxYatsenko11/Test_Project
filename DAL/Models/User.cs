using System;
using System.Collections.Generic;

namespace DAL.Models
{
    [Serializable]
    public class User
    {
        public int ID { get; private set;}

        public string Name { get; set;}

        public string Login { get; set;}

        public string Password { get;set;}

        public List<Message> MessagesUser { get;set;}
    }
}
