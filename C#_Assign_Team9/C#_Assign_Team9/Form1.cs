namespace C__Assign_Team9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void setData(String data)
        {
            string userID = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 showForm2 = new Form2();
            showForm2.Owner = this;
            showForm2.Show();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}