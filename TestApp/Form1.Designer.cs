namespace TestApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUlink = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.txtProviderNmae = new System.Windows.Forms.ComboBox();
            this.txtSiemens = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRSMeg = new System.Windows.Forms.RichTextBox();
            this.txtRSAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWordLength = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUWordLength = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.txtRUMeg = new System.Windows.Forms.RichTextBox();
            this.txtRUAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAInt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUlink);
            this.groupBox1.Controls.Add(this.btnLink);
            this.groupBox1.Controls.Add(this.txtProviderNmae);
            this.groupBox1.Controls.Add(this.txtSiemens);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIpAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC 配置信息";
            // 
            // btnUlink
            // 
            this.btnUlink.Location = new System.Drawing.Point(820, 19);
            this.btnUlink.Name = "btnUlink";
            this.btnUlink.Size = new System.Drawing.Size(75, 23);
            this.btnUlink.TabIndex = 12;
            this.btnUlink.Text = "断开";
            this.btnUlink.UseVisualStyleBackColor = true;
            this.btnUlink.Click += new System.EventHandler(this.BtnUlink_Click);
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(721, 19);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(75, 23);
            this.btnLink.TabIndex = 11;
            this.btnLink.Text = "联机";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.BtnLink_Click);
            // 
            // txtProviderNmae
            // 
            this.txtProviderNmae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProviderNmae.FormattingEnabled = true;
            this.txtProviderNmae.Items.AddRange(new object[] {
            "MelsecMcNet",
            "MelsecMcAsciiNet",
            "MelsecA1ENet",
            "SiemensS7Net",
            "SiemensFetchWriteNet",
            "OmronFinsNet",
            "AllenBradleyNet"});
            this.txtProviderNmae.Location = new System.Drawing.Point(430, 21);
            this.txtProviderNmae.Name = "txtProviderNmae";
            this.txtProviderNmae.Size = new System.Drawing.Size(121, 20);
            this.txtProviderNmae.TabIndex = 10;
            // 
            // txtSiemens
            // 
            this.txtSiemens.Location = new System.Drawing.Point(664, 21);
            this.txtSiemens.Name = "txtSiemens";
            this.txtSiemens.Size = new System.Drawing.Size(34, 21);
            this.txtSiemens.TabIndex = 9;
            this.txtSiemens.Text = "1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(326, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 21);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "44818";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(167, 21);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(100, 21);
            this.txtIpAddress.TabIndex = 6;
            this.txtIpAddress.Text = "192.168.0.30";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(41, 21);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "西门子PLC型号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "驱动：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(1055, 220);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(527, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 204);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "单值写";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRSMeg);
            this.groupBox2.Controls.Add(this.txtRSAddress);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtWordLength);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 204);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单值读";
            // 
            // txtRSMeg
            // 
            this.txtRSMeg.Location = new System.Drawing.Point(64, 59);
            this.txtRSMeg.Name = "txtRSMeg";
            this.txtRSMeg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtRSMeg.Size = new System.Drawing.Size(229, 139);
            this.txtRSMeg.TabIndex = 16;
            this.txtRSMeg.Text = "";
            // 
            // txtRSAddress
            // 
            this.txtRSAddress.Location = new System.Drawing.Point(64, 27);
            this.txtRSAddress.Name = "txtRSAddress";
            this.txtRSAddress.Size = new System.Drawing.Size(229, 21);
            this.txtRSAddress.TabIndex = 13;
            this.txtRSAddress.Text = "DB1.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "结果：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "地址：";
            // 
            // txtWordLength
            // 
            this.txtWordLength.Location = new System.Drawing.Point(335, 131);
            this.txtWordLength.Name = "txtWordLength";
            this.txtWordLength.Size = new System.Drawing.Size(75, 21);
            this.txtWordLength.TabIndex = 13;
            this.txtWordLength.Text = "2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "R-String";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "R-Double";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(427, 57);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "R-Float";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "R-Int64";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "R-Int16";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "R-Int32";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "R-Bool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SingleReader_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 285);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(1055, 220);
            this.panel2.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtAInt);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(527, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 204);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "监视区";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtUWordLength);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.txtRUMeg);
            this.groupBox4.Controls.Add(this.txtRUAddress);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 204);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "多值读";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "长度：";
            // 
            // txtUWordLength
            // 
            this.txtUWordLength.Location = new System.Drawing.Point(366, 19);
            this.txtUWordLength.Name = "txtUWordLength";
            this.txtUWordLength.Size = new System.Drawing.Size(44, 21);
            this.txtUWordLength.TabIndex = 17;
            this.txtUWordLength.Text = "10";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "批量读取";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // txtRUMeg
            // 
            this.txtRUMeg.Location = new System.Drawing.Point(64, 52);
            this.txtRUMeg.Name = "txtRUMeg";
            this.txtRUMeg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtRUMeg.Size = new System.Drawing.Size(438, 139);
            this.txtRUMeg.TabIndex = 20;
            this.txtRUMeg.Text = "";
            // 
            // txtRUAddress
            // 
            this.txtRUAddress.Location = new System.Drawing.Point(64, 19);
            this.txtRUAddress.Name = "txtRUAddress";
            this.txtRUAddress.Size = new System.Drawing.Size(229, 21);
            this.txtRUAddress.TabIndex = 17;
            this.txtRUAddress.Text = "DB1.2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "结果：";
            // 
            // txtAInt
            // 
            this.txtAInt.Location = new System.Drawing.Point(91, 24);
            this.txtAInt.Name = "txtAInt";
            this.txtAInt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAInt.Size = new System.Drawing.Size(44, 21);
            this.txtAInt.TabIndex = 21;
            this.txtAInt.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "随机数：";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(141, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "启动";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "PLC 联机测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSiemens;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox txtProviderNmae;
        private System.Windows.Forms.Button btnUlink;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtWordLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRSAddress;
        private System.Windows.Forms.RichTextBox txtRSMeg;
        private System.Windows.Forms.RichTextBox txtRUMeg;
        private System.Windows.Forms.TextBox txtRUAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtUWordLength;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAInt;
        private System.Windows.Forms.Button button9;
    }
}