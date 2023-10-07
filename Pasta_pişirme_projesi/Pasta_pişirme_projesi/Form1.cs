namespace Pasta_pişirme_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // progressBar1'in degerini 10'ar 10'ar artırdık 
            progressBar1.Value += 10;

            // progressBar1 arkaplan rengini degistirdik 
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value % 20 == 0)
            {

                label1.BackColor = Color.Red;
            }

            // 
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            // progressBar2 arkaplan rengini degistirdik 
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.White;
            }
            if (progressBar2.Value % 10 == 0)
            {

                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();

            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // progressBar3'un degerini artırdık
            progressBar3.Value += 20;

            //Simdi renk degistirlim 
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;

            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;

            }

            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();

            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
            // arkaplan color
            //Simdi renk degistirlim 
            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.White;

            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.Red;

            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pasta Hazır Afiyetler Olsun.");
            }
        }

    }
}
