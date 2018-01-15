using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace LennyFace.Common {
    public class ServerUtil {
        public static readonly string updateInfoURL = "https://raw.githubusercontent.com/Jerdic/UpdateData/master/LennyFacer/current.lenny";

        public static void DownloadFile(string url, string fileName) {
            using (WebClient client = new WebClient()) {
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                client.DownloadFile(url, fileName);
            }
        }

        public static string GetUpdateInfoJson() {
            return GetTextFromUrl(updateInfoURL);
        }

        public static string GetTextFromUrl(string url) {
            WebClient client = new WebClient {
                CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
            };

            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();

            return content;
        }
    }
}
