using System;


namespace DAL.Models
{
    [Serializable]
    public class Message
    {
        public int ID { get;set;}

        public int IDFromUser { get; set; }

        public int? IDToUser { get; set; }

        public string MessageSentence { get;set;}

        public DateTime Date { get;set;}
    }
}
