namespace _2.SENEİLKDERS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            try
            {

                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                ortalama = vize * 0.4 + final * 0.6;
                label3.Text = ortalama.ToString();
                label4.Text= ortalama.ToString();
                if (ortalama < 50 || final < 50)
                {
                    label4.Text = "Kaldınız";
                    
                    label4.ForeColor = Color.Red;
                }
                else
                    label4.Text = "Geçtiniz";
                label4.ForeColor = Color.Green;

                label5.Text = Convert.ToString(ortalama);
                if (ortalama > 0 && ortalama <= 49)
                    label5.Text = "FF";
                label5.ForeColor = Color.Red;
                if (ortalama >= 50 && ortalama <= 59)
                    label5.Text = "CC";
                label5.ForeColor=Color.Green;
                if (ortalama >= 60 && ortalama <= 69)
                    label5.Text = "CB";
                label5.ForeColor = Color.Green;
                if (ortalama >=70 && ortalama <= 79)
                    label5.Text = "BB";
                label5.ForeColor = Color.Green;
                if (ortalama>=80&& ortalama<=89)
                    label5.Text = "BA";
                label5.ForeColor = Color.Green;
                if (ortalama >= 90 && ortalama <= 100)
                    label5.Text = "AA";
                label5.ForeColor = Color.Green;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }


            catch (Exception ex)
            {
              //catch içerisinde kodum çalışmadığı için komut satırımı içinden çıkardım çalıştırma yöntemini arıyorum

            }
            if (numericUpDown1.Value <100 && numericUpDown2.Value < 100)
            {
                
            }
            else
            {
                MessageBox.Show("Vize ve Final notları 100 den büyük olamaz");
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;

            }




        }
    }
}