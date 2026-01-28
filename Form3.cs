using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using System.Data;


namespace DevExpressDemo
{
    public partial class Form3 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form3()
        {
            InitializeComponent();
            ApplyModernStyle();
            this.IsMdiContainer = true;
            this.documentManager1.MdiParent = this;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
        }

        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            // 过滤掉非页面的点击（比如点击了分组名）
            if (e.Element.Style != DevExpress.XtraBars.Navigation.ElementStyle.Item) return;

            // 获取 Tag 中存储的 UserControl 类名 (如 "DevExpressDemo.ucChart")
            string ucClassName = e.Element.Tag?.ToString();
            if (string.IsNullOrEmpty(ucClassName))
            {
                return;
            }

            // 我们用 Control 的 Name 属性作为唯一标识
            var existingDoc = tabbedView1.Documents.FirstOrDefault(d =>d.Control != null && d.Control.Name == ucClassName);
            if (existingDoc != null)
            {
                tabbedView1.ActivateDocument(existingDoc.Control); // 如果开了，直接切过去
                return;
            }

            try
            {
                string fullName = "DevExpressDemo." + ucClassName;
                Type t = Type.GetType(fullName);
                if (t != null)
                {
                    UserControl uc = (UserControl)Activator.CreateInstance(t);
                    frmChildContainer wrapper = new frmChildContainer(uc, e.Element.Text);
                    tabbedView1.AddDocument(wrapper);
                    wrapper.Name = ucClassName;
                    wrapper.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("页面加载失败: " + ex.Message);
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
                new MenuNode {Id = "11", ParentId = "1", DisplayName = "实时曲线",TargetPage = "ucChart", IconName = "ChartType_Line" },
                new MenuNode {Id = "12", ParentId = "1", DisplayName = "历史数据",TargetPage = "ucSystem",IconName = "Next" },
                new MenuNode {Id = "2", ParentId = null, DisplayName = "系统管理",IconName = "BO_StateMachine" },
                new MenuNode {Id = "21", ParentId = "2", DisplayName = "参数设置",TargetPage = "pageSetting",IconName = "Properties" },
                new MenuNode {Id = "22", ParentId = "2", DisplayName = "用户权限",TargetPage = "pageUser",IconName = "Next" },
                new MenuNode {Id = "3", ParentId = null, DisplayName = "设备管理",IconName = "BO_StateMachine" },
                new MenuNode {Id = "31", ParentId = "3", DisplayName = "南向控制",TargetPage = "ucSouthDeviceControl",IconName = "Properties" },
                new MenuNode {Id = "32", ParentId = "3", DisplayName = "北向控制",TargetPage = "ucNorthDeviceControl",IconName = "Next" },
                new MenuNode {Id = "32", ParentId = "3", DisplayName = "Topic设置",TargetPage = "topicSetting",IconName = "Next" }
            };
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            //navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            // navigationFrame1.TransitionAnimationProperties.FrameCount = 500;
            // mock数据
            var authMenuData = GetMockMenuData();

            // 动态设置菜单
            InitDynamicMenu(authMenuData);

            // 初始化都设置为不可见
            foreach (RibbonPageCategory cat in ribbonControl1.Categories)
            {
                cat.Visible = false;
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
