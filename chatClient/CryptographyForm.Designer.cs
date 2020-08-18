namespace chatClient
{
    partial class CryptographyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptographyForm));
            this.TxtBoxKey = new System.Windows.Forms.TextBox();
            this.TxtBoxIv = new System.Windows.Forms.TextBox();
            this.LabKey = new System.Windows.Forms.Label();
            this.LabIv = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxKey
            // 
            this.TxtBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxKey.Location = new System.Drawing.Point(12, 30);
            this.TxtBoxKey.Name = "TxtBoxKey";
            this.TxtBoxKey.PasswordChar = '*';
            this.TxtBoxKey.Size = new System.Drawing.Size(349, 20);
            this.TxtBoxKey.TabIndex = 0;
            // 
            // TxtBoxIv
            // 
            this.TxtBoxIv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxIv.Location = new System.Drawing.Point(12, 69);
            this.TxtBoxIv.Name = "TxtBoxIv";
            this.TxtBoxIv.PasswordChar = '*';
            this.TxtBoxIv.Size = new System.Drawing.Size(348, 20);
            this.TxtBoxIv.TabIndex = 1;
            // 
            // LabKey
            // 
            this.LabKey.AutoSize = true;
            this.LabKey.Location = new System.Drawing.Point(9, 12);
            this.LabKey.Name = "LabKey";
            this.LabKey.Size = new System.Drawing.Size(103, 13);
            this.LabKey.TabIndex = 2;
            this.LabKey.Text = "Ключ шифрования:";
            // 
            // LabIv
            // 
            this.LabIv.AutoSize = true;
            this.LabIv.Location = new System.Drawing.Point(9, 53);
            this.LabIv.Name = "LabIv";
            this.LabIv.Size = new System.Drawing.Size(127, 13);
            this.LabIv.TabIndex = 3;
            this.LabIv.Text = "Вектор инициализации:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(12, 95);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Location = new System.Drawing.Point(191, 95);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(170, 23);
            this.BtnApply.TabIndex = 5;
            this.BtnApply.Text = "Применить";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // CryptographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 130);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LabIv);
            this.Controls.Add(this.LabKey);
            this.Controls.Add(this.TxtBoxIv);
            this.Controls.Add(this.TxtBoxKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CryptographyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры шифрования";
            this.Load += new System.EventHandler(this.Cryptography_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxKey;
        private System.Windows.Forms.TextBox TxtBoxIv;
        private System.Windows.Forms.Label LabKey;
        private System.Windows.Forms.Label LabIv;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnApply;
    }
}