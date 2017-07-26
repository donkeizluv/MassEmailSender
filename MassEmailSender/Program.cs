using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using MassEmailSender.Forms;
using System.Windows.Forms;

namespace MassEmailSender
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] agrs)
        {
            string server = string.Empty;
            int port = 0;
            bool flag = false;
            if (agrs.Count() > 0)
            {
                try
                {
                    ParseCustomServer(agrs, out server, out port);
                    flag = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (flag)
            {
                Application.Run(new FormMain(server, port));
            }
            else
            {
                Application.Run(new FormMain());
            }
        }

        private static void ParseCustomServer(string[] agrs, out string server, out int port)
        {
            var splited = agrs.First().Split(':');
            if (splited.Count() != 2)
            {
                throw new ArgumentException("invalid arguments");
            }
            server = splited[0];
            port = int.Parse(splited[1]);
        }

        public static string ExeDir
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string Version
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                return fvi.FileVersion;
            }
        }
    }
}