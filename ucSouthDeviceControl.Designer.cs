namespace DevExpressDemo
{
    partial class ucSouthDeviceControl
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
            ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonGroup1, barButtonItem1 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 3;
            ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] { ribbonPageCategory1 });
            ribbonControl1.Size = new Size(962, 225);
            // 
            // ribbonPageCategory1
            // 
            ribbonPageCategory1.Name = "ribbonPageCategory1";
            ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "设备管理";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonGroup1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 1;
            barButtonGroup1.ItemLinks.Add(barButtonItem1);
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "刷新";
            barButtonItem1.Id = 2;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // ucDevice
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ribbonControl1);
            Name = "ucDevice";
            Size = new Size(962, 755);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
