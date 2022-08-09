namespace SibadishnikBotForTG.Forms
{
    partial class SendMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbOne = new System.Windows.Forms.ComboBox();
            this.lblAll = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.cbAll = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(713, 353);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 85);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Отправить сообщение";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(93, 355);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(614, 83);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.TextChanged += new System.EventHandler(this.tbMessage_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 85);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbOne
            // 
            this.cbOne.FormattingEnabled = true;
            this.cbOne.Location = new System.Drawing.Point(426, 25);
            this.cbOne.Name = "cbOne";
            this.cbOne.Size = new System.Drawing.Size(362, 21);
            this.cbOne.TabIndex = 2;
            this.cbOne.SelectedIndexChanged += new System.EventHandler(this.cbOne_SelectedIndexChanged);
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(12, 9);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(77, 13);
            this.lblAll.TabIndex = 3;
            this.lblAll.Text = "Выбрать всех";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(423, 9);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(89, 13);
            this.lblOne.TabIndex = 3;
            this.lblOne.Text = "Выбрать одного";
            // 
            // cbAll
            // 
            this.cbAll.FormattingEnabled = true;
            this.cbAll.Location = new System.Drawing.Point(12, 25);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(362, 21);
            this.cbAll.TabIndex = 2;
            this.cbAll.SelectedIndexChanged += new System.EventHandler(this.cbAll_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.cbOne);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Name = "SendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отправка сообщений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbOne;
        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.ComboBox cbAll;
        private System.Windows.Forms.Timer timer;
    }
}