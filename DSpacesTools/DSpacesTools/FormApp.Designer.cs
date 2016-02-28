namespace DSpacesTools
{
    partial class FormApp
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ListBoxPlugins = new System.Windows.Forms.ListBox();
            this.GroupBoxPlugins = new System.Windows.Forms.GroupBox();
            this.ButtonReloadPlugins = new System.Windows.Forms.Button();
            this.GroupBoxMenu = new System.Windows.Forms.GroupBox();
            this.LnkLabelCompability = new System.Windows.Forms.LinkLabel();
            this.ButtonPluginRun = new System.Windows.Forms.Button();
            this.TextBoxPluginDescription = new System.Windows.Forms.TextBox();
            this.LabelPluginLink = new System.Windows.Forms.LinkLabel();
            this.LabelPluginAuthor = new System.Windows.Forms.Label();
            this.LabelPluginVersion = new System.Windows.Forms.Label();
            this.LabelPluginName = new System.Windows.Forms.Label();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.MenuMainAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxPlugins.SuspendLayout();
            this.GroupBoxMenu.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(212, 320);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(106, 23);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Login test";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ListBoxPlugins
            // 
            this.ListBoxPlugins.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListBoxPlugins.FormattingEnabled = true;
            this.ListBoxPlugins.Location = new System.Drawing.Point(3, 16);
            this.ListBoxPlugins.Name = "ListBoxPlugins";
            this.ListBoxPlugins.Size = new System.Drawing.Size(194, 290);
            this.ListBoxPlugins.TabIndex = 2;
            this.ListBoxPlugins.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlugins_SelectedIndexChanged);
            // 
            // GroupBoxPlugins
            // 
            this.GroupBoxPlugins.Controls.Add(this.ButtonReloadPlugins);
            this.GroupBoxPlugins.Controls.Add(this.ListBoxPlugins);
            this.GroupBoxPlugins.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxPlugins.Name = "GroupBoxPlugins";
            this.GroupBoxPlugins.Size = new System.Drawing.Size(200, 344);
            this.GroupBoxPlugins.TabIndex = 3;
            this.GroupBoxPlugins.TabStop = false;
            this.GroupBoxPlugins.Text = "Плагины";
            // 
            // ButtonReloadPlugins
            // 
            this.ButtonReloadPlugins.Location = new System.Drawing.Point(3, 310);
            this.ButtonReloadPlugins.Name = "ButtonReloadPlugins";
            this.ButtonReloadPlugins.Size = new System.Drawing.Size(194, 28);
            this.ButtonReloadPlugins.TabIndex = 3;
            this.ButtonReloadPlugins.Text = "Перезагрузить плагины";
            this.ButtonReloadPlugins.UseVisualStyleBackColor = true;
            this.ButtonReloadPlugins.Click += new System.EventHandler(this.ButtonReloadPlugins_Click);
            // 
            // GroupBoxMenu
            // 
            this.GroupBoxMenu.Controls.Add(this.LnkLabelCompability);
            this.GroupBoxMenu.Controls.Add(this.ButtonPluginRun);
            this.GroupBoxMenu.Controls.Add(this.TextBoxPluginDescription);
            this.GroupBoxMenu.Controls.Add(this.ButtonLogin);
            this.GroupBoxMenu.Controls.Add(this.LabelPluginLink);
            this.GroupBoxMenu.Controls.Add(this.LabelPluginAuthor);
            this.GroupBoxMenu.Controls.Add(this.LabelPluginVersion);
            this.GroupBoxMenu.Controls.Add(this.LabelPluginName);
            this.GroupBoxMenu.Location = new System.Drawing.Point(215, 27);
            this.GroupBoxMenu.Name = "GroupBoxMenu";
            this.GroupBoxMenu.Size = new System.Drawing.Size(464, 344);
            this.GroupBoxMenu.TabIndex = 4;
            this.GroupBoxMenu.TabStop = false;
            this.GroupBoxMenu.Text = "Информация и действия";
            // 
            // LnkLabelCompability
            // 
            this.LnkLabelCompability.AutoSize = true;
            this.LnkLabelCompability.LinkColor = System.Drawing.Color.Silver;
            this.LnkLabelCompability.Location = new System.Drawing.Point(15, 318);
            this.LnkLabelCompability.Name = "LnkLabelCompability";
            this.LnkLabelCompability.Size = new System.Drawing.Size(142, 13);
            this.LnkLabelCompability.TabIndex = 8;
            this.LnkLabelCompability.TabStop = true;
            this.LnkLabelCompability.Text = "Минимальные требования";
            this.LnkLabelCompability.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLabelCompability_LinkClicked);
            // 
            // ButtonPluginRun
            // 
            this.ButtonPluginRun.Location = new System.Drawing.Point(324, 316);
            this.ButtonPluginRun.Name = "ButtonPluginRun";
            this.ButtonPluginRun.Size = new System.Drawing.Size(134, 28);
            this.ButtonPluginRun.TabIndex = 7;
            this.ButtonPluginRun.Text = "Запустить";
            this.ButtonPluginRun.UseVisualStyleBackColor = true;
            this.ButtonPluginRun.Click += new System.EventHandler(this.ButtonPluginRun_Click);
            // 
            // TextBoxPluginDescription
            // 
            this.TextBoxPluginDescription.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxPluginDescription.Location = new System.Drawing.Point(18, 68);
            this.TextBoxPluginDescription.Multiline = true;
            this.TextBoxPluginDescription.Name = "TextBoxPluginDescription";
            this.TextBoxPluginDescription.ReadOnly = true;
            this.TextBoxPluginDescription.Size = new System.Drawing.Size(440, 238);
            this.TextBoxPluginDescription.TabIndex = 6;
            this.TextBoxPluginDescription.Text = "Plugin.Description";
            // 
            // LabelPluginLink
            // 
            this.LabelPluginLink.Location = new System.Drawing.Point(324, 34);
            this.LabelPluginLink.Name = "LabelPluginLink";
            this.LabelPluginLink.Size = new System.Drawing.Size(134, 23);
            this.LabelPluginLink.TabIndex = 5;
            this.LabelPluginLink.TabStop = true;
            this.LabelPluginLink.Text = "Plugin.Link";
            this.LabelPluginLink.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LabelPluginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelPluginLink_LinkClicked);
            // 
            // LabelPluginAuthor
            // 
            this.LabelPluginAuthor.Location = new System.Drawing.Point(321, 16);
            this.LabelPluginAuthor.Name = "LabelPluginAuthor";
            this.LabelPluginAuthor.Size = new System.Drawing.Size(137, 18);
            this.LabelPluginAuthor.TabIndex = 4;
            this.LabelPluginAuthor.Text = "by Author.Name";
            this.LabelPluginAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPluginVersion
            // 
            this.LabelPluginVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelPluginVersion.Location = new System.Drawing.Point(15, 42);
            this.LabelPluginVersion.Name = "LabelPluginVersion";
            this.LabelPluginVersion.Size = new System.Drawing.Size(100, 23);
            this.LabelPluginVersion.TabIndex = 3;
            this.LabelPluginVersion.Text = "v1";
            // 
            // LabelPluginName
            // 
            this.LabelPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPluginName.Location = new System.Drawing.Point(14, 16);
            this.LabelPluginName.Name = "LabelPluginName";
            this.LabelPluginName.Size = new System.Drawing.Size(288, 26);
            this.LabelPluginName.TabIndex = 2;
            this.LabelPluginName.Text = "Plugin.Name";
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMainAccounts,
            this.MenuMainAbout});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(684, 24);
            this.MenuMain.TabIndex = 5;
            // 
            // MenuMainAccounts
            // 
            this.MenuMainAccounts.Name = "MenuMainAccounts";
            this.MenuMainAccounts.Size = new System.Drawing.Size(72, 20);
            this.MenuMainAccounts.Text = "Аккаунты";
            this.MenuMainAccounts.Click += new System.EventHandler(this.MenuMainAccounts_Click);
            // 
            // MenuMainAbout
            // 
            this.MenuMainAbout.Name = "MenuMainAbout";
            this.MenuMainAbout.Size = new System.Drawing.Size(94, 20);
            this.MenuMainAbout.Text = "О программе";
            this.MenuMainAbout.Click += new System.EventHandler(this.MenuMainAbout_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 382);
            this.Controls.Add(this.GroupBoxMenu);
            this.Controls.Add(this.GroupBoxPlugins);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 420);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.Load += new System.EventHandler(this.App_Load);
            this.GroupBoxPlugins.ResumeLayout(false);
            this.GroupBoxMenu.ResumeLayout(false);
            this.GroupBoxMenu.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.ListBox ListBoxPlugins;
        private System.Windows.Forms.GroupBox GroupBoxPlugins;
        private System.Windows.Forms.GroupBox GroupBoxMenu;
        private System.Windows.Forms.Button ButtonReloadPlugins;
        private System.Windows.Forms.TextBox TextBoxPluginDescription;
        private System.Windows.Forms.LinkLabel LabelPluginLink;
        private System.Windows.Forms.Label LabelPluginAuthor;
        private System.Windows.Forms.Label LabelPluginVersion;
        private System.Windows.Forms.Label LabelPluginName;
        private System.Windows.Forms.Button ButtonPluginRun;
        private System.Windows.Forms.LinkLabel LnkLabelCompability;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuMainAccounts;
        private System.Windows.Forms.ToolStripMenuItem MenuMainAbout;
    }
}

