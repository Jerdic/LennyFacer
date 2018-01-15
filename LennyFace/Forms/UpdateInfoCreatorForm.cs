using System;
using System.Windows.Forms;

using Newtonsoft.Json;

using LennyFace.Common;

namespace LennyFace.Forms {
    public partial class UpdateInfoCreatorForm : Form {
        public UpdateInfoCreatorForm() {
            InitializeComponent();

            //Change to default values.
            versionNumberTextbox.Text = (LennyFacer.versionNumber + 1).ToString();
            versionDisplayTextBox.Text = LennyFacer.versionDisplay;
        }

        private void generateUpdateInfoButton_Click(object sender, EventArgs e) {
            outputTextbox.Text = GenerateJson(formatJsonCheckBox.Checked);
        }

        public string GenerateJson(bool pretty) {
            Console.WriteLine("Generating update info...");

            Formatting formatting;

            if (pretty) formatting = Formatting.Indented;
            else formatting = Formatting.None;

            return JsonConvert.SerializeObject(new UpdateInfo {
                versionNumber = Convert.ToInt32(versionNumberTextbox.Text),
                codename = codeNameTextBox.Text,
                description = descriptionTextBox.Text,
                changelog = changelogTextbox.Text,
                versionDisplay = versionDisplayTextBox.Text,
                updateDate = DateTime.Now,
                downloadUrl = downloadUrlTextBox.Text,
                versionType = VersionType.RELEASE
            }, formatting);
        }
    }
}
