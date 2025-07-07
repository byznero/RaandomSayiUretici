namespace soru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for(int i = 0; i < 100; i++)
            {
                int sayi = rnd.Next(50, 3001);
                listBox1.Items.Add(sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
