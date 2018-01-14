using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LennyFace {
    public class Localization {

        public static Dictionary<string, string> strings = new Dictionary<string, string>();

        public static string quitText = "Quit";

        static Localization() {
            strings["option_quit"] = "Quit";
        }

        public static string GetString(string str) {
            return GetString(str, null);
        }

        public static string GetString(string str, object[] replace) {
            return String.Format(strings[str], replace);
        }

    }
}
