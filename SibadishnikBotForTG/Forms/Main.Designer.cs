using System;

namespace SibadishnikBotForTG
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblIsBotWorking = new System.Windows.Forms.Label();
            this.btnNewMessage = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnUnmute = new System.Windows.Forms.Button();
            this.lblIsBotMuted = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(12, 408);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 30);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeColumns = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.FirstName,
            this.LastName,
            this.Username,
            this.Notice});
            this.dgvHistory.Location = new System.Drawing.Point(12, 12);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 20;
            this.dgvHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.RowTemplate.ReadOnly = true;
            this.dgvHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.Size = new System.Drawing.Size(776, 341);
            this.dgvHistory.TabIndex = 1;
            // 
            // lblIsBotWorking
            // 
            this.lblIsBotWorking.AutoSize = true;
            this.lblIsBotWorking.Location = new System.Drawing.Point(53, 392);
            this.lblIsBotWorking.Name = "lblIsBotWorking";
            this.lblIsBotWorking.Size = new System.Drawing.Size(63, 13);
            this.lblIsBotWorking.TabIndex = 2;
            this.lblIsBotWorking.Text = "Загрузка...";
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.Location = new System.Drawing.Point(648, 408);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(140, 30);
            this.btnNewMessage.TabIndex = 0;
            this.btnNewMessage.Text = "Отправить сообщение";
            this.btnNewMessage.UseVisualStyleBackColor = true;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // btnMute
            // 
            this.btnMute.Enabled = false;
            this.btnMute.Location = new System.Drawing.Point(324, 359);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(140, 30);
            this.btnMute.TabIndex = 0;
            this.btnMute.Text = "Заглушить бота";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.Enabled = false;
            this.btnUnmute.Location = new System.Drawing.Point(324, 408);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.Size = new System.Drawing.Size(140, 30);
            this.btnUnmute.TabIndex = 0;
            this.btnUnmute.Text = "Разглушить бота";
            this.btnUnmute.UseVisualStyleBackColor = true;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // lblIsBotMuted
            // 
            this.lblIsBotMuted.AutoSize = true;
            this.lblIsBotMuted.Location = new System.Drawing.Point(361, 392);
            this.lblIsBotMuted.Name = "lblIsBotMuted";
            this.lblIsBotMuted.Size = new System.Drawing.Size(63, 13);
            this.lblIsBotMuted.TabIndex = 2;
            this.lblIsBotMuted.Text = "Загрузка...";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(648, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Обновить сообщения";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateTime.Frozen = true;
            this.DateTime.HeaderText = "Дата и время";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 120;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Username.Frozen = true;
            this.Username.HeaderText = "Ник";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 150;
            // 
            // Notice
            // 
            this.Notice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notice.HeaderText = "Сообщение";
            this.Notice.Name = "Notice";
            this.Notice.ReadOnly = true;
            this.Notice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIsBotMuted);
            this.Controls.Add(this.lblIsBotWorking);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewMessage);
            this.Controls.Add(this.btnUnmute);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnStart);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СибАДИшник";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTextColumn;
        private System.Windows.Forms.Label lblIsBotWorking;
        private System.Windows.Forms.Button btnNewMessage;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnUnmute;
        private System.Windows.Forms.Label lblIsBotMuted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notice;
    }
}

