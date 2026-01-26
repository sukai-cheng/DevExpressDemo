namespace DevExpressDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student() { ID = 1, Name = "John Doe", Age = 20 },
                new Student() { ID = 2, Name = "Jane Smith", Age = 22 },
                new Student() { ID = 3, Name = "Sam Brown", Age = 19 }
                
            };

            gridControl1.DataSource = studentList;
            gridView1.OptionsView.ShowGroupPanel = false;
        }
    }
}
