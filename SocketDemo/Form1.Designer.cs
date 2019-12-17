namespace SocketDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            //this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_SendMessage = new System.Windows.Forms.TextBox();
            this.txt_Listen = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_bigfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            //this.skinEngine1.@__DrawButtonFocusRectangle = true;
            //this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            //this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            //this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            //this.skinEngine1.SerialNumber = "";
            //this.skinEngine1.SkinFile = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(99, 22);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(236, 25);
            this.txt_IP.TabIndex = 2;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(409, 22);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(132, 25);
            this.txt_Port.TabIndex = 3;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(551, 20);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 29);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_SendMessage
            // 
            this.txt_SendMessage.Location = new System.Drawing.Point(35, 328);
            this.txt_SendMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SendMessage.Multiline = true;
            this.txt_SendMessage.Name = "txt_SendMessage";
            this.txt_SendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SendMessage.Size = new System.Drawing.Size(507, 188);
            this.txt_SendMessage.TabIndex = 5;
            // 
            // txt_Listen
            // 
            this.txt_Listen.Location = new System.Drawing.Point(35, 114);
            this.txt_Listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Listen.Multiline = true;
            this.txt_Listen.Name = "txt_Listen";
            this.txt_Listen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Listen.Size = new System.Drawing.Size(507, 183);
            this.txt_Listen.TabIndex = 6;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(577, 402);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 29);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "发送消息";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "关闭连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(577, 488);
            this.btn_SendFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(100, 29);
            this.btn_SendFile.TabIndex = 9;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_bigfile
            // 
            this.btn_bigfile.Location = new System.Drawing.Point(577, 448);
            this.btn_bigfile.Name = "btn_bigfile";
            this.btn_bigfile.Size = new System.Drawing.Size(100, 25);
            this.btn_bigfile.TabIndex = 10;
            this.btn_bigfile.Text = "发送大文件";
            this.btn_bigfile.UseVisualStyleBackColor = true;
            this.btn_bigfile.Click += new System.EventHandler(this.btn_bigfile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 562);
            this.Controls.Add(this.btn_bigfile);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Listen);
            this.Controls.Add(this.txt_SendMessage);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_SendMessage;
        private System.Windows.Forms.TextBox txt_Listen;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_bigfile;
    }
}

