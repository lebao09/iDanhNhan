using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace DanhnhanHost
{
    public partial class Form1 : Form
    {
        ServiceHost myservice = null;
        ServiceMetadataBehavior behavior;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            String result = null;
            Uri baseAddress;
            try
            {
                if (cb_EndPoints1.Checked == true)
                {
                    baseAddress = new Uri("net.tcp://" + baseaddress.Text + "/" + tb_NetTCPBinding.Text);
                    myservice = new ServiceHost(typeof(Danhnhan), baseAddress);
                    myservice.AddServiceEndpoint(typeof(IDanhnhan), new NetTcpBinding(), baseAddress);
                    if (mex.Checked == false)
                    {
                        behavior = new ServiceMetadataBehavior();
                        behavior.HttpGetEnabled = true;
                        myservice.Description.Behaviors.Add(behavior);
                        behavior.HttpGetUrl = baseAddress;
                        myservice.AddServiceEndpoint(typeof(IMetadataExchange), new NetTcpBinding(), "hehe");

                    }
                    result += "NetTcpBinding";

                }

                if (cb_Endpoint2.Checked == true)
                {
                    baseAddress = new Uri("http://" + baseaddress.Text + "/" + tb_WSHttpBinding.Text);
                    myservice = new ServiceHost(typeof(Danhnhan), baseAddress);
                    myservice.AddServiceEndpoint(typeof(IDanhnhan), new WSHttpBinding(), baseAddress);

                    if (mex.Checked == false)
                    {
                        behavior = new ServiceMetadataBehavior();
                        behavior.HttpGetEnabled = true;
                        myservice.Description.Behaviors.Add(behavior);
                        behavior.HttpGetUrl = baseAddress;
                        myservice.AddServiceEndpoint(typeof(IMetadataExchange), new WSHttpBinding(), "hihi");

                    }
                    result += "+WSHttpBinding";
                }

                if (cb_Endpoint3.Checked == true)
                {
                    baseAddress = new Uri("http://" + baseaddress.Text + "/" + tb_BasicHttpBinding.Text);

                    myservice = new ServiceHost(typeof(Danhnhan), baseAddress);
                    myservice.AddServiceEndpoint(typeof(IDanhnhan), new BasicHttpBinding(), baseAddress);

                    if (mex.Checked == false)
                    {
                        behavior = new ServiceMetadataBehavior();
                        behavior.HttpGetEnabled = true;
                        myservice.Description.Behaviors.Add(behavior);
                        behavior.HttpGetUrl = baseAddress;
                        myservice.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "haha");

                    }
                    result += "+BasicHttpBinding";
                }
                myservice.Open();
                tb.Text = "Đã kết nối kiểu " + result;
                bt_stop.Enabled = true;
                bt_start.Enabled = false;
            }
            catch (Exception ex)
            {
                label9.Text = ex.Message;
            }
            finally
            {
                
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            try
            {
                myservice.Close();
                bt_start.Enabled = true;
                bt_stop.Enabled = false;
                tb.Text = "Đã ngắt kết nối";
            }
            catch (Exception ex)
            {
                tb.Text = ex.Message;
            }
        }
    }
}
