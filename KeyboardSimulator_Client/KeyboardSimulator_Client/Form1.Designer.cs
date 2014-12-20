namespace KeyboardSimulator_Client
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_Connect = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_Port = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_IP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_KeypressingSil = new DevExpress.XtraEditors.GroupControl();
            this.richTextBox_KeyStroke = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_IP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_KeypressingSil)).BeginInit();
            this.groupControl_KeypressingSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_Connect);
            this.groupControl1.Controls.Add(this.textEdit_Port);
            this.groupControl1.Controls.Add(this.textEdit_IP);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(33, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(566, 70);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Connect to server";
            // 
            // simpleButton_Connect
            // 
            this.simpleButton_Connect.Location = new System.Drawing.Point(467, 29);
            this.simpleButton_Connect.Name = "simpleButton_Connect";
            this.simpleButton_Connect.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_Connect.TabIndex = 4;
            this.simpleButton_Connect.Text = "Connect";
            this.simpleButton_Connect.Click += new System.EventHandler(this.simpleButton_Connect_Click);
            // 
            // textEdit_Port
            // 
            this.textEdit_Port.Location = new System.Drawing.Point(320, 31);
            this.textEdit_Port.Name = "textEdit_Port";
            this.textEdit_Port.Size = new System.Drawing.Size(132, 20);
            this.textEdit_Port.TabIndex = 3;
            // 
            // textEdit_IP
            // 
            this.textEdit_IP.Location = new System.Drawing.Point(26, 31);
            this.textEdit_IP.Name = "textEdit_IP";
            this.textEdit_IP.Size = new System.Drawing.Size(231, 20);
            this.textEdit_IP.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(290, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Port:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IP:";
            // 
            // groupControl_KeypressingSil
            // 
            this.groupControl_KeypressingSil.Controls.Add(this.richTextBox_KeyStroke);
            this.groupControl_KeypressingSil.Location = new System.Drawing.Point(33, 101);
            this.groupControl_KeypressingSil.Name = "groupControl_KeypressingSil";
            this.groupControl_KeypressingSil.Size = new System.Drawing.Size(566, 202);
            this.groupControl_KeypressingSil.TabIndex = 1;
            this.groupControl_KeypressingSil.Text = "Keypressing simulator";
            // 
            // richTextBox_KeyStroke
            // 
            this.richTextBox_KeyStroke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_KeyStroke.Location = new System.Drawing.Point(26, 25);
            this.richTextBox_KeyStroke.Name = "richTextBox_KeyStroke";
            this.richTextBox_KeyStroke.Size = new System.Drawing.Size(535, 172);
            this.richTextBox_KeyStroke.TabIndex = 0;
            this.richTextBox_KeyStroke.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 330);
            this.Controls.Add(this.groupControl_KeypressingSil);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_IP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_KeypressingSil)).EndInit();
            this.groupControl_KeypressingSil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_IP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Connect;
        private DevExpress.XtraEditors.TextEdit textEdit_Port;
        private DevExpress.XtraEditors.GroupControl groupControl_KeypressingSil;
        private System.Windows.Forms.RichTextBox richTextBox_KeyStroke;

    }
}

