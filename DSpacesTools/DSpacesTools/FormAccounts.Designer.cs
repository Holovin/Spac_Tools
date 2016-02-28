namespace DSpacesTools {
    partial class FormAccounts {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ListAccounts = new System.Windows.Forms.ListBox();
            this.GroupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.GroupBoxAccountInfo = new System.Windows.Forms.GroupBox();
            this.LabelAccountValid = new System.Windows.Forms.Label();
            this.ButtonAccountExit = new System.Windows.Forms.Button();
            this.LabelAccountAuthType = new System.Windows.Forms.Label();
            this.LabelAccountId = new System.Windows.Forms.Label();
            this.LabelAccountName = new System.Windows.Forms.Label();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuMainAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainAccountsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.постоянныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.временнйыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainAccountsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.GroupBoxAccounts.SuspendLayout();
            this.GroupBoxAccountInfo.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListAccounts
            // 
            this.ListAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAccounts.FormattingEnabled = true;
            this.ListAccounts.Items.AddRange(new object[] {
            "Пусто"});
            this.ListAccounts.Location = new System.Drawing.Point(3, 16);
            this.ListAccounts.Name = "ListAccounts";
            this.ListAccounts.Size = new System.Drawing.Size(175, 237);
            this.ListAccounts.TabIndex = 0;
            // 
            // GroupBoxAccounts
            // 
            this.GroupBoxAccounts.Controls.Add(this.ListAccounts);
            this.GroupBoxAccounts.Location = new System.Drawing.Point(12, 28);
            this.GroupBoxAccounts.Name = "GroupBoxAccounts";
            this.GroupBoxAccounts.Size = new System.Drawing.Size(181, 256);
            this.GroupBoxAccounts.TabIndex = 1;
            this.GroupBoxAccounts.TabStop = false;
            this.GroupBoxAccounts.Text = "Список аккаунтов";
            // 
            // GroupBoxAccountInfo
            // 
            this.GroupBoxAccountInfo.Controls.Add(this.LabelAccountValid);
            this.GroupBoxAccountInfo.Controls.Add(this.ButtonAccountExit);
            this.GroupBoxAccountInfo.Controls.Add(this.LabelAccountAuthType);
            this.GroupBoxAccountInfo.Controls.Add(this.LabelAccountId);
            this.GroupBoxAccountInfo.Controls.Add(this.LabelAccountName);
            this.GroupBoxAccountInfo.Location = new System.Drawing.Point(199, 28);
            this.GroupBoxAccountInfo.Name = "GroupBoxAccountInfo";
            this.GroupBoxAccountInfo.Size = new System.Drawing.Size(317, 256);
            this.GroupBoxAccountInfo.TabIndex = 2;
            this.GroupBoxAccountInfo.TabStop = false;
            this.GroupBoxAccountInfo.Text = "Информация о аккаунте";
            // 
            // LabelAccountValid
            // 
            this.LabelAccountValid.AutoSize = true;
            this.LabelAccountValid.Location = new System.Drawing.Point(15, 44);
            this.LabelAccountValid.Name = "LabelAccountValid";
            this.LabelAccountValid.Size = new System.Drawing.Size(230, 13);
            this.LabelAccountValid.TabIndex = 4;
            this.LabelAccountValid.Text = "Not connected (last check: 29/02/2016 00:04)";
            // 
            // ButtonAccountExit
            // 
            this.ButtonAccountExit.Location = new System.Drawing.Point(195, 220);
            this.ButtonAccountExit.Name = "ButtonAccountExit";
            this.ButtonAccountExit.Size = new System.Drawing.Size(116, 30);
            this.ButtonAccountExit.TabIndex = 3;
            this.ButtonAccountExit.Text = "Выйти";
            this.ButtonAccountExit.UseVisualStyleBackColor = true;
            // 
            // LabelAccountAuthType
            // 
            this.LabelAccountAuthType.AutoSize = true;
            this.LabelAccountAuthType.Location = new System.Drawing.Point(15, 63);
            this.LabelAccountAuthType.Name = "LabelAccountAuthType";
            this.LabelAccountAuthType.Size = new System.Drawing.Size(77, 13);
            this.LabelAccountAuthType.TabIndex = 2;
            this.LabelAccountAuthType.Text = "AuthType: SID";
            // 
            // LabelAccountId
            // 
            this.LabelAccountId.AutoSize = true;
            this.LabelAccountId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelAccountId.Location = new System.Drawing.Point(227, 16);
            this.LabelAccountId.Name = "LabelAccountId";
            this.LabelAccountId.Size = new System.Drawing.Size(84, 13);
            this.LabelAccountId.TabIndex = 1;
            this.LabelAccountId.Text = "ID: 1234567890";
            // 
            // LabelAccountName
            // 
            this.LabelAccountName.AutoSize = true;
            this.LabelAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAccountName.Location = new System.Drawing.Point(14, 16);
            this.LabelAccountName.Name = "LabelAccountName";
            this.LabelAccountName.Size = new System.Drawing.Size(136, 24);
            this.LabelAccountName.TabIndex = 0;
            this.LabelAccountName.Text = "Account.Name";
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMainAccounts});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(524, 24);
            this.MenuMain.TabIndex = 3;
            this.MenuMain.Text = "MenuMain";
            // 
            // MenuMainAccounts
            // 
            this.MenuMainAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMainAccountsAdd,
            this.MenuMainAccountsSep1});
            this.MenuMainAccounts.Name = "MenuMainAccounts";
            this.MenuMainAccounts.Size = new System.Drawing.Size(72, 20);
            this.MenuMainAccounts.Text = "Аккаунты";
            // 
            // MenuMainAccountsAdd
            // 
            this.MenuMainAccountsAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постоянныйToolStripMenuItem,
            this.временнйыToolStripMenuItem});
            this.MenuMainAccountsAdd.Name = "MenuMainAccountsAdd";
            this.MenuMainAccountsAdd.Size = new System.Drawing.Size(126, 22);
            this.MenuMainAccountsAdd.Text = "Добавить";
            // 
            // постоянныйToolStripMenuItem
            // 
            this.постоянныйToolStripMenuItem.Name = "постоянныйToolStripMenuItem";
            this.постоянныйToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.постоянныйToolStripMenuItem.Text = "Постоянный";
            // 
            // временнйыToolStripMenuItem
            // 
            this.временнйыToolStripMenuItem.Name = "временнйыToolStripMenuItem";
            this.временнйыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.временнйыToolStripMenuItem.Text = "Временный";
            // 
            // MenuMainAccountsSep1
            // 
            this.MenuMainAccountsSep1.Name = "MenuMainAccountsSep1";
            this.MenuMainAccountsSep1.Size = new System.Drawing.Size(123, 6);
            // 
            // FormAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 292);
            this.Controls.Add(this.GroupBoxAccountInfo);
            this.Controls.Add(this.GroupBoxAccounts);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 330);
            this.Name = "FormAccounts";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAccounts";
            this.Load += new System.EventHandler(this.FormAccounts_Load);
            this.GroupBoxAccounts.ResumeLayout(false);
            this.GroupBoxAccountInfo.ResumeLayout(false);
            this.GroupBoxAccountInfo.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListAccounts;
        private System.Windows.Forms.GroupBox GroupBoxAccounts;
        private System.Windows.Forms.GroupBox GroupBoxAccountInfo;
        private System.Windows.Forms.Label LabelAccountName;
        private System.Windows.Forms.Label LabelAccountId;
        private System.Windows.Forms.Label LabelAccountAuthType;
        private System.Windows.Forms.Button ButtonAccountExit;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuMainAccounts;
        private System.Windows.Forms.ToolStripMenuItem MenuMainAccountsAdd;
        private System.Windows.Forms.ToolStripMenuItem постоянныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem временнйыToolStripMenuItem;
        private System.Windows.Forms.Label LabelAccountValid;
        private System.Windows.Forms.ToolStripSeparator MenuMainAccountsSep1;
    }
}