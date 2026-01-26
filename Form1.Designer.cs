namespace DevExpressDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            studentBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            studentBindingSource1 = new BindingSource(components);
            studentBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = studentBindingSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1644, 899);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colName, colAge });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // colID
            // 
            colID.Caption = "学生编号";
            colID.FieldName = "ID";
            colID.MinWidth = 30;
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 112;
            // 
            // colName
            // 
            colName.Caption = "姓名";
            colName.FieldName = "Name";
            colName.MinWidth = 30;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            colName.Width = 112;
            // 
            // colAge
            // 
            colAge.Caption = "年龄";
            colAge.FieldName = "Age";
            colAge.MinWidth = 30;
            colAge.Name = "colAge";
            colAge.Visible = true;
            colAge.VisibleIndex = 2;
            colAge.Width = 112;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Student);
            // 
            // studentBindingSource2
            // 
            studentBindingSource2.DataSource = typeof(Student);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 899);
            Controls.Add(gridControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource studentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private BindingSource studentBindingSource1;
        private BindingSource studentBindingSource2;
    }
}
