namespace DSpacesTools {
    partial class FormSessions {
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
            this.components = new System.ComponentModel.Container();
            this.GroupBoxSessions = new System.Windows.Forms.GroupBox();
            this.ListBoxSessions = new System.Windows.Forms.ListBox();
            this.MainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.MainMenuControlItem = new System.Windows.Forms.MenuItem();
            this.MainMenuControlAddItem = new System.Windows.Forms.MenuItem();
            this.MainMenuControlRefreshItem = new System.Windows.Forms.MenuItem();
            this.GroupBoxSessionInfo = new System.Windows.Forms.GroupBox();
            this.LabelSid = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelStatusStatic = new System.Windows.Forms.Label();
            this.LabelLinkAuth = new System.Windows.Forms.LinkLabel();
            this.LabelTimeChecked = new System.Windows.Forms.Label();
            this.LabelTimeCreated = new System.Windows.Forms.Label();
            this.LabelTimeCheckedStatic = new System.Windows.Forms.Label();
            this.LabelTimeCreatedStatic = new System.Windows.Forms.Label();
            this.LabelSidStatic = new System.Windows.Forms.Label();
            this.LabelAccountId = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.MainMenuControlRemoveItem = new System.Windows.Forms.MenuItem();
            this.GroupBoxSessions.SuspendLayout();
            this.GroupBoxSessionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSessions
            // 
            this.GroupBoxSessions.Controls.Add(this.ListBoxSessions);
            this.GroupBoxSessions.Location = new System.Drawing.Point(8, 3);
            this.GroupBoxSessions.Name = "GroupBoxSessions";
            this.GroupBoxSessions.Size = new System.Drawing.Size(173, 289);
            this.GroupBoxSessions.TabIndex = 0;
            this.GroupBoxSessions.TabStop = false;
            this.GroupBoxSessions.Text = "Сессии";
            // 
            // ListBoxSessions
            // 
            this.ListBoxSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxSessions.FormattingEnabled = true;
            this.ListBoxSessions.Items.AddRange(new object[] {
            "< items >"});
            this.ListBoxSessions.Location = new System.Drawing.Point(3, 16);
            this.ListBoxSessions.Name = "ListBoxSessions";
            this.ListBoxSessions.Size = new System.Drawing.Size(167, 270);
            this.ListBoxSessions.TabIndex = 0;
            this.ListBoxSessions.SelectedIndexChanged += new System.EventHandler(this.ListBoxSessions_SelectedIndexChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MainMenuControlItem});
            // 
            // MainMenuControlItem
            // 
            this.MainMenuControlItem.Index = 0;
            this.MainMenuControlItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MainMenuControlAddItem,
            this.MainMenuControlRefreshItem,
            this.MainMenuControlRemoveItem});
            this.MainMenuControlItem.Text = "Управление";
            // 
            // MainMenuControlAddItem
            // 
            this.MainMenuControlAddItem.Index = 0;
            this.MainMenuControlAddItem.Text = "Добавить сессию (SID)";
            this.MainMenuControlAddItem.Click += new System.EventHandler(this.MainMenuControlAddItem_Click);
            // 
            // MainMenuControlRefreshItem
            // 
            this.MainMenuControlRefreshItem.Index = 1;
            this.MainMenuControlRefreshItem.Text = "Обновить список";
            this.MainMenuControlRefreshItem.Click += new System.EventHandler(this.MainMenuControlRefreshItem_Click);
            // 
            // GroupBoxSessionInfo
            // 
            this.GroupBoxSessionInfo.Controls.Add(this.LabelSid);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelStatus);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelStatusStatic);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelLinkAuth);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelTimeChecked);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelTimeCreated);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelTimeCheckedStatic);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelTimeCreatedStatic);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelSidStatic);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelAccountId);
            this.GroupBoxSessionInfo.Controls.Add(this.LabelLogin);
            this.GroupBoxSessionInfo.Location = new System.Drawing.Point(184, 3);
            this.GroupBoxSessionInfo.Name = "GroupBoxSessionInfo";
            this.GroupBoxSessionInfo.Size = new System.Drawing.Size(328, 286);
            this.GroupBoxSessionInfo.TabIndex = 1;
            this.GroupBoxSessionInfo.TabStop = false;
            this.GroupBoxSessionInfo.Text = "Информация";
            // 
            // LabelSid
            // 
            this.LabelSid.AutoSize = true;
            this.LabelSid.Location = new System.Drawing.Point(100, 48);
            this.LabelSid.Name = "LabelSid";
            this.LabelSid.Size = new System.Drawing.Size(103, 13);
            this.LabelSid.TabIndex = 11;
            this.LabelSid.Text = "1234567890123456";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(100, 63);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(72, 13);
            this.LabelStatus.TabIndex = 10;
            this.LabelStatus.Text = "Не проверен";
            // 
            // LabelStatusStatic
            // 
            this.LabelStatusStatic.AutoSize = true;
            this.LabelStatusStatic.Location = new System.Drawing.Point(8, 63);
            this.LabelStatusStatic.Name = "LabelStatusStatic";
            this.LabelStatusStatic.Size = new System.Drawing.Size(47, 13);
            this.LabelStatusStatic.TabIndex = 9;
            this.LabelStatusStatic.Text = "Статус: ";
            // 
            // LabelLinkAuth
            // 
            this.LabelLinkAuth.AutoSize = true;
            this.LabelLinkAuth.Location = new System.Drawing.Point(210, 48);
            this.LabelLinkAuth.Name = "LabelLinkAuth";
            this.LabelLinkAuth.Size = new System.Drawing.Size(109, 13);
            this.LabelLinkAuth.TabIndex = 8;
            this.LabelLinkAuth.TabStop = true;
            this.LabelLinkAuth.Text = "(окрыть в браузере)";
            // 
            // LabelTimeChecked
            // 
            this.LabelTimeChecked.AutoSize = true;
            this.LabelTimeChecked.Location = new System.Drawing.Point(100, 104);
            this.LabelTimeChecked.Name = "LabelTimeChecked";
            this.LabelTimeChecked.Size = new System.Drawing.Size(115, 13);
            this.LabelTimeChecked.TabIndex = 7;
            this.LabelTimeChecked.Text = "00.00.0000 в 00:00:00";
            this.LabelTimeChecked.Click += new System.EventHandler(this.LabelTimeChecked_Click);
            // 
            // LabelTimeCreated
            // 
            this.LabelTimeCreated.AutoSize = true;
            this.LabelTimeCreated.Location = new System.Drawing.Point(100, 89);
            this.LabelTimeCreated.Name = "LabelTimeCreated";
            this.LabelTimeCreated.Size = new System.Drawing.Size(115, 13);
            this.LabelTimeCreated.TabIndex = 6;
            this.LabelTimeCreated.Text = "00.00.0000 в 00:00:00";
            // 
            // LabelTimeCheckedStatic
            // 
            this.LabelTimeCheckedStatic.AutoSize = true;
            this.LabelTimeCheckedStatic.Location = new System.Drawing.Point(8, 104);
            this.LabelTimeCheckedStatic.Name = "LabelTimeCheckedStatic";
            this.LabelTimeCheckedStatic.Size = new System.Drawing.Size(93, 13);
            this.LabelTimeCheckedStatic.TabIndex = 5;
            this.LabelTimeCheckedStatic.Text = "Посл. проверка: ";
            // 
            // LabelTimeCreatedStatic
            // 
            this.LabelTimeCreatedStatic.AutoSize = true;
            this.LabelTimeCreatedStatic.Location = new System.Drawing.Point(8, 89);
            this.LabelTimeCreatedStatic.Name = "LabelTimeCreatedStatic";
            this.LabelTimeCreatedStatic.Size = new System.Drawing.Size(61, 13);
            this.LabelTimeCreatedStatic.TabIndex = 4;
            this.LabelTimeCreatedStatic.Text = "Добавлен:";
            // 
            // LabelSidStatic
            // 
            this.LabelSidStatic.AutoSize = true;
            this.LabelSidStatic.Location = new System.Drawing.Point(8, 48);
            this.LabelSidStatic.Name = "LabelSidStatic";
            this.LabelSidStatic.Size = new System.Drawing.Size(28, 13);
            this.LabelSidStatic.TabIndex = 3;
            this.LabelSidStatic.Text = "SID:";
            // 
            // LabelAccountId
            // 
            this.LabelAccountId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelAccountId.Location = new System.Drawing.Point(238, 16);
            this.LabelAccountId.Name = "LabelAccountId";
            this.LabelAccountId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelAccountId.Size = new System.Drawing.Size(84, 13);
            this.LabelAccountId.TabIndex = 2;
            this.LabelAccountId.Text = "12345";
            // 
            // LabelLogin
            // 
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(6, 16);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(227, 29);
            this.LabelLogin.TabIndex = 0;
            this.LabelLogin.Text = "Login1234567890";
            // 
            // MainMenuControlRemoveItem
            // 
            this.MainMenuControlRemoveItem.Index = 2;
            this.MainMenuControlRemoveItem.Text = "Удалить выбранную сессию";
            this.MainMenuControlRemoveItem.Click += new System.EventHandler(this.MainMenuControlRemoveItem_Click);
            // 
            // FormSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 317);
            this.Controls.Add(this.GroupBoxSessionInfo);
            this.Controls.Add(this.GroupBoxSessions);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 355);
            this.Menu = this.MainMenu;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 355);
            this.Name = "FormSessions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSessions";
            this.GroupBoxSessions.ResumeLayout(false);
            this.GroupBoxSessionInfo.ResumeLayout(false);
            this.GroupBoxSessionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSessions;
        private System.Windows.Forms.MainMenu MainMenu;
        private System.Windows.Forms.ListBox ListBoxSessions;
        private System.Windows.Forms.GroupBox GroupBoxSessionInfo;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelAccountId;
        private System.Windows.Forms.Label LabelTimeChecked;
        private System.Windows.Forms.Label LabelTimeCreated;
        private System.Windows.Forms.Label LabelTimeCheckedStatic;
        private System.Windows.Forms.Label LabelTimeCreatedStatic;
        private System.Windows.Forms.Label LabelSidStatic;
        private System.Windows.Forms.LinkLabel LabelLinkAuth;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelStatusStatic;
        private System.Windows.Forms.Label LabelSid;
        private System.Windows.Forms.MenuItem MainMenuControlItem;
        private System.Windows.Forms.MenuItem MainMenuControlAddItem;
        private System.Windows.Forms.MenuItem MainMenuControlRefreshItem;
        private System.Windows.Forms.MenuItem MainMenuControlRemoveItem;
    }
}