namespace SibadishnikBotForTG.Entities
{
    public class History
    {
        private Person _person;
        private Notice _notice;

        public History(
            Person person, Notice notice
            )
        {
            _person = person;
            _notice = notice;
        }

        public override string ToString()
        {
            string act = "пишет";
            if (_person.GetFirstName().Equals("СибАДИшник"))
                act = "отвечает";

            return (
                $"{_notice.GetDate()}: " +
                $"{_person.GetUsername()} " +
                $"{_person.GetFirstName()} " +
                $"{_person.GetLastName()} " +
                $"{act}: \"{_notice.GetText()}\""
                );
        }

        public Notice GetNotice() => _notice;
        public Person GetPerson() => _person;
    }
}