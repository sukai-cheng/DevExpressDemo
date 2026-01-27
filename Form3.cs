using DevExpress.CodeParser;
using DevExpress.Data.Helpers;
using DevExpress.Drawing.Internal;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
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
            ApplyModernStyle();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element.Style != ElementStyle.Item) return;

            string pageName = e.Element.Tag?.ToString();

            if (!string.IsNullOrEmpty(pageName))
            {
                var targetPage = navigationFrame1.Pages.Cast<NavigationPage>().FirstOrDefault(p => p.Name == pageName);
                if (targetPage != null)
                {
                    navigationFrame1.SelectedPage = targetPage;
                }
                else
                {
                    XtraMessageBox.Show($"找不到页面: {pageName}. 请检查设计器中的Name属性");
                }
            }

        }

        private void navigationFrame1_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            foreach (RibbonPageCategory category in ribbonControl1.PageCategories)
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
            foreach (RibbonPageCategory category in ribbonControl1.PageCategories)
            {
                category.Visible = (category.Name == categoryName);
            }

            // 选择第一个可见的类别中的第一页
            var activeCat = ribbonControl1.Categories.Cast<DevExpress.XtraBars.Ribbon.RibbonPageCategory>().FirstOrDefault(c => c.Visible);
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


        private void InitDynamicMenu(List<MenuNode> authData)
        {
            accordionControl1.Elements.Clear();
            accordionControl1.AllowItemSelection = true;

            var rootNodes = authData.Where(x => string.IsNullOrEmpty(x.ParentId));

            foreach (var rootNode in rootNodes)
            {
                AccordionControlElement group = new AccordionControlElement
                {
                    Text = rootNode.DisplayName,
                    Style = ElementStyle.Group,
                    Expanded = true
                    
                };

                if (!string.IsNullOrEmpty(rootNode.IconName))
                {
                    group.ImageOptions.ImageUri.Uri = rootNode.IconName;
                }

                var childNodes = authData.Where(x => x.ParentId == rootNode.Id);
                foreach (var childNode in childNodes)
                {
                    AccordionControlElement item = new AccordionControlElement
                    {
                        Text = childNode.DisplayName,
                        Style = ElementStyle.Item,
                        Tag = childNode.TargetPage,
                        
                    };
                    if (!string.IsNullOrEmpty(childNode.IconName))
                    {
                        item.ImageOptions.ImageUri.Uri = childNode.IconName;
                    }
                    group.Elements.Add(item);
                }
                accordionControl1.Elements.Add(group);
            }
        }

        private List<MenuNode> GetMockMenuData()
        {
            return new List<MenuNode>
            {
                new MenuNode {Id = "1", ParentId = null, DisplayName = "监控中心",IconName = "BO_StateMachine" },
                new MenuNode {Id = "11", ParentId = "1", DisplayName = "实时曲线",TargetPage = "pageChart", IconName = "ChartType_Line" },
                new MenuNode {Id = "12", ParentId = "1", DisplayName = "历史数据",TargetPage = "pageHistory",IconName = "Next" },
                new MenuNode {Id = "2", ParentId = null, DisplayName = "系统管理",IconName = "BO_StateMachine" },
                new MenuNode {Id = "21", ParentId = "2", DisplayName = "参数设置",TargetPage = "pageSetting",IconName = "Properties" },
                new MenuNode {Id = "22", ParentId = "2", DisplayName = "用户权限",TargetPage = "pageUser",IconName = "Next" }
            };
        }

        //private DevExpress.Utils.Svg.SvgImage GetImageByName(string imageName)
        //{
        //    if (string.IsNullOrEmpty(imageName)) return null;
        //    try
        //    {
        //        var image = DevExpress.Utils.Design.ImageRes
        //    }
        //}


        private void Form3_Load(object sender, EventArgs e)
        {
            navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            // navigationFrame1.TransitionAnimationProperties.FrameCount = 500;
            // mock数据
            var authMenuData = GetMockMenuData();

            // 动态设置菜单
            InitDynamicMenu(authMenuData);

            // 初始化都设置为不可见
            foreach(RibbonPageCategory cat in ribbonControl1.Categories)
            {
                cat.Visible = false;
            }

            // Ribbon动态切换
            if (navigationFrame1.Pages.Count > 0)
            {
                var firstPage = navigationFrame1.Pages[0];

                navigationFrame1.SelectedPage = (NavigationPage)firstPage;

                if (firstPage != null)
                {
                    var userControl = firstPage.Controls.Cast<Control>().FirstOrDefault() as INavigablePage;
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

        }

        private void ApplyModernStyle()
        {
            ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.WXI);
            accordionControl1.DistanceBetweenRootGroups = 12;

            accordionControl1.AllowItemSelection = true;

        }
    }
}
