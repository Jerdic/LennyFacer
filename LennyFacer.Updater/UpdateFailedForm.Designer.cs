namespace LennyFace.Updater {
    partial class UpdateFailedForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFailedForm));
            this.uhohText = new System.Windows.Forms.Label();
            this.exceptionTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uhohText
            // 
            this.uhohText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uhohText.Location = new System.Drawing.Point(12, 9);
            this.uhohText.Name = "uhohText";
            this.uhohText.Size = new System.Drawing.Size(433, 59);
            this.uhohText.TabIndex = 0;
            this.uhohText.Text = "Lenny Facer failed to update.\r\n\r\nWhat happened?\r\n";
            // 
            // exceptionTextBox
            // 
            this.exceptionTextBox.Location = new System.Drawing.Point(12, 71);
            this.exceptionTextBox.Multiline = true;
            this.exceptionTextBox.Name = "exceptionTextBox";
            this.exceptionTextBox.ReadOnly = true;
            this.exceptionTextBox.Size = new System.Drawing.Size(453, 262);
            this.exceptionTextBox.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 339);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(453, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // UpdateFailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 370);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exceptionTextBox);
            this.Controls.Add(this.uhohText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateFailedForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenny Facer Updater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uhohText;
        private System.Windows.Forms.TextBox exceptionTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}