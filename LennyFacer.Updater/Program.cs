using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

using Newtonsoft.Json;

using LennyFace.Common;

using Ionic.Zip;

namespace LennyFace.Updater {
    public class Program {

        public const string downloadPath = "update_package.lenny";
        public const string lennyFacerExe = "LennyFacer.exe";

        public static string updateInfoJson;
        public static UpdateInfo updateInfo;

        private static void Main(string[] args) {
            //Get update info json.
            Console.WriteLine("Getting update info json...");

            if (args.Length != 0) {
                //Get json from arguments.
                updateInfoJson = args[0]; 
            } else {
                Console.WriteLine("Update info json wasn't in arguments, which means the program was probably ran manually.");
                updateInfoJson = ServerUtil.GetUpdateInfoJson(); //Download update info.
            }

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
            File.Copy(lennyFacerExe, lennyFacerExeBackup); //Backup the current version in case anything happens.

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
        }
    }
}
