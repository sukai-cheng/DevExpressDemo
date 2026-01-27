using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressDemo
{
    public partial class ucChart : DevExpress.XtraEditors.XtraUserControl, INavigablePage
    {
        public ucChart()
        {
            InitializeComponent();
        }

        // 实现接口属性，返回关联的Ribbon类别名称
        public string AssociatedRibbonCategoryName => "catChartTools";
    }
}
