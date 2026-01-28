using DevExpress.XtraBars.Ribbon;

namespace DevExpressDemo
{
    public partial class frmChildContainer : DevExpress.XtraEditors.XtraForm
    {
        public frmChildContainer()
        {
            InitializeComponent();
        }

        // 增加一个构造函数，接收 UserControl
        public frmChildContainer(Control childControl, string title)
        {
            InitializeComponent();
            this.Text = title;

            childControl.Dock = DockStyle.Fill;
            this.Controls.Add(childControl);

            // 如果子控件里有 Ribbon，手动合并到本容器的隐藏 Ribbon 中
            // 这样当这个 Form 被主窗体加载时，主窗体会自动合并这个容器的 Ribbon
            if (childControl is UserControl uc)
            {
                var childRibbon = uc.Controls.OfType<RibbonControl>().FirstOrDefault();
                if (childRibbon != null)
                {
                    ribbonControl1.MergeRibbon(childRibbon);
                }
            }
        }


    }
}
