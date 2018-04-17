using System;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public int p = 3;
        bool f = false;
        Form1 form;

        public Form2(Form1 form1)
        {
            form = form1;
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!form.Visible)
            {
                form.Show();
                Hide();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
            form.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {                   
            if (p == 2)
            {
                e.Handled = true;
                MessageBox.Show("Не хватает прав");
            }
            else
                MessageBox.Show("Операция прошла успешно");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (p == 2)
            {
                e.Handled = true;
                MessageBox.Show("Не хватает прав");
            }
            else
                MessageBox.Show("Операция прошла успешно");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((p == 1) || (p == 2))
            {
                e.Handled = true;
                MessageBox.Show("Не хватает прав");
            }
            else
                MessageBox.Show("Операция прошла успешно");
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (p == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                button2.Visible = true;
                label1.Text = "Права:\nВы имеете полные права";
            }
            if (p == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button2.Visible = false;
                label1.Text = "Права:\nВы можете видить все поля,\nно редактировать только первые два";
            }
            if (p == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button2.Visible = false;
                label1.Text = "Права:\nВы можете видить только первые два поля";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 5; i++)               
                if (textBox4.Text == form.mass[i].s) { 
                    f = true;
                form.mass[i].i = Int32.Parse(textBox5.Text); }
                if (!f)
                    MessageBox.Show("Неверный индентификатор");
        }
    }
}
