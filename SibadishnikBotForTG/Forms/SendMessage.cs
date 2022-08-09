using SibadishnikBotForTG.Bot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SibadishnikBotForTG.Forms
{
    public partial class SendMessage : Form
    {
        private List<Person> _getters;
        public SendMessage()
        {
            InitializeComponent();
            PopulateComboBox();
            _getters = new List<Person>();
            CheckStatusBtnSend();
        }

        private void CheckStatusBtnSend()
        {
            var isReady = (!(cbAll.Text.Equals("") | cbAll.Text == null) |
                !(cbOne.Text.Equals("") | cbOne.Text == null)) &
                !(tbMessage.Text.Equals("") | tbMessage.Text == null);
            btnSend.Enabled = isReady;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new Main().Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (var person in _getters)
                Sibadishnik.SendMessage(person.GetId(), tbMessage.Text);
            tbMessage.Clear();
        }

        private void PopulateComboBox()
        {
            cbOne.Items.Add("");
            foreach (var person in PersonRepo.GetNoBotPersons())
                if (!person.GetUsername().Equals("Sibadishnik_bot"))
                    cbOne.Items.Add($"{person.GetFirstName()} {person.GetLastName()} {person.GetUsername()}");

            cbAll.Items.Add("");
            cbAll.Items.Add("Подписанным");
            cbAll.Items.Add("Всем");
        }

        private void cbOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isNull = (cbOne.Text.Equals("") | cbOne.Text == null);
            cbAll.Enabled = isNull;
            if (!isNull)
            {
                _getters = new List<Person>();
                var getter = PersonRepo.GetPersonByNames(
                    cbOne.Text.Split(' ')[0],
                    cbOne.Text.Split(' ')[1],
                    cbOne.Text.Split(' ')[2]
                    );
                _getters.Add(getter);
            }
            CheckStatusBtnSend();
        }

        private void cbAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isNull = (cbAll.Text.Equals("") | cbAll.Text == null);
            cbOne.Enabled = isNull;
            timer_Tick(sender, e);
            CheckStatusBtnSend();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e) => CheckStatusBtnSend();

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cbAll.Text.Equals("Подписанным"))
                _getters = PersonRepo.GetSubscribedPersons();
            else if (cbAll.Text.Equals("Всем"))
                _getters = PersonRepo.GetNoBotPersons();
        }
    }
}