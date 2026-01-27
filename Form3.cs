using DevExpress.CodeParser;
using DevExpress.XtraBars.Navigation;
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
                // catSystemTools.Visible = e.Element.Text == "groupSystemTools";
            }
        }

        private void navigationFrame1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonPageCategory category in ribbonControl1.PageCategories)
            {
                category.Visible = false;
            }

            var currentPage = e.Page as NavigationPage;

            if (currentPage != null)
            {
                var userControl = currentPage.Controls.Cast<Control>().FirstOrDefault() as INavigablePage;
                if (userControl != null)
                {
                    UpdateRibbon(userControl.AssociatedRibbonCategoryName);
                }
                else
                {
                    UpdateRibbon(string.Empty);
                }
            }
        }

        private void UpdateRibbon(string categoryName)
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonPageCategory category in ribbonControl1.PageCategories)
            {
                category.Visible = (category.Name == categoryName);
            }

            // 选择第一个可见的类别中的第一页
            var activeCat = ribbonControl1.Categories.Cast<DevExpress.XtraBars.Ribbon.RibbonPageCategory> ().FirstOrDefault(c => c.Visible);
            if (activeCat != null && activeCat.Pages.Count > 0)
            {
                ribbonControl1.SelectedPage = activeCat.Pages[0];

            }
            else
            {
                // 默认回到首页
                ribbonControl1.SelectedPage = ribbonPageHome;
            }
        }
    }
}
