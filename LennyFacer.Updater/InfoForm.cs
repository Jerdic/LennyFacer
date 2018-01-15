using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using Newtonsoft.Json;

using LennyFace.Common;

using Ionic.Zip;

namespace LennyFace.Updater {
    public partial class InfoForm : Form {
        public const string downloadPath = "update_package.lenny";
        public const string lennyFacerExe = "LennyFacer.exe";

        public static string updateInfoJson;
        public static UpdateInfo updateInfo;
        //public static InfoForm infoForm;


        public InfoForm() {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e) {
            
        }

        private void DoTheThing() {
            try {
                //throw new Exception();
                //Get update info json.
                Console.WriteLine("Getting update info json...");

                //if (Environment.GetCommandLineArgs().Length != 0) {
                //    //Get json from arguments.
                //    updateInfoJson = Environment.GetCommandLineArgs()[0];
                //} else {
                Console.WriteLine("Update info json wasn't in arguments, which means the program was probably ran manually.");
                updateInfoJson = ServerUtil.GetUpdateInfoJson(); //Download update info.
                //}

                updateInfo = JsonConvert.DeserializeObject<UpdateInfo>(updateInfoJson); //Convert the json.

                Console.WriteLine($"Downloading file {updateInfo.downloadUrl}...");

                ServerUtil.DownloadFile(updateInfo.downloadUrl, downloadPath); //Download the package.

                //Kill all instances of Lenny Facer
                foreach (Process instance in Process.GetProcessesByName(lennyFacerExe)) {
                    Console.WriteLine($"Killing instance of Lenny Facer with PID of {instance.Id}.");
                    instance.Kill();
                }

                string lennyFacerExeBackup = lennyFacerExe + ".backup";

                //Try to delete the current backup.
                try {
                    File.Delete(lennyFacerExeBackup);
                } catch (Exception) { }

                try {
                    File.Copy(lennyFacerExe, lennyFacerExeBackup); //Backup the current version in case anything happens.
                } catch (Exception) { }

                ZipFile package = ZipFile.Read(downloadPath); //Read package as zip file.
                foreach (ZipEntry entry in package.Entries) {
                    try {
                        entry.Extract(Directory.GetCurrentDirectory(), ExtractExistingFileAction.OverwriteSilently);
                    } catch (Exception) {
                        Console.WriteLine($"Failed to overwrite {entry.FileName}.");
                    }
                }
                //package.ExtractAll(Directory.GetCurrentDirectory(), ExtractExistingFileAction.OverwriteSilently); //Extract the package, overwriting everything.

                Console.WriteLine("Launching Lenny Facer...");
                Process.Start(lennyFacerExe, "-uf");

                Application.Exit();
            } catch (Exception ex) {
                Opacity = 0;

                UpdateFailedForm updateFailedForm = new UpdateFailedForm();
                updateFailedForm.ChangeExceptionText($"{ex.ToString()}");
                updateFailedForm.Show();
            }
        }

        private void delay_Tick(object sender, EventArgs e) {
            delay.Enabled = false;

            DoTheThing();
        }
    }
}
