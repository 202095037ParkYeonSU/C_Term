using System.Diagnostics;

namespace C__Assign_Team9
{
    public partial class Form1 : Form
    {
        CharacterManager characterManager;

        public Form1()
        {
            characterManager = CharacterManager.Instance();
            InitializeComponent();

        }

        public void setData(String data)
        {
            string userID = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (characterManager.character1 == null) // ĳ����1 or ĳ����2�� �����ȵǾ����� üũ
            {
                characterManager.character1 = new Character("A", 4);
            }

            if (characterManager.character2 == null)
            {
                characterManager.character2 = new Character("B", 4);
            }
            ChangeToForm2(); // ȭ�� �̵�
        }

        private void ChangeToForm2() // Form2�� �Ѿ�� �Լ�
        {
            this.Hide();
            Form2 showForm2 = new Form2();
            showForm2.Owner = this;
            showForm2.Show();
        }

        private void NameChangeButton1_Click(object sender, EventArgs e)
        {
            characterManager.character1 = new Character(NameInput1.Text, 4);
            MessageBox.Show($"ĳ������ �̸��� {characterManager.character1.GetName()}���� ����Ǿ����ϴ�!");
            //Debug.Print(characterManager.character1.GetName());
        }

        private void NameChangeButton2_Click(object sender, EventArgs e)
        {
            characterManager.character2 = new Character(NameInput2.Text, 4);
            MessageBox.Show($"ĳ������ �̸��� {characterManager.character2.GetName()}���� ����Ǿ����ϴ�!");
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



        private void NameInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}