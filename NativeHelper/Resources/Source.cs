using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace Starter
{
    internal class Program
    {
        static void Main()
        {
            if (RunCMD("[COMMAND]", System.IO.Path.GetDirectoryName(@"[DIRECTORY]")))
                MessageBox.Show("Compiled.");
            else
                MessageBox.Show("Error.");
        }

        public static bool RunCMD(string Command, string Work)
        {
            bool ReturnState;
            Process pProcess = new Process();
            pProcess.StartInfo.FileName = "cmd.exe";
            pProcess.StartInfo.Arguments = "/c " + Command;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.WorkingDirectory = Work;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            if (strOutput.Contains("MSBuild")) { ReturnState = true; } else { ReturnState = false; }
            pProcess.WaitForExit();

            return ReturnState;
        }
    }
}
