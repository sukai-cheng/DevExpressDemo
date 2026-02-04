using DevExpress.XtraEditors;
using DevExpressDemo.Model;
using DevExpressDemo.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DevExpressDemo
{
    public partial class FrmDeviceEdit : DevExpress.XtraEditors.XtraForm
    {
        public DeviceInfoRepo deviceInfoRepo = new DeviceInfoRepo();
        public DeviceInfo currentDevice { get; set; }

        public FrmDeviceEdit(DeviceInfo data = null)
        {
            InitializeComponent();
            if (data != null)
            {
                currentDevice = data;

            }
            else
            {
                currentDevice = new DeviceInfo();
            }
        }

        /// <summary>
        /// 保存设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var deviceIp = textBox1.Text;
            var deviceDetail = textBox2.Text;
            var deviceTopic = textBox4.Text;
            var deviceType = textBox7.Text;
            var deviceName = textBox8.Text;

            currentDevice.DeviceIp = deviceIp;
            currentDevice.DeviceDetail = deviceDetail;
            currentDevice.DeviceType = deviceType;
            currentDevice.DeviceName = deviceName;
            currentDevice.Topic = deviceTopic;

            var isSuccess = deviceInfoRepo.CreateDevice(currentDevice);

            if (isSuccess)
            {
                XtraMessageBox.Show("保存成功！", "系统提示");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
