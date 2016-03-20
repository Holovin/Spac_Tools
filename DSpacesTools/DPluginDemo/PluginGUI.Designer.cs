namespace DPluginDemo
{
    partial class PluginGui
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
            this.LabelText = new System.Windows.Forms.Label();
            this.ButtonCheckNetwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Location = new System.Drawing.Point(12, 9);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(88, 13);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "Hello from plugin!";
            // 
            // ButtonCheckNetwork
            // 
            this.ButtonCheckNetwork.Location = new System.Drawing.Point(12, 36);
            this.ButtonCheckNetwork.Name = "ButtonCheckNetwork";
            this.ButtonCheckNetwork.Size = new System.Drawing.Size(95, 23);
            this.ButtonCheckNetwork.TabIndex = 1;
            this.ButtonCheckNetwork.Text = "Check network";
            this.ButtonCheckNetwork.UseVisualStyleBackColor = true;
            this.ButtonCheckNetwork.Click += new System.EventHandler(this.ButtonCheckNetwork_Click);
            // 
            // PluginGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 251);
            this.Controls.Add(this.ButtonCheckNetwork);
            this.Controls.Add(this.LabelText);
            this.MaximizeBox = false;
            this.Name = "PluginGui";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PluginGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PluginGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button ButtonCheckNetwork;
    }
}