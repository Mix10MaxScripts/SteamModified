using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SteamModified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.gta5-mods.com/tools/script-hook-v";
            System.Diagnostics.Process.Start("msedge.exe", url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://openiv.com/";
            System.Diagnostics.Process.Start("msedge.exe", url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://gta5-mods.com";
            System.Diagnostics.Process.Start("msedge.exe", url);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string url = "https://www.gta5-mods.com/tools/scripthookv-net.";
            System.Diagnostics.Process.Start("msedge.exe", url);
        
        }

        private void button4_Click(object sender, EventArgs e)
           
        {
            string url = "https://www.youtube.com/watch?v=4xmWKH-RIMA";
            System.Diagnostics.Process.Start("msedge.exe", url);
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\GarrysMod\\hl2.exe");
        }
    }
}
