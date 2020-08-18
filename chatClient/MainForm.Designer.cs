namespace chatClient
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.BtnEnterChat = new System.Windows.Forms.Button();
            this.LabUserName = new System.Windows.Forms.Label();
            this.TxtBoxUserName = new System.Windows.Forms.TextBox();
            this.TxtBoxChat = new System.Windows.Forms.TextBox();
            this.TxtBoxChatMsg = new System.Windows.Forms.TextBox();
            this.BtnChatSend = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.параметрыСервераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.портToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.серверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPПортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyIvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtBoxOnline = new System.Windows.Forms.TextBox();
            this.TxtBoxUserPassword = new System.Windows.Forms.TextBox();
            this.LabUserPassword = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEnterChat
            // 
            this.BtnEnterChat.BackColor = System.Drawing.Color.White;
            this.BtnEnterChat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEnterChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnterChat.Location = new System.Drawing.Point(12, 38);
            this.BtnEnterChat.Name = "BtnEnterChat";
            this.BtnEnterChat.Size = new System.Drawing.Size(73, 23);
            this.BtnEnterChat.TabIndex = 0;
            this.BtnEnterChat.Text = "Войти";
            this.BtnEnterChat.UseVisualStyleBackColor = false;
            this.BtnEnterChat.Click += new System.EventHandler(this.EnterChat_Click);
            // 
            // LabUserName
            // 
            this.LabUserName.AutoSize = true;
            this.LabUserName.Location = new System.Drawing.Point(96, 24);
            this.LabUserName.Name = "LabUserName";
            this.LabUserName.Size = new System.Drawing.Size(106, 13);
            this.LabUserName.TabIndex = 1;
            this.LabUserName.Text = "Имя пользователя:";
            // 
            // TxtBoxUserName
            // 
            this.TxtBoxUserName.Location = new System.Drawing.Point(99, 40);
            this.TxtBoxUserName.Name = "TxtBoxUserName";
            this.TxtBoxUserName.Size = new System.Drawing.Size(330, 20);
            this.TxtBoxUserName.TabIndex = 2;
            // 
            // TxtBoxChat
            // 
            this.TxtBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxChat.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxChat.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtBoxChat.Location = new System.Drawing.Point(12, 68);
            this.TxtBoxChat.Multiline = true;
            this.TxtBoxChat.Name = "TxtBoxChat";
            this.TxtBoxChat.ReadOnly = true;
            this.TxtBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxChat.Size = new System.Drawing.Size(572, 412);
            this.TxtBoxChat.TabIndex = 3;
            this.TxtBoxChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatBox_KeyDown);
            // 
            // TxtBoxChatMsg
            // 
            this.TxtBoxChatMsg.AcceptsTab = true;
            this.TxtBoxChatMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxChatMsg.Enabled = false;
            this.TxtBoxChatMsg.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtBoxChatMsg.Location = new System.Drawing.Point(12, 486);
            this.TxtBoxChatMsg.Multiline = true;
            this.TxtBoxChatMsg.Name = "TxtBoxChatMsg";
            this.TxtBoxChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxChatMsg.Size = new System.Drawing.Size(501, 65);
            this.TxtBoxChatMsg.TabIndex = 4;
            this.TxtBoxChatMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chat_msg_KeyDown);
            this.TxtBoxChatMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chat_msg_KeyPress);
            // 
            // BtnChatSend
            // 
            this.BtnChatSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChatSend.BackColor = System.Drawing.SystemColors.Window;
            this.BtnChatSend.Enabled = false;
            this.BtnChatSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnChatSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChatSend.Image = ((System.Drawing.Image)(resources.GetObject("BtnChatSend.Image")));
            this.BtnChatSend.Location = new System.Drawing.Point(519, 486);
            this.BtnChatSend.Name = "BtnChatSend";
            this.BtnChatSend.Size = new System.Drawing.Size(65, 65);
            this.BtnChatSend.TabIndex = 5;
            this.BtnChatSend.UseVisualStyleBackColor = false;
            this.BtnChatSend.Click += new System.EventHandler(this.Chat_send_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // параметрыСервераToolStripMenuItem
            // 
            this.параметрыСервераToolStripMenuItem.Name = "параметрыСервераToolStripMenuItem";
            this.параметрыСервераToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.параметрыСервераToolStripMenuItem.Text = "Параметры сервера";
            // 
            // портToolStripMenuItem
            // 
            this.портToolStripMenuItem.Name = "портToolStripMenuItem";
            this.портToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.портToolStripMenuItem.Text = "Порт";
            // 
            // iPToolStripMenuItem
            // 
            this.iPToolStripMenuItem.Name = "iPToolStripMenuItem";
            this.iPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPToolStripMenuItem.Text = "IP";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.серверToolStripMenuItem,
            this.шифрованиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem1,
            this.регистрацияToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(780, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // серверToolStripMenuItem
            // 
            this.серверToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPПортToolStripMenuItem});
            this.серверToolStripMenuItem.Name = "серверToolStripMenuItem";
            this.серверToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.серверToolStripMenuItem.Text = "Параметры сервера";
            // 
            // iPПортToolStripMenuItem
            // 
            this.iPПортToolStripMenuItem.Name = "iPПортToolStripMenuItem";
            this.iPПортToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.iPПортToolStripMenuItem.Text = "IP/Порт";
            this.iPПортToolStripMenuItem.Click += new System.EventHandler(this.IPПортToolStripMenuItem_Click);
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyIvToolStripMenuItem});
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            // 
            // keyIvToolStripMenuItem
            // 
            this.keyIvToolStripMenuItem.Name = "keyIvToolStripMenuItem";
            this.keyIvToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.keyIvToolStripMenuItem.Text = "Ключ/Вектор";
            this.keyIvToolStripMenuItem.Click += new System.EventHandler(this.KeyIvToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // регистрацияToolStripMenuItem
            // 
            this.регистрацияToolStripMenuItem.Name = "регистрацияToolStripMenuItem";
            this.регистрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.регистрацияToolStripMenuItem.Text = "Регистрация";
            this.регистрацияToolStripMenuItem.Click += new System.EventHandler(this.входРегистрацияToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtBoxOnline
            // 
            this.TxtBoxOnline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxOnline.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxOnline.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtBoxOnline.Location = new System.Drawing.Point(590, 68);
            this.TxtBoxOnline.Multiline = true;
            this.TxtBoxOnline.Name = "TxtBoxOnline";
            this.TxtBoxOnline.ReadOnly = true;
            this.TxtBoxOnline.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBoxOnline.Size = new System.Drawing.Size(178, 483);
            this.TxtBoxOnline.TabIndex = 7;
            this.TxtBoxOnline.WordWrap = false;
            // 
            // TxtBoxUserPassword
            // 
            this.TxtBoxUserPassword.Location = new System.Drawing.Point(438, 40);
            this.TxtBoxUserPassword.Name = "TxtBoxUserPassword";
            this.TxtBoxUserPassword.PasswordChar = '*';
            this.TxtBoxUserPassword.Size = new System.Drawing.Size(330, 20);
            this.TxtBoxUserPassword.TabIndex = 9;
            // 
            // LabUserPassword
            // 
            this.LabUserPassword.AutoSize = true;
            this.LabUserPassword.Location = new System.Drawing.Point(435, 24);
            this.LabUserPassword.Name = "LabUserPassword";
            this.LabUserPassword.Size = new System.Drawing.Size(48, 13);
            this.LabUserPassword.TabIndex = 8;
            this.LabUserPassword.Text = "Пароль:";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 561);
            this.Controls.Add(this.TxtBoxUserPassword);
            this.Controls.Add(this.LabUserPassword);
            this.Controls.Add(this.TxtBoxOnline);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.BtnChatSend);
            this.Controls.Add(this.TxtBoxChatMsg);
            this.Controls.Add(this.TxtBoxChat);
            this.Controls.Add(this.TxtBoxUserName);
            this.Controls.Add(this.LabUserName);
            this.Controls.Add(this.BtnEnterChat);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickTalk";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnterChat;
        private System.Windows.Forms.Label LabUserName;
        private System.Windows.Forms.TextBox TxtBoxUserName;
        private System.Windows.Forms.TextBox TxtBoxChat;
        private System.Windows.Forms.TextBox TxtBoxChatMsg;
        private System.Windows.Forms.Button BtnChatSend;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСервераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem портToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem серверToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem iPПортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyIvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.TextBox TxtBoxOnline;
        private System.Windows.Forms.ToolStripMenuItem регистрацияToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtBoxUserPassword;
        private System.Windows.Forms.Label LabUserPassword;
    }
}

