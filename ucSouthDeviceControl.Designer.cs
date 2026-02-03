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
            barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            gcDevices = new DevExpress.XtraGrid.GridControl();
            gvDevices = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gcDevices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDevices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).BeginInit();
            stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, barButtonGroup1, barButtonItem1, barButtonItem2, barButtonItem3, barButtonItem4 });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 6;
            ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] { ribbonPageCategory1 });
            ribbonControl1.Size = new Size(1675, 225);
            // 
            // barButtonGroup1
            // 
            barButtonGroup1.Caption = "barButtonGroup1";
            barButtonGroup1.Id = 1;
            barButtonGroup1.ItemLinks.Add(barButtonItem1);
            barButtonGroup1.ItemLinks.Add(barButtonItem2);
            barButtonGroup1.ItemLinks.Add(barButtonItem3);
            barButtonGroup1.ItemLinks.Add(barButtonItem4);
            barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "刷新";
            barButtonItem1.Id = 2;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "修改";
            barButtonItem2.Id = 3;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "删除";
            barButtonItem3.Id = 4;
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "新增";
            barButtonItem4.Id = 5;
            barButtonItem4.Name = "barButtonItem4";
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
            // gcDevices
            // 
            gcDevices.Dock = DockStyle.Top;
            gcDevices.Location = new Point(0, 225);
            gcDevices.MainView = gvDevices;
            gcDevices.MenuManager = ribbonControl1;
            gcDevices.Name = "gcDevices";
            gcDevices.Size = new Size(1675, 695);
            gcDevices.TabIndex = 1;
            gcDevices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDevices });
            // 
            // gvDevices
            // 
            gvDevices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6 });
            gvDevices.GridControl = gcDevices;
            gvDevices.Name = "gvDevices";
            gvDevices.OptionsSelection.MultiSelect = true;
            gvDevices.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "设备ID";
            gridColumn1.FieldName = "DeviceId";
            gridColumn1.MinWidth = 30;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "设备IP地址";
            gridColumn2.FieldName = "DeviceIp";
            gridColumn2.MinWidth = 30;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
            gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "设备名称";
            gridColumn3.FieldName = "DeviceName";
            gridColumn3.MinWidth = 30;
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 3;
            gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "设备信息";
            gridColumn4.FieldName = "DeviceDetail";
            gridColumn4.MinWidth = 30;
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 4;
            gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "设备类型";
            gridColumn5.FieldName = "DeviceType";
            gridColumn5.MinWidth = 30;
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 5;
            gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "主题";
            gridColumn6.FieldName = "Topic";
            gridColumn6.MinWidth = 30;
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 6;
            gridColumn6.Width = 112;
            // 
            // panelControl1
            // 
            panelControl1.AutoSize = true;
            panelControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelControl1.Controls.Add(stackPanel1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 920);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1675, 98);
            panelControl1.TabIndex = 3;
            // 
            // stackPanel1
            // 
            stackPanel1.AutoSize = true;
            stackPanel1.Controls.Add(labelControl1);
            stackPanel1.Controls.Add(simpleButton1);
            stackPanel1.Controls.Add(textEdit1);
            stackPanel1.Controls.Add(labelControl2);
            stackPanel1.Controls.Add(simpleButton2);
            stackPanel1.Controls.Add(comboBoxEdit1);
            stackPanel1.Location = new Point(387, 0);
            stackPanel1.Name = "stackPanel1";
            stackPanel1.Padding = new Padding(10);
            stackPanel1.Size = new Size(871, 91);
            stackPanel1.TabIndex = 0;
            stackPanel1.UseSkinIndents = true;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(13, 34);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(82, 22);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "共0条记录";
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(108, 19);
            simpleButton1.Margin = new Padding(10, 3, 10, 3);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(194, 53);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "上一页";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "0";
            textEdit1.Location = new Point(315, 31);
            textEdit1.MenuManager = ribbonControl1;
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(35, 28);
            textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(356, 34);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 22);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "/ 10 页";
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new Point(426, 18);
            simpleButton2.Margin = new Padding(10, 3, 10, 3);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(187, 55);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "下一页";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.EditValue = "每页条数";
            comboBoxEdit1.Location = new Point(653, 31);
            comboBoxEdit1.Margin = new Padding(30, 3, 3, 3);
            comboBoxEdit1.MenuManager = ribbonControl1;
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Items.AddRange(new object[] { "5", "20", "50", "100" });
            comboBoxEdit1.Size = new Size(126, 28);
            comboBoxEdit1.TabIndex = 5;
            comboBoxEdit1.SelectedIndexChanged += comboBoxEdit1_SelectedIndexChanged_1;
            // 
            // ucSouthDeviceControl
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelControl1);
            Controls.Add(gcDevices);
            Controls.Add(ribbonControl1);
            Name = "ucSouthDeviceControl";
            Size = new Size(1675, 1035);
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcDevices).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDevices).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stackPanel1).EndInit();
            stackPanel1.ResumeLayout(false);
            stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcDevices;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDevices;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}
