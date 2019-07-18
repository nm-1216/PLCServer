using HslCommunication;
using HslCommunication.Core;
using HslCommunication.Profinet.AllenBradley;
using HslCommunication.Profinet.Melsec;
using HslCommunication.Profinet.Siemens;
using PLCServer;
using PLCServer.PLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IPLC MyPLC = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //ServerFactory.CreatePLCServer();

            //MyPLC = PLCServers.GetServer("A");

            //if (null != MyPLC)
                //MyPLC.StartScan();

            txtProviderNmae.SelectedIndex = 3;
            btnUlink.Enabled = false;
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            //var sss = PLCServers.KeyValues;

            //return;


            MyPLC = ServerFactory.CreatePLCServer(new PLCServer.Config.PLCServerConfig()
            {
                Name = txtName.Text.Trim(),
                IpAddress = txtIpAddress.Text.Trim(),
                Port = int.Parse(txtPort.Text.Trim()),
                ProviderName = txtProviderNmae.Text,
                Siemens = (SiemensPLCS)int.Parse(txtSiemens.Text.Trim()),
            });

            

            btnLink.Enabled = false;
            btnUlink.Enabled = true;
            btnLink.Text = "已链接";
            
        }

        private void BtnUlink_Click(object sender, EventArgs e)
        {
            btnLink.Enabled = true;
            btnLink.Text = "联机";
            btnUlink.Enabled = false;
        }

        private void SingleReader_Click(object sender, EventArgs e)
        {


            //AllenBradleyNet allenBradleyNet = new AllenBradleyNet("192.168.1.11");

            //OperateResult connect = allenBradleyNet.ConnectServer();
            //if (connect.IsSuccess)
            //{
            //    MessageBox.Show("连接成功！");
            //}
            //else
            //{
            //    MessageBox.Show("连接失败！" + connect.ToMessageShowString());
            //}

            //var tmp= allenBradleyNet.ReadBool("M1");

  

            //if (tmp.IsSuccess)
            //{
            //    txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{tmp.Content}\r\n");
            //}
            //else
            //{
            //    txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{tmp.Message}\r\n");
            //}

            //return;


            if (btnLink.Text != "已链接")
            {
                MessageBox.Show("PLC尚未联机，请联机！");
                return;
            }

            if (string.IsNullOrEmpty(txtRSAddress.Text.Trim()))
            {
                MessageBox.Show("读取地址不能是空");
                return;
            }

           

            var btn = sender as Button;

            switch (btn.Text.ToUpper())
            {
                case "R-INT16": SingleReader(MyPLC.ReadInt16(txtRSAddress.Text)); break;
                case "R-INT32": SingleReader(MyPLC.ReadInt32(txtRSAddress.Text)); break;
                case "R-INT64": SingleReader(MyPLC.ReadInt64(txtRSAddress.Text)); break;
                case "R-BOOL": SingleReader(MyPLC.ReadBool(txtRSAddress.Text)); break;
                case "R-FLOAT": SingleReader(MyPLC.ReadFloat(txtRSAddress.Text)); break;
                case "R-DOUBLE": SingleReader(MyPLC.ReadDouble(txtRSAddress.Text)); break;
                case "R-STRING": SingleReader(MyPLC.ReadString(txtRSAddress.Text,ushort.Parse(txtWordLength.Text))); break;
            }
        }


        private void SingleReader(OperateResult<Int16> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<Int32> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<Int64> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<bool> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<float> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<double> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void SingleReader(OperateResult<string> obj)
        {
            if (obj.IsSuccess)
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRSAddress.Text}]{obj.Content}\r\n");
            }
            else
            {
                txtRSMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{obj.Message}\r\n");
            }
        }

        private void txtRSMeg_Write(string str)
        {
            txtRSMeg.Focus();
            txtRSMeg.Select(txtRSMeg.TextLength, 0);
            txtRSMeg.ScrollToCaret();
            txtRSMeg.AppendText(str);
        }

        private void txtRUMeg_Write(string str)
        {
            txtRUMeg.Focus();
            txtRUMeg.Select(txtRUMeg.TextLength, 0);
            txtRUMeg.ScrollToCaret();
            txtRUMeg.AppendText(str);
        }



        private void Button7_Click(object sender, EventArgs e)
        {

            if (btnLink.Text != "已链接")
            {
                MessageBox.Show("PLC尚未联机，请联机！");
                return;
            }

            if (string.IsNullOrEmpty(txtRUAddress.Text.Trim()))
            {
                MessageBox.Show("读取地址不能是空");
                return;
            }

            if (string.IsNullOrEmpty(txtUWordLength.Text.Trim()))
            {
                MessageBox.Show("读取长度不能是空");
                return;
            }

            var rst = MyPLC.Read(txtRUAddress.Text.Trim(), ushort.Parse(txtUWordLength.Text));

            if (rst.IsSuccess)
            {
                var v1 = rst.Content;
                //var v1 = MyPLC.ByteTransform.TransBool(rst.Content, 0, 1);

                txtRUMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][{txtRUAddress.Text}]{string.Join(",", v1)} \r\n");
            }
            else
            {
                txtRUMeg_Write($"[{DateTime.Now.ToString("HH:mm:ss")}][Err]{rst.Message}\r\n");
            }
        }


       
        private void timer1_Tick(object sender, EventArgs e, IReadWriteNet plc)
        {
            txtAInt.Text = plc.ReadInt16("DB1.124").Content.ToString();
        }

        private void ddd(IReadWriteNet abc)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler((s, e) => timer1_Tick(s, e, abc));
            timer.Start();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            //MyPLC.DataReader += new PLCEvent_DataReaderEventHandler(ddd);

            //MyPLC.StartScan();
        }
    }
}