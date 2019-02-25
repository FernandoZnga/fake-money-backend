using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backend.Server
{
    public partial class Server : Form
    {
        bool on = true;
        bool toggleLight = true;
        Timer t = new Timer();

        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            OnOffButton.Text = "OFF";
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            if (toggleLight)
            {
                OnOffButton.BackColor = Color.LimeGreen;
                toggleLight = false;
            }
            else
            {
                OnOffButton.BackColor = Color.Gray;
                toggleLight = true;
            }
        }

        private void OnOffButton_Click(object sender, EventArgs e)
        {
            if (on)
            {
                OnOffButton.Text = "ON";
                t.Start();
                on = false;
                SocketConn.AsynchronousSocketListener.StartListening();
            }
            else
            {
                OnOffButton.Text = "OFF";
                OnOffButton.BackColor = Color.Gray;
                t.Stop();
                on = true;
                SocketConn.AsynchronousSocketListener.CloseConnection();
            }
        }
        public void AppendLog(string text)
        {
            ConsoleXml.AppendText (text + "\n");
        }
    }
}
