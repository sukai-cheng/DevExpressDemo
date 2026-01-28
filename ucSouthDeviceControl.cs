using DevExpress.Utils.Layout;
using DevExpressDemo.Respository;

namespace DevExpressDemo
{
    public partial class ucSouthDeviceControl : DevExpress.XtraEditors.XtraUserControl
    {
        DeviceInfoRepo deviceInfoRepo = new DeviceInfoRepo();

        public ucSouthDeviceControl()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var res = deviceInfoRepo.GetDeviceList();
            gcDevices.DataSource = res;
            gvDevices.RefreshData();

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
