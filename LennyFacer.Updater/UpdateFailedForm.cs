using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LennyFace.Updater {
    public partial class UpdateFailedForm : Form {
        public UpdateFailedForm() {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e) {

        }

        public void ChangeExceptionText(string exception) {
            exceptionTextBox.Text = exception;
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
