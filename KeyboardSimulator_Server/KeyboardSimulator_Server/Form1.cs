using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardSimulator_Server
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        ConnectUnit _connect;
        Boolean _isStarted = false;
        Boolean _isStartedListenning = false;
        public Form1()
        {
            InitializeComponent();

            initUserInterface();

            initNonInterface();
        }

        void initUserInterface()
        {
            textEdit_Port.ReadOnly = true;
            textEdit_IP.ReadOnly = true;
            richTextBox_Client.ReadOnly = true;
            richTextBox_KeyStroke.ReadOnly = true;

            richTextBox_KeyStroke.Enabled = false;
            textEdit_IP.Enabled = false;
            textEdit_Port.Enabled = false;
            richTextBox_Client.Enabled = false;
        }
        
        void initNonInterface()
        {
            _connect = new ConnectUnit();

            _connect.startServer();

            textEdit_Port.Text = _connect.getPort();
            textEdit_IP.Text = _connect.getIP();

            timer_GetClient.Interval = 1000;
            timer_GetClient.Enabled = false;

            mouseKeyEventProvider.Enabled = false;
        }

        /// <summary>
        /// Nếu bật sang On:
        ///     - Bắt đầu Listen
        ///     - Bắt đầu hook key
        /// Nếu bật sang Off:
        ///     - Tắt hook key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggleSwitch_Toggled(object sender, EventArgs e)
        {
            _isStartedListenning = !_isStartedListenning;

            if (_isStartedListenning)
            {
                richTextBox_KeyStroke.Enabled = true;
                textEdit_IP.Enabled = true;
                textEdit_Port.Enabled = true;
                richTextBox_Client.Enabled = true;
                timer_GetClient.Enabled = true;

                _connect.startListen();
                _isStarted = true;
                mouseKeyEventProvider.Enabled = true;
            }
            else
            {
                richTextBox_KeyStroke.Enabled = false;
                textEdit_IP.Enabled = false;
                textEdit_Port.Enabled = false;
                richTextBox_Client.Enabled = false;

                _isStarted = false;
                mouseKeyEventProvider.Enabled = false;
            }

        }

        private void timer_GetClient_Tick(object sender, EventArgs e)
        {
            if (!_isStarted) return;

            String client = _connect.getIPClient();
            if (client == "")
            {
                richTextBox_Client.AppendText("Waiting connection...\n");
                return;
            }

            richTextBox_Client.Clear();
            richTextBox_Client.AppendText(client + " has been connected\n");
        }

        private void mouseKeyEventProvider_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_connect.getIPClient() == "") return;
            richTextBox_KeyStroke.AppendText(e.KeyChar.ToString());
            _connect.sendChar(e.KeyChar);
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _connect.close();
        }
    }
}
