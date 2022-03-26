using PrzykladowaAplikacja.Models;

namespace PrzykladowaAplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studenciListBox.ValueMember = "ImieINazwisko";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest jakie� info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //OR ||
            //AND &&
            if (string.IsNullOrWhiteSpace(imieTextBox.Text))
            {
                MessageBox.Show("Imi� nie mo�e by� puste");
                return;
            }

            if (string.IsNullOrWhiteSpace(nazwiskoTextBox.Text))
            {
                MessageBox.Show("Nazwisko nie mo�e by� puste");
                return;
            }

            Student nowyStudent = new Student();
            nowyStudent.Imie = imieTextBox.Text;
            nowyStudent.Nazwisko = nazwiskoTextBox.Text;

            studenciListBox.Items.Add(nowyStudent);

            imieTextBox.Text = "";
            nazwiskoTextBox.Text = "";
        }
    }
}