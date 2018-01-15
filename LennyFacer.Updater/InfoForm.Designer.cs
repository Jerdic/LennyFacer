namespace LennyFace.Updater {
    partial class InfoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.operationText = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // operationText
            // 
            this.operationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationText.Location = new System.Drawing.Point(-23, -31);
            this.operationText.Name = "operationText";
            this.operationText.Size = new System.Drawing.Size(433, 169);
            this.operationText.TabIndex = 0;
            this.operationText.Text = "Lenny Facer is updating...";
            this.operationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delay
            // 
            this.delay.Enabled = true;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 107);
            this.ControlBox = false;
            this.Controls.Add(this.operationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenny Facer Updater";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label operationText;
        private System.Windows.Forms.Timer delay;
    }
}