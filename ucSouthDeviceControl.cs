using DevExpress.Utils.Layout;
using DevExpressDemo.Respository;

namespace DevExpressDemo
{
    public partial class ucSouthDeviceControl : DevExpress.XtraEditors.XtraUserControl
    {
        DeviceInfoRepo deviceInfoRepo = new DeviceInfoRepo();

        // --- 分页变量 ---
        private int currentPage = 1;
        private int pageSize = 5;
        private int totalCount = 0;
        private int totalPages = 1;

        public ucSouthDeviceControl()
        {
            InitializeComponent();

            // 默认设置每页20条
            comboBoxEdit1.EditValue = "20";

            // 手动绑定上一页点击事件（Designer里如果没点的话）
            simpleButton1.Click += simpleButton1_Click;

            // 初始加载数据
            LoadData();
        }

        /// <summary>
        /// 核心数据加载方法
        /// </summary>
        private void LoadData()
        {
            // 1. 调用带分页参数的 Repo
            // pageIndex 通常从 1 开始，SqlSugar 内部已处理
            var pagedList = deviceInfoRepo.GetDeviceList(currentPage, pageSize, out totalCount);

            // 2. 计算总页数
            totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            if (totalPages == 0) totalPages = 1;

            // 3. 绑定数据源
            gcDevices.DataSource = pagedList;
            gvDevices.RefreshData();

            // 4. 更新界面显示
            labelControl1.Text = $"共 {totalCount} 条记录";
            labelControl2.Text = $"/ {totalPages} 页";
            textEdit1.EditValue = currentPage;

            // 5. 按钮状态控制
            simpleButton1.Enabled = currentPage > 1;
            simpleButton2.Enabled = currentPage < totalPages;
        }

        private void UpdatePagingLabels()
        {
            labelControl1.Text = $"共 {totalCount} 条记录";
            labelControl2.Text = $"/ {totalPages} 页";
            textEdit1.EditValue = currentPage;

            // 按钮可用性
            simpleButton1.Enabled = currentPage > 1;
            simpleButton2.Enabled = currentPage < totalPages;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var res = deviceInfoRepo.GetDeviceList(currentPage, pageSize, out totalCount);
            gcDevices.DataSource = res;
            gvDevices.RefreshData();

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxEdit1.Text, out int newSize))
            {
                pageSize = newSize;
                currentPage = 1; // 切换容量时重置回第一页
                LoadData();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 1. 实例化新增窗体
            using (FrmDeviceEdit frm = new FrmDeviceEdit())
            {
                // 1. 确保设置了起始位置
                frm.StartPosition = FormStartPosition.CenterParent;

                // 2. 以对话框形式弹出 (ShowDialog 会阻塞主窗体直到它关闭)
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
