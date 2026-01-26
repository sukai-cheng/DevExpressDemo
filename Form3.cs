using DevExpress.CodeParser;
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
    public partial class Form3 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            if (e.Element.Style == DevExpress.XtraBars.Navigation.ElementStyle.Item)
            {
                string targetPageName = e.Element.Tag?.ToString();

                if (!string.IsNullOrEmpty(targetPageName))
                {
                    var targetPage = navigationFrame1.Pages.FirstOrDefault(p => p.Name == targetPageName);
                    if (targetPage != null)
                    {
                        navigationFrame1.SelectedPage = (DevExpress.XtraBars.Navigation.NavigationPage)targetPage; ;
                    }
                }

                // 动态修改顶部菜单
                ribbonPageCategory1.Visible = e.Element.Text == "groupSystemTools";
            }
        }
    }
}
