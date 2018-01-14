using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace LennyFace {
    public class Configuration {

        /// <summary>
        /// The path to the config file.
        /// </summary>
        public static readonly string configPath = Path.Combine(LennyFacer.dataPath, "cfg.lenny");

        public static Configuration config;

        [JsonProperty("0")]
        public string language = "en_US";

        [JsonProperty("1")]
        public bool runAtStartup = true;

        public void Save() {
            Console.WriteLine("Saving config file...");

            //Ensure the directory exists.
            if (!Directory.Exists(LennyFacer.dataPath)) Directory.CreateDirectory(LennyFacer.dataPath);

            //Create the file incase it doesn't exist.
            FileStream fs = new FileStream(configPath, FileMode.OpenOrCreate); //Create a file stream.
            fs.Close(); //Now close the file stream. (If we don't do this, it could give us an error.)

            //Now write to the file.
            File.WriteAllText(configPath, JsonConvert.SerializeObject(this));
        }

        public static void Load() {
            Console.WriteLine("Loading config file...");
            try {
                config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(configPath));
                Console.WriteLine("Config file loaded successfully!"); //If the function call above threw an exception, this won't run.
            } catch (Exception) {
                Console.WriteLine("Failed to load config file!");
            }

            //LennyFacer.HandleConfig();
        }

        public static void Refresh() {
            config.Save(); //Save the config file.
            Thread.Sleep(10); //Just to be safe, add a 10ms delay.
            Load(); //Load the config file.

            LennyFacer.HandleConfig(); //Handle all the options.
        }
    }
}
