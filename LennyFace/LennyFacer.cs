using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Win32;

using LennyFace.Forms;

namespace LennyFace {
    /// <summary>
    /// Main class
    /// </summary>
    public class LennyFacer {

        /// <summary>
        /// Database that contains all the faces.
        /// </summary>
        public static readonly string[] faces = new string[] { "( ͡° ͜ʖ ͡°)", "(ಥ ͜ʖಥ)", "(° ͜ʖ°)", "(͡o‿O͡)" };

        public static readonly string dataPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\lenny";
        public static readonly string runKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";

        public static NotifyIcon tray;

        /// <summary>
        /// Main function (runs when the program starts)
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        private static void Main(string[] args) {
            Console.Title = "Lenny Face";

            Console.WriteLine("LennyFace");
            Console.WriteLine("Copyright (c) 2017-2018 Jerdic, All rights reserved.\n");

            Console.WriteLine($"Running from {Application.ExecutablePath}.");

            Console.WriteLine("Loading configuration...");
            Configuration.config = new Configuration(); //Get default configuration.
            Configuration.Load(); //Load the exists configuration (if one exists).

            HandleConfig();

            SetupTray();

            Application.Run();

            //Console.ReadKey();
        }

        /// <summary>
        /// Changes things that are affected by the config.
        /// </summary>
        public static void HandleConfig() {
            Console.WriteLine("Making changing according to config.");

            //Handle run at startup option.
            if (Configuration.config.runAtStartup) {
                Registry.SetValue(runKey, "LennyFacer", Application.ExecutablePath);
                Console.WriteLine("Run key has been set to exe path.");
            } else {
                Registry.SetValue(runKey, "LennyFacer", "");
                Console.WriteLine("Run key has been set to nothing.");
            }
        }

        /// <summary>
        /// Ensures the main directory exists.
        /// </summary>
        public static void EnsureMainDirectoryExists() {
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);
        }

        /// <summary>
        /// Sets up the tray icon.
        /// </summary>
        public static void SetupTray() {
            Console.WriteLine("Creating tray icon...");

            tray = new NotifyIcon {
                Text = "TestApp",
                Icon = Properties.Resources.lenny_outline_ico /*new Icon("lic")*/ /*new Icon(SystemIcons.Application, 40, 40)*/
            };

            Console.WriteLine("Creating context menu for tray...");
            ContextMenu trayMenu = new ContextMenu();

            //Add all the Lenny Faces to the tray
            Console.WriteLine("Adding faces to tray context menu...");
            foreach (string face in faces) {
                AddToTray(trayMenu, face);
            }

            trayMenu.MenuItems.Add("-");

#if DEBUG
            AddToTray(trayMenu, "Save Config");
            AddToTray(trayMenu, "Load Config");
            trayMenu.MenuItems.Add("-");
#endif

            AddToTray(trayMenu, "Run at start-up?"); //This has to be hard-coded because of C# limitations! :D
            AddToTray(trayMenu, "About"); //This has to be hard-coded because of C# limitations! :D
            AddToTray(trayMenu, "Quit"); //This has to be hard-coded because of C# limitations! :D

            //trayMenu.MenuItems.Add("Blah", Tray_lennyFaceClicked);
            //trayMenu.MenuItems.Add("Blah2", Tray_lennyFaceClicked);
            //trayMenu.MenuItems.Add("Blah3", Tray_lennyFaceClicked);

            tray.ContextMenu = trayMenu;
            tray.Visible = true;
        }

        /// <summary>
        /// Adds an item to the tray.
        /// </summary>
        /// <param name="trayMenu">Context menu to add item to.</param>
        /// <param name="item">Item name.</param>
        public static void AddToTray(ContextMenu trayMenu, string item) {
            Console.WriteLine($"Adding {item} to tray..."); //Log to console.
            trayMenu.MenuItems.Add(item, TrayClicked); //Add the item to the context menu.
        }

        /// <summary>
        /// Event that is called when a tray item is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void TrayClicked(object sender, EventArgs e) {
            //Get the clicked menu item.
            MenuItem item = sender as MenuItem;
            string text = item.Text;

            //Since we can't make these function calls in case statements, we have to store them in a variable.
            //Okay, apparently that still doesn't work.
            //string quitText = Localization.GetString("option_quit");

            switch (text) { //Thanks to the mighty fine limitations of C#, these strings have to be hard-coded! YAY!
                case "Run at start-up?":
                    //Ask the user what they want to do.
                    DialogResult result = MessageBox.Show("Would you like Lenny Facer to run at start-up for this account?", "Lenny Facer",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (result) {
                        case DialogResult.Yes:
                            Console.WriteLine("This program will now run at start-up.");
                            Configuration.config.runAtStartup = true;
                            break;
                        case DialogResult.No:
                            Console.WriteLine("This program will now no longer run at start-up.");
                            Configuration.config.runAtStartup = false;
                            break;
                        default:
                            //Um... what? Yeah let's just crash the program because why not.
                            throw new NotSupportedException();
                    }

                    Configuration.Refresh();
                    break;
                case "About":
                    Console.WriteLine("Showing about form...");
                    new AboutForm().Show();
                    break;
                case "Quit": 
                    tray.Visible = false;
                    Application.Exit();
                    break;
#if DEBUG
                case "Save Config":
                    Configuration.config.Save();
                    break;
                case "Load Config":
                    Configuration.Load();
                    break;
#endif
                default: //If it isn't anything else, let's just asume it's a lenny face.
                    Clipboard.SetText(text);
                    Console.WriteLine($"Copied {text} to clipboard.");
                    break;
            }
        }
    }
}
