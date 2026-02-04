namespace DevExpressDemo
{
    partial class FrmDeviceEdit
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 31);
            label1.Name = "label1";
            label1.Size = new Size(99, 22);
            label1.TabIndex = 1;
            label1.Text = "设备IP地址";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 89);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 3;
            label2.Text = "设备描述";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 29);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 150);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 5;
            label4.Text = "设备TOPIC";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 29);
            textBox4.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(412, 86);
            label7.Name = "label7";
            label7.Size = new Size(82, 22);
            label7.TabIndex = 11;
            label7.Text = "设备类型";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(517, 83);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 29);
            textBox7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(412, 28);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 9;
            label8.Text = "设备名称";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(517, 25);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 29);
            textBox8.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(352, 240);
            button1.Name = "button1";
            button1.Size = new Size(123, 46);
            button1.TabIndex = 12;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 240);
            button2.Name = "button2";
            button2.Size = new Size(123, 46);
            button2.TabIndex = 13;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmDeviceEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 380);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmDeviceEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
    }
}
