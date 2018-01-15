using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LennyFace.Forms {
    public partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void OpenUrl(string url) {
            Process.Start(url);
        }

        private void jerdicWebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://jerdic.com");
        }

        private void jerdicTwitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://twitter.com/JerdicOfficial");
        }

        private void jerdicYoutubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://www.youtube.com/channel/UCcuTnkAe_Ius2t0W5pT0o7g");
        }

        private void djmanTwitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://twitter.com/DigitalJokerMan");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenUrl("https://www.youtube.com/DJMANOfficial");
        }

        private void AboutForm_Load(object sender, EventArgs e) {
            versionLabel.Text = LennyFacer.GetVersionDisplay(LennyFacer.versionDisplay);
        }
    }
}
