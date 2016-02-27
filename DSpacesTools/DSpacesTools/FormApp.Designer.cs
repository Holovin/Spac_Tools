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
            this.ButtonLoadPluginDemo = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLoadPluginDemo
            // 
            this.ButtonLoadPluginDemo.Location = new System.Drawing.Point(12, 12);
            this.ButtonLoadPluginDemo.Name = "ButtonLoadPluginDemo";
            this.ButtonLoadPluginDemo.Size = new System.Drawing.Size(106, 23);
            this.ButtonLoadPluginDemo.TabIndex = 0;
            this.ButtonLoadPluginDemo.Text = "Load demo plugin";
            this.ButtonLoadPluginDemo.UseVisualStyleBackColor = true;
            this.ButtonLoadPluginDemo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(12, 41);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(106, 23);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Login test";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 309);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.ButtonLoadPluginDemo);
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormApp";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLoadPluginDemo;
        private System.Windows.Forms.Button ButtonLogin;
    }
}

