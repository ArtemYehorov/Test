namespace Test
{
    public partial class Form1 : Form
    {
        Form2 child;

        private string data = "";
        public string Data
        {
            get => data;
            set
            {
                data = value;
                textBox1.Text = data;
            }
        }

        public Form1()
        {
            InitializeComponent();
           

            child = new Form2(this);
            child.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            child.Data = textBox1.Text;
        }
    }
}