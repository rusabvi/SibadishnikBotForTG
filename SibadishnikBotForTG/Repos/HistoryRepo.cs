using SibadishnikBotForTG.Entities;
using System.Collections.Generic;

namespace SibadishnikBotForTG.Repos
{
    public static class HistoryRepo
    {
        private static List<History> _historyList = new List<History>();
        public static List<History> GetHistoryList() => _historyList;

        public static void Add(History history) => _historyList.Add(history);

        /*public static void Add(Person user, Notice notice)
        {
            string act = "пишет";
            if (user.GetFirstname().Equals("СибАДИшник"))
                act = "отвечает";

            _notices.Add(
                $"{notice.GetDate()}: " +
                $"{user.GetUsername()} " +
                $"{user.GetFirstname()} " +
                $"{user.GetLastname()} " +
                $"{act}: \"{notice.GetText()}\""
                );
        }*/
    }
}
