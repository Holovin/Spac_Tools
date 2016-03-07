namespace DSpacesTools {
    partial class FormSessionAdd {
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
            this.Tabs = new DSpacesTools.TabControlEx();
            this.TabInput = new System.Windows.Forms.TabPage();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.ButtonAddSid = new System.Windows.Forms.Button();
            this.TextBoxSid = new System.Windows.Forms.TextBox();
            this.TabLoading = new System.Windows.Forms.TabPage();
            this.LabelLoadingProcess = new System.Windows.Forms.Label();
            this.ProgressBarLoading = new System.Windows.Forms.ProgressBar();
            this.TabSuccess = new System.Windows.Forms.TabPage();
            this.LabelSuccessTop = new System.Windows.Forms.Label();
            this.LabelSuccess = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.TabInput.SuspendLayout();
            this.GroupBoxInput.SuspendLayout();
            this.TabLoading.SuspendLayout();
            this.TabSuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TabInput);
            this.Tabs.Controls.Add(this.TabLoading);
            this.Tabs.Controls.Add(this.TabSuccess);
            this.Tabs.ItemSize = new System.Drawing.Size(1, 1);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(0, 0);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(354, 217);
            this.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabs.TabIndex = 3;
            // 
            // TabInput
            // 
            this.TabInput.Controls.Add(this.GroupBoxInput);
            this.TabInput.Location = new System.Drawing.Point(4, 5);
            this.TabInput.Name = "TabInput";
            this.TabInput.Padding = new System.Windows.Forms.Padding(3);
            this.TabInput.Size = new System.Drawing.Size(346, 208);
            this.TabInput.TabIndex = 0;
            this.TabInput.Text = "[Input]";
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.ButtonAddSid);
            this.GroupBoxInput.Controls.Add(this.TextBoxSid);
            this.GroupBoxInput.Location = new System.Drawing.Point(6, 6);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(334, 196);
            this.GroupBoxInput.TabIndex = 4;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "Введите SID сессии";
            // 
            // ButtonAddSid
            // 
            this.ButtonAddSid.Location = new System.Drawing.Point(15, 75);
            this.ButtonAddSid.Name = "ButtonAddSid";
            this.ButtonAddSid.Size = new System.Drawing.Size(188, 29);
            this.ButtonAddSid.TabIndex = 2;
            this.ButtonAddSid.Text = "Проверить и добавить";
            this.ButtonAddSid.UseVisualStyleBackColor = true;
            this.ButtonAddSid.Click += new System.EventHandler(this.ButtonAddSid_Click);
            // 
            // TextBoxSid
            // 
            this.TextBoxSid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSid.Location = new System.Drawing.Point(15, 30);
            this.TextBoxSid.Name = "TextBoxSid";
            this.TextBoxSid.Size = new System.Drawing.Size(188, 29);
            this.TextBoxSid.TabIndex = 0;
            // 
            // TabLoading
            // 
            this.TabLoading.Controls.Add(this.LabelLoadingProcess);
            this.TabLoading.Controls.Add(this.ProgressBarLoading);
            this.TabLoading.Location = new System.Drawing.Point(4, 5);
            this.TabLoading.Name = "TabLoading";
            this.TabLoading.Padding = new System.Windows.Forms.Padding(3);
            this.TabLoading.Size = new System.Drawing.Size(346, 208);
            this.TabLoading.TabIndex = 1;
            this.TabLoading.Text = "[Loading]";
            // 
            // LabelLoadingProcess
            // 
            this.LabelLoadingProcess.Location = new System.Drawing.Point(8, 48);
            this.LabelLoadingProcess.Name = "LabelLoadingProcess";
            this.LabelLoadingProcess.Size = new System.Drawing.Size(330, 59);
            this.LabelLoadingProcess.TabIndex = 1;
            this.LabelLoadingProcess.Text = "Проверка sid пользователя...";
            this.LabelLoadingProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarLoading
            // 
            this.ProgressBarLoading.Location = new System.Drawing.Point(52, 110);
            this.ProgressBarLoading.Name = "ProgressBarLoading";
            this.ProgressBarLoading.Size = new System.Drawing.Size(248, 30);
            this.ProgressBarLoading.Step = 33;
            this.ProgressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarLoading.TabIndex = 0;
            // 
            // TabSuccess
            // 
            this.TabSuccess.Controls.Add(this.LabelSuccessTop);
            this.TabSuccess.Controls.Add(this.LabelSuccess);
            this.TabSuccess.Location = new System.Drawing.Point(4, 5);
            this.TabSuccess.Name = "TabSuccess";
            this.TabSuccess.Size = new System.Drawing.Size(346, 208);
            this.TabSuccess.TabIndex = 2;
            this.TabSuccess.Text = "[Success]";
            // 
            // LabelSuccessTop
            // 
            this.LabelSuccessTop.AutoSize = true;
            this.LabelSuccessTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSuccessTop.Location = new System.Drawing.Point(8, 8);
            this.LabelSuccessTop.Name = "LabelSuccessTop";
            this.LabelSuccessTop.Size = new System.Drawing.Size(69, 24);
            this.LabelSuccessTop.TabIndex = 1;
            this.LabelSuccessTop.Text = "Успех!";
            // 
            // LabelSuccess
            // 
            this.LabelSuccess.AutoSize = true;
            this.LabelSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSuccess.Location = new System.Drawing.Point(9, 44);
            this.LabelSuccess.Name = "LabelSuccess";
            this.LabelSuccess.Size = new System.Drawing.Size(217, 26);
            this.LabelSuccess.TabIndex = 0;
            this.LabelSuccess.Text = "Аккаунт добавлен.\r\nЭто оконо будет закрыто через 5 секунд.\r\n";
            // 
            // FormSessionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 217);
            this.Controls.Add(this.Tabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSessionAdd";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSessionAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSessionAdd_FormClosing);
            this.Tabs.ResumeLayout(false);
            this.TabInput.ResumeLayout(false);
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            this.TabLoading.ResumeLayout(false);
            this.TabSuccess.ResumeLayout(false);
            this.TabSuccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControlEx Tabs;
        private System.Windows.Forms.TabPage TabInput;
        private System.Windows.Forms.TabPage TabLoading;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.Button ButtonAddSid;
        private System.Windows.Forms.TextBox TextBoxSid;
        private System.Windows.Forms.ProgressBar ProgressBarLoading;
        private System.Windows.Forms.Label LabelLoadingProcess;
        private System.Windows.Forms.TabPage TabSuccess;
        private System.Windows.Forms.Label LabelSuccessTop;
        private System.Windows.Forms.Label LabelSuccess;
    }
}