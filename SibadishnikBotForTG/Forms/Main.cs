using SibadishnikBotForTG.Bot;
using SibadishnikBotForTG.Forms;
using SibadishnikBotForTG.Repos;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SibadishnikBotForTG
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckBotStatus();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                foreach (var history in HistoryRepo.GetHistoryList())
                    dgvHistory.Rows.Add(new string[] {
                        history.GetNotice().GetDate().ToString(),
                        history.GetPerson().GetFirstName(),
                        history.GetPerson().GetLastName(),
                        history.GetPerson().GetUsername(),
                        history.GetNotice().GetText()
                    });
            }
            catch (Exception e)
            {
                PopulateDataGridView();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Sibadishnik.Start();
            CheckBotStatus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Sibadishnik.Stop();
            CheckBotStatus();
        }

        private void btnUnmute_Click(object sender, EventArgs e)
        {
            Sibadishnik.Unmute();
            CheckBotStatus();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            Sibadishnik.Mute();
            CheckBotStatus();
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            Hide();
            new SendMessage().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvHistory.Rows.Clear();
            PopulateDataGridView();
        }

        private void CheckBotStatus()
        {
            if (Sibadishnik.IsWorking())
            {
                lblIsBotWorking.Text = "Бот работает";
                btnStart.Enabled = false;
                btnStop.Enabled = true;

                lblIsBotMuted.Visible = true;
                btnMute.Visible = true;
                btnUnmute.Visible = true;

                if (Sibadishnik.IsMuted())
                {
                    lblIsBotMuted.Text = "Бот в муте";
                    btnMute.Enabled = false;
                    btnUnmute.Enabled = true;
                }
                else
                {
                    lblIsBotMuted.Text = "Бот не в муте";
                    btnMute.Enabled = true;
                    btnUnmute.Enabled = false;
                }
            }
            else
            {
                lblIsBotWorking.Text = "Бот не работает";
                btnStart.Enabled = true;
                btnStop.Enabled = false;

                lblIsBotMuted.Visible = false;
                btnMute.Enabled = false;
                btnMute.Visible = false;
                btnUnmute.Enabled = false;
                btnUnmute.Visible = false;
            }
        }

        private void AutoSizeRowsMode(Object sender, EventArgs es)
        {
            dgvHistory.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}