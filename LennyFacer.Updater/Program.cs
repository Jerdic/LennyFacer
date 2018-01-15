using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using Newtonsoft.Json;

using LennyFace.Common;

using Ionic.Zip;

namespace LennyFace.Updater {
    public class Program {

        [STAThread]
        private static void Main(string[] args) {
            //infoForm = new InfoForm();
            Application.Run(new InfoForm());
        }
    }
}
