namespace DevExpressDemo
{
    partial class ucChart
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, barCheckItem1, barButtonItem4, barButtonGroup1, barButtonGroup2, barButtonItem5, barButtonItem6, barButtonItem7 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 11;
            ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] { ribbonPageCategory1 });
            ribbonControl1.Size = new Size(1434, 225);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "启动监控";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "开始";
            barButtonItem2.Id = 2;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "barButtonItem3";
            barButtonItem3.Id = 3;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageCategory1
            // 
            ribbonPageCategory1.Appearance.ForeColor = Color.White;
            ribbonPageCategory1.Appearance.Options.UseForeColor = true;
            ribbonPageCategory1.Name = "ribbonPageCategory1";
            ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage2, ribbonPage1 });
            ribbonPageCategory1.Text = "图表";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup3 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "趋势分析";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonGroup2);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "功能集合-2";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // barCheckItem1
            // 
            barCheckItem1.Caption = "barCheckItem1";
            barCheckItem1.Id = 4;
            barCheckItem1.Name = "barCheckItem1";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "关闭";
            barButtonItem4.Id = 5;
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 6;
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            barButtonGroup2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            barButtonGroup2.Caption = "功能组";
            barButtonGroup2.Id = 7;
            barButtonGroup2.ItemLinks.Add(barButtonItem5);
            barButtonGroup2.ItemLinks.Add(barButtonItem6);
            barButtonGroup2.ItemLinks.Add(barButtonItem7);
            barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "启动";
            barButtonItem5.Id = 8;
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "停止";
            barButtonItem6.Id = 9;
            barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "重启";
            barButtonItem7.Id = 10;
            barButtonItem7.Name = "barButtonItem7";
            // 
            // ucChart
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ribbonControl1);
            Name = "ucChart";
            Size = new Size(1434, 920);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        public DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}
