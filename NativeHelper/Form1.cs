using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NativeHelper
{
    public partial class Form1 : Form
    {
        public static string WorkDir = "";

        public Form1()
        {
            InitializeComponent();
        }

        public static string RunCMD(string Command)
        {
            Process pProcess = new Process();
            pProcess.StartInfo.FileName = "cmd.exe";
            pProcess.StartInfo.Arguments = "/c " + Command;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            return strOutput;
        }

        private void Build_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WorkDir = sfd.FileName;
            }

            #region Command

            string Arch = "";
            string Platform = "";
            string Folder = "";

            if (x64.Checked) { Arch = "x64"; }
            else if (Arm64.Checked) { Arch = "Arm64"; }
            else { return; }

            if (Windows.Checked) { Platform = "win"; }
            else if (Linux.Checked) { Platform = "linux"; }
            else { return; }

            if (Release.Checked) { Folder = "Release"; }
            else if (Debug.Checked) { Folder = "Debug"; }
            else { return; }

            string Command = "dotnet publish -r " + Platform + "-" + Arch + " -c " + Folder + " -p:PublishAot=true";

            string Source = Properties.Resources.Source;
            Source = Source.Replace("[COMMAND]", Command);
            Source = Source.Replace("[DIRECTORY]", WorkDir);

            #endregion Command

            CodeDom.Compile(Path.GetDirectoryName(WorkDir) + "\\Native.exe", Source);
            Process.Start(Path.GetDirectoryName(WorkDir) + "\\Native.exe");

            MessageBox.Show("Done :)", "NativeHelper");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var Output = RunCMD("dotnet --version");
            MessageBox.Show(Output);
        }
    }
}