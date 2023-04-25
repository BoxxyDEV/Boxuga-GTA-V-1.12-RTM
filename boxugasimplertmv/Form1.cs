using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace boxugasimplertmv
{
    
    public partial class boxugasimplertmv : Form
    {

        // This is created by Boxuga but i dont know shit about finding offsets i tried to mess around with netcheat but couldent find anything so heres the source code because im not a talented dev
        PS3API PS3 = new PS3API();
        CCAPI PS3CCAPI = new CCAPI();
        bool gameverbles = true;
        string defaultitle = "Boxuga's RTM Tool (1.12)";
        public boxugasimplertmv()
        {
            InitializeComponent();
        }

        private void CCAPI_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void tmapi_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.ConnectTarget())
                {
                    PS3.CCAPI.Notify(PS3Lib.CCAPI.NotifyIcon.TROPHY4, "Boxuga's RTM Tool has connected");
                    MessageBox.Show("PS3 Connected", "Connection was successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Error Connecting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Check Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void attachps3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.AttachProcess())
                {
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "Boxuga's RTM Tool for 1.12 has attached to the Game");
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "Made By Boxuga");
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.TROPHY4, "Join us on discord discord.gg/w2ATtTMvem");
                    this.Text = "Welcome " + PS3.Extension.ReadString(0x412451E4) + " | " + defaultitle; // shows the players PSN in title
                    MessageBox.Show("The tool has attached", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.toolsgroup.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Check Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Check Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void boxugasimplertmv_Load(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x412451E4, namechangebox.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (gameverbles == true)
                {
                    PS3.Extension.WriteFloat(0x4124527C, 16);
                }
                else
                {
                    PS3.Extension.WriteFloat(0x4124527C, 16);
                }
            }
            else
            {
                if (gameverbles == true)
                {
                    PS3.Extension.WriteFloat(0x4124527C, 1);
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gameverbles = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gameverbles = false;
        }
    }
}
