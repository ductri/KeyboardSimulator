namespace KeyboardSimulator_Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox_Client = new System.Windows.Forms.RichTextBox();
            this.textEdit_IP = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Port = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.timer_GetClient = new System.Windows.Forms.Timer(this.components);
            this.toggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.mouseKeyEventProvider = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.richTextBox_KeyStroke = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_IP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "List of stroke key";
            // 
            // richTextBox_Client
            // 
            this.richTextBox_Client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Client.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox_Client.Location = new System.Drawing.Point(5, 34);
            this.richTextBox_Client.Name = "richTextBox_Client";
            this.richTextBox_Client.Size = new System.Drawing.Size(473, 50);
            this.richTextBox_Client.TabIndex = 3;
            this.richTextBox_Client.Text = "";
            // 
            // textEdit_IP
            // 
            this.textEdit_IP.Location = new System.Drawing.Point(25, 32);
            this.textEdit_IP.Name = "textEdit_IP";
            this.textEdit_IP.Size = new System.Drawing.Size(174, 20);
            this.textEdit_IP.TabIndex = 1;
            // 
            // textEdit_Port
            // 
            this.textEdit_Port.Location = new System.Drawing.Point(304, 32);
            this.textEdit_Port.Name = "textEdit_Port";
            this.textEdit_Port.Size = new System.Drawing.Size(174, 20);
            this.textEdit_Port.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "IP:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_IP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.textEdit_Port);
            this.groupControl1.Location = new System.Drawing.Point(12, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(484, 73);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Information of Server";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(274, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Port:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.richTextBox_Client);
            this.groupControl2.Location = new System.Drawing.Point(12, 160);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(484, 94);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Information of Client";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.richTextBox_KeyStroke);
            this.groupControl3.Location = new System.Drawing.Point(12, 277);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(484, 165);
            this.groupControl3.TabIndex = 15;
            this.groupControl3.Text = "Key strokes";
            // 
            // timer_GetClient
            // 
            this.timer_GetClient.Tick += new System.EventHandler(this.timer_GetClient_Tick);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Location = new System.Drawing.Point(12, 12);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Properties.OffText = "Off";
            this.toggleSwitch.Properties.OnText = "On";
            this.toggleSwitch.Size = new System.Drawing.Size(95, 24);
            this.toggleSwitch.TabIndex = 16;
            this.toggleSwitch.Toggled += new System.EventHandler(this.toggleSwitch_Toggled);
            // 
            // mouseKeyEventProvider
            // 
            this.mouseKeyEventProvider.Enabled = false;
            this.mouseKeyEventProvider.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            this.mouseKeyEventProvider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mouseKeyEventProvider_KeyPress);
            // 
            // richTextBox_KeyStroke
            // 
            this.richTextBox_KeyStroke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_KeyStroke.Location = new System.Drawing.Point(5, 24);
            this.richTextBox_KeyStroke.Name = "richTextBox_KeyStroke";
            this.richTextBox_KeyStroke.Size = new System.Drawing.Size(473, 136);
            this.richTextBox_KeyStroke.TabIndex = 0;
            this.richTextBox_KeyStroke.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 454);
            this.Controls.Add(this.toggleSwitch);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_IP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RichTextBox richTextBox_Client;
        private DevExpress.XtraEditors.TextEdit textEdit_IP;
        private DevExpress.XtraEditors.TextEdit textEdit_Port;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Timer timer_GetClient;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch;
        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEventProvider;
        private System.Windows.Forms.RichTextBox richTextBox_KeyStroke;

    }
}

