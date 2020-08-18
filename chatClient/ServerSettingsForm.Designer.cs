namespace chatClient
{
    partial class ServerSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSettingsForm));
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabIP = new System.Windows.Forms.Label();
            this.LabPort = new System.Windows.Forms.Label();
            this.TxtBoxIP = new System.Windows.Forms.TextBox();
            this.TxtBoxPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.BackColor = System.Drawing.Color.White;
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Location = new System.Drawing.Point(124, 91);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(100, 23);
            this.BtnApply.TabIndex = 0;
            this.BtnApply.Text = "Применить";
            this.BtnApply.UseVisualStyleBackColor = false;
            this.BtnApply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(12, 91);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LabIP
            // 
            this.LabIP.AutoSize = true;
            this.LabIP.Location = new System.Drawing.Point(9, 11);
            this.LabIP.Name = "LabIP";
            this.LabIP.Size = new System.Drawing.Size(53, 13);
            this.LabIP.TabIndex = 2;
            this.LabIP.Text = "IP-адрес:";
            // 
            // LabPort
            // 
            this.LabPort.AutoSize = true;
            this.LabPort.Location = new System.Drawing.Point(9, 49);
            this.LabPort.Name = "LabPort";
            this.LabPort.Size = new System.Drawing.Size(35, 13);
            this.LabPort.TabIndex = 3;
            this.LabPort.Text = "Порт:";
            // 
            // TxtBoxIP
            // 
            this.TxtBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxIP.Location = new System.Drawing.Point(12, 27);
            this.TxtBoxIP.Name = "TxtBoxIP";
            this.TxtBoxIP.Size = new System.Drawing.Size(212, 20);
            this.TxtBoxIP.TabIndex = 4;
            // 
            // TxtBoxPort
            // 
            this.TxtBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxPort.Location = new System.Drawing.Point(12, 65);
            this.TxtBoxPort.Name = "TxtBoxPort";
            this.TxtBoxPort.Size = new System.Drawing.Size(212, 20);
            this.TxtBoxPort.TabIndex = 5;
            this.TxtBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
            // 
            // ServerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(239, 125);
            this.Controls.Add(this.TxtBoxPort);
            this.Controls.Add(this.TxtBoxIP);
            this.Controls.Add(this.LabPort);
            this.Controls.Add(this.LabIP);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры сервера";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabIP;
        private System.Windows.Forms.Label LabPort;
        private System.Windows.Forms.TextBox TxtBoxIP;
        private System.Windows.Forms.TextBox TxtBoxPort;
    }
}