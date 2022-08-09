using SibadishnikBotForTG.Entities;
using System.Collections.Generic;

namespace SibadishnikBotForTG
{
    public class Person
    {
        private long _id;
        private string _username;
        private string _firstName;
        private string _lastName;
        private List<Notice> _receivedNotices;  //полученные сообщения
        private List<Notice> _sentNotices;      //отправленные сообщения
        private bool _subscribed;

        public Person(
            long id,
            string username,
            string firstName,
            string lastName
            )
        {
            _id = id;
            _username = username;
            _firstName = firstName;
            _lastName = lastName;
            _receivedNotices = new List<Notice>();
            _sentNotices = new List<Notice>();
            _subscribed = false;

            if (username == null)
                _username = "";
            if (firstName == null)
                _firstName = "";
            if (lastName == null)
                _lastName = "";
        }

        public void ChangeSubscrided() => _subscribed = !_subscribed;

        public void AddReceivedNotice(Notice notice) => _receivedNotices.Add(notice);
        public void AddSentNotice(Notice notice) => _sentNotices.Add(notice);

        public long GetId() => _id;
        public string GetUsername() => _username;
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public List<Notice> GetReceivedNotices() => _receivedNotices;
        public List<Notice> GetSentNotices() => _sentNotices;
        public bool IsSubscribed() => _subscribed;
    }
}