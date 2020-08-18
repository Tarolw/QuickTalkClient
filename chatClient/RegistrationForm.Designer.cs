namespace chatClient
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.LabRegPass = new System.Windows.Forms.Label();
            this.LabRegName = new System.Windows.Forms.Label();
            this.TxtBoxRegPass = new System.Windows.Forms.TextBox();
            this.TxtBoxRegName = new System.Windows.Forms.TextBox();
            this.LabRegRePass = new System.Windows.Forms.Label();
            this.TxtBoxRegRePass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistration.Location = new System.Drawing.Point(12, 132);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(306, 23);
            this.BtnRegistration.TabIndex = 5;
            this.BtnRegistration.Text = "Зарегистрироваться";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // LabRegPass
            // 
            this.LabRegPass.AutoSize = true;
            this.LabRegPass.Location = new System.Drawing.Point(9, 50);
            this.LabRegPass.Name = "LabRegPass";
            this.LabRegPass.Size = new System.Drawing.Size(48, 13);
            this.LabRegPass.TabIndex = 9;
            this.LabRegPass.Text = "Пароль:";
            // 
            // LabRegName
            // 
            this.LabRegName.AutoSize = true;
            this.LabRegName.Location = new System.Drawing.Point(9, 9);
            this.LabRegName.Name = "LabRegName";
            this.LabRegName.Size = new System.Drawing.Size(106, 13);
            this.LabRegName.TabIndex = 8;
            this.LabRegName.Text = "Имя пользователя:";
            // 
            // TxtBoxRegPass
            // 
            this.TxtBoxRegPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxRegPass.Location = new System.Drawing.Point(12, 66);
            this.TxtBoxRegPass.Name = "TxtBoxRegPass";
            this.TxtBoxRegPass.PasswordChar = '*';
            this.TxtBoxRegPass.Size = new System.Drawing.Size(306, 20);
            this.TxtBoxRegPass.TabIndex = 7;
            // 
            // TxtBoxRegName
            // 
            this.TxtBoxRegName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxRegName.Location = new System.Drawing.Point(12, 27);
            this.TxtBoxRegName.Name = "TxtBoxRegName";
            this.TxtBoxRegName.Size = new System.Drawing.Size(307, 20);
            this.TxtBoxRegName.TabIndex = 6;
            // 
            // LabRegRePass
            // 
            this.LabRegRePass.AutoSize = true;
            this.LabRegRePass.Location = new System.Drawing.Point(10, 88);
            this.LabRegRePass.Name = "LabRegRePass";
            this.LabRegRePass.Size = new System.Drawing.Size(103, 13);
            this.LabRegRePass.TabIndex = 11;
            this.LabRegRePass.Text = "Повторите пароль:";
            // 
            // TxtBoxRegRePass
            // 
            this.TxtBoxRegRePass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxRegRePass.Location = new System.Drawing.Point(12, 104);
            this.TxtBoxRegRePass.Name = "TxtBoxRegRePass";
            this.TxtBoxRegRePass.PasswordChar = '*';
            this.TxtBoxRegRePass.Size = new System.Drawing.Size(306, 20);
            this.TxtBoxRegRePass.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(331, 169);
            this.Controls.Add(this.TxtBoxRegRePass);
            this.Controls.Add(this.LabRegRePass);
            this.Controls.Add(this.LabRegPass);
            this.Controls.Add(this.LabRegName);
            this.Controls.Add(this.TxtBoxRegPass);
            this.Controls.Add(this.TxtBoxRegName);
            this.Controls.Add(this.BtnRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.Label LabRegPass;
        private System.Windows.Forms.Label LabRegName;
        private System.Windows.Forms.TextBox TxtBoxRegPass;
        private System.Windows.Forms.TextBox TxtBoxRegName;
        private System.Windows.Forms.Label LabRegRePass;
        private System.Windows.Forms.TextBox TxtBoxRegRePass;
    }
}