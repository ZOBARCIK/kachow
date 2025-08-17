using System;
using System.Drawing;
using System.Media;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;



namespace kachow
{
    public partial class Form1 : Form
    {
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {







            // Define the mailto string
            string email = "ardazobar@outlook.com";
            string subject = "kachow";
            string body = "olr yarýn görüþürüz  \n \n KA-CHOW";

            // Construct the mailto URL
            string mailto = $"mailto:{email}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}";

            // Open the default mail client
            Process.Start(new ProcessStartInfo(mailto) { UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int newX = random.Next(0, ClientSize.Width - button2.Width);
            int newY = random.Next(0, ClientSize.Height - button2.Height);


            button2.Location = new Point(newX, newY);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
