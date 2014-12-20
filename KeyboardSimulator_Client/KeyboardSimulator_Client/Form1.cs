using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KeyboardSimulator_Server;
using WindowsInput;
namespace KeyboardSimulator_Client
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm,RecieveChar
    {
        Boolean _isConnected = false;
        Boolean _isOn = false;

        ConnectUnit _connect;

        public Form1()
        {
            InitializeComponent();

            initUserInterface();
            initNonInterface();
        }

        void initUserInterface()
        {
            groupControl_KeypressingSil.Enabled=false;
            
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
        }

        void initNonInterface()
        {
            _connect = new ConnectUnit();
        }

        private void simpleButton_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                _connect.startConnect(textEdit_IP.Text, Int32.Parse(textEdit_Port.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection falt. Please try again");
                return;
            }

            MessageBox.Show("Connection success!");
            groupControl_KeypressingSil.Enabled = true;
            _connect.addEventHandler(this);

            
            _connect.startRecieve();
            
        }
        public void recieveCharHandler(char c)
        {
            richTextBox_KeyStroke.AppendText(c.ToString());
            InputSimulator.SimulateTextEntry(c.ToString());
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _connect.close();
        }
        
    }
}
