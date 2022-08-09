using System;

namespace SibadishnikBotForTG.Entities
{
    public class Notice
    {
        private string _text;
        private DateTime _date;

        public Notice(
            string text,
            DateTime date
            )
        {
            _text = text;
            _date = date;
        }

        public string GetText() => _text;
        public DateTime GetDate() => _date;
    }
}