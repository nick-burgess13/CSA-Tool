using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NickCSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //string desPath = "C:\Users\Nick\Downloads";
          
            WebClient wc = new WebClient();
            //wc.Headers.Add()
            if (!Directory.Exists("D:\\") {
                Directory.CreateDirectory("")
            }
            wc.DownloadFile(new Uri("https://www.kauailabs.com/public_files/navx-mxp/navx-mxp.zip"), "D:\\");

            
        }
      

    }

}
