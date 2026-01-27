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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(177, 168);
            button1.Name = "button1";
            button1.Size = new Size(424, 92);
            button1.TabIndex = 0;
            button1.Text = "This is ucSystem button";
            button1.UseVisualStyleBackColor = true;
            // 
            // ucSystem
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "ucSystem";
            Size = new Size(751, 528);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
