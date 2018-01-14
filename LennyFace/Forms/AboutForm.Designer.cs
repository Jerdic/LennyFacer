namespace LennyFace.Forms {
    partial class AboutForm {
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
            this.lennyFacerIcon = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.sloganText = new System.Windows.Forms.Label();
            this.copyrightText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.jerdicTwitterLink = new System.Windows.Forms.LinkLabel();
            this.djmanTwitterLink = new System.Windows.Forms.LinkLabel();
            this.jerdicWebsiteLink = new System.Windows.Forms.LinkLabel();
            this.jerdicYoutubeLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lennyFacerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lennyFacerIcon
            // 
            this.lennyFacerIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lennyFacerIcon.Image = global::LennyFace.Properties.Resources.lenny_outline_png;
            this.lennyFacerIcon.Location = new System.Drawing.Point(0, 5);
            this.lennyFacerIcon.Name = "lennyFacerIcon";
            this.lennyFacerIcon.Size = new System.Drawing.Size(222, 215);
            this.lennyFacerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lennyFacerIcon.TabIndex = 0;
            this.lennyFacerIcon.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(222, 8);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(421, 52);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "LennyFacer";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sloganText
            // 
            this.sloganText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloganText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganText.Location = new System.Drawing.Point(220, 53);
            this.sloganText.Name = "sloganText";
            this.sloganText.Size = new System.Drawing.Size(421, 24);
            this.sloganText.TabIndex = 1;
            this.sloganText.Text = "\"For all your Lenny Face needs!\"\r\n";
            this.sloganText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyrightText
            // 
            this.copyrightText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyrightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightText.Location = new System.Drawing.Point(220, 79);
            this.copyrightText.Name = "copyrightText";
            this.copyrightText.Size = new System.Drawing.Size(421, 24);
            this.copyrightText.TabIndex = 1;
            this.copyrightText.Text = "(c) 2017-2018 Jerdic, All rights reserved.";
            this.copyrightText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(559, 194);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // jerdicTwitterLink
            // 
            this.jerdicTwitterLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jerdicTwitterLink.Location = new System.Drawing.Point(223, 121);
            this.jerdicTwitterLink.Name = "jerdicTwitterLink";
            this.jerdicTwitterLink.Size = new System.Drawing.Size(418, 19);
            this.jerdicTwitterLink.TabIndex = 3;
            this.jerdicTwitterLink.TabStop = true;
            this.jerdicTwitterLink.Text = "Jerdic\'s Twitter";
            this.jerdicTwitterLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jerdicTwitterLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.jerdicTwitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jerdicTwitterLink_LinkClicked);
            // 
            // djmanTwitterLink
            // 
            this.djmanTwitterLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.djmanTwitterLink.Location = new System.Drawing.Point(223, 155);
            this.djmanTwitterLink.Name = "djmanTwitterLink";
            this.djmanTwitterLink.Size = new System.Drawing.Size(418, 19);
            this.djmanTwitterLink.TabIndex = 3;
            this.djmanTwitterLink.TabStop = true;
            this.djmanTwitterLink.Text = "DJMAN\'s Twitter";
            this.djmanTwitterLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.djmanTwitterLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.djmanTwitterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.djmanTwitterLink_LinkClicked);
            // 
            // jerdicWebsiteLink
            // 
            this.jerdicWebsiteLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jerdicWebsiteLink.Location = new System.Drawing.Point(223, 104);
            this.jerdicWebsiteLink.Name = "jerdicWebsiteLink";
            this.jerdicWebsiteLink.Size = new System.Drawing.Size(418, 19);
            this.jerdicWebsiteLink.TabIndex = 3;
            this.jerdicWebsiteLink.TabStop = true;
            this.jerdicWebsiteLink.Text = "Jerdic\'s Website";
            this.jerdicWebsiteLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jerdicWebsiteLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.jerdicWebsiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jerdicWebsiteLink_LinkClicked);
            // 
            // jerdicYoutubeLink
            // 
            this.jerdicYoutubeLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jerdicYoutubeLink.Location = new System.Drawing.Point(223, 138);
            this.jerdicYoutubeLink.Name = "jerdicYoutubeLink";
            this.jerdicYoutubeLink.Size = new System.Drawing.Size(418, 19);
            this.jerdicYoutubeLink.TabIndex = 3;
            this.jerdicYoutubeLink.TabStop = true;
            this.jerdicYoutubeLink.Text = "Jerdic\'s YouTube";
            this.jerdicYoutubeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jerdicYoutubeLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.jerdicYoutubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.jerdicYoutubeLink_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.Location = new System.Drawing.Point(223, 171);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(418, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DJMAN\'s YouTube";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 223);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.djmanTwitterLink);
            this.Controls.Add(this.jerdicWebsiteLink);
            this.Controls.Add(this.jerdicYoutubeLink);
            this.Controls.Add(this.jerdicTwitterLink);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.copyrightText);
            this.Controls.Add(this.sloganText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.lennyFacerIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.lennyFacerIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lennyFacerIcon;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label sloganText;
        private System.Windows.Forms.Label copyrightText;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.LinkLabel jerdicTwitterLink;
        private System.Windows.Forms.LinkLabel djmanTwitterLink;
        private System.Windows.Forms.LinkLabel jerdicWebsiteLink;
        private System.Windows.Forms.LinkLabel jerdicYoutubeLink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}