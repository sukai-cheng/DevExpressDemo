namespace DevExpressDemo
{
    partial class ucSystem
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
            button1 = new Button();
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(158, 294);
            button1.Name = "button1";
            button1.Size = new Size(385, 84);
            button1.TabIndex = 0;
            button1.Text = "This is ucSystem button";
            button1.UseVisualStyleBackColor = true;
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonItem1, barButtonGroup1, barButtonItem2, barButtonItem3, barButtonItem4 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 6;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] { ribbonPageCategory1 });
            ribbonControl1.Size = new Size(683, 225);
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "导出";
            barButtonItem1.Id = 1;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageCategory1
            // 
            ribbonPageCategory1.Name = "ribbonPageCategory1";
            ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage2 });
            ribbonPageCategory1.Text = "系统设置";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "历史记录";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonGroup1);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 2;
            barButtonGroup1.ItemLinks.Add(barButtonItem2);
            barButtonGroup1.ItemLinks.Add(barButtonItem3);
            barButtonGroup1.ItemLinks.Add(barButtonItem4);
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "导出";
            barButtonItem2.Id = 3;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "查询";
            barButtonItem3.Id = 4;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "删除";
            barButtonItem4.Id = 5;
            barButtonItem4.Name = "barButtonItem4";
            // 
            // ucSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ribbonControl1);
            Controls.Add(button1);
            Name = "ucSystem";
            Size = new Size(683, 484);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}
