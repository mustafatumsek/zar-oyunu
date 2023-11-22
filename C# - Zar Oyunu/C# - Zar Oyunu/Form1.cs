namespace C____Zar_Oyunu
{//c# öðrenirken yaklaþýk 30-45 dakikada çerezlik yaptýðým bir çalýþma.
    public partial class Form1 : Form
    {
        public int win = 0;
        public int draw = 0;
        public int lose = 0;

        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (win == 10)
            {
                win = 0;
                draw = 0;
                lose = 0;
                label8.Text = Convert.ToString(win);
                label10.Text = Convert.ToString(lose);
                label9.Text = Convert.ToString(draw);
                button1.Text = "Zar At";

            }
            if (lose == 10)
            {
                win = 0;
                draw = 0;
                lose = 0;
                label8.Text = Convert.ToString(win);
                label10.Text = Convert.ToString(lose);
                label9.Text = Convert.ToString(draw);
                button1.Text = "Zar At";
            }
            if (draw == 10)
            {
                win = 0;
                draw = 0;
                lose = 0;
                label8.Text = Convert.ToString(win);
                label10.Text = Convert.ToString(lose);
                label9.Text = Convert.ToString(draw);
                button1.Text = "Zar At";
            }
            label11.Text = "";
            Random _r = new Random();
            label12.Text = Convert.ToString(_r.Next(1, 7));
            label13.Text = Convert.ToString(_r.Next(1, 7));

            if (Convert.ToInt16(label12.Text) > Convert.ToInt16(label13.Text))
            {
                {
                    { label4.Text = "Tebrikler! Siz kazandýnýz."; }
                    win += 1;
                    label8.Text = Convert.ToString(win);
                    if (win == 10)
                    {
                        label11.Text = "TEBRÝKLER!\noyunu kazandýnýz!";
                        button1.Text = "Yeni Oyun";
                    }
                }
            }
            if (Convert.ToInt16(label12.Text) < Convert.ToInt16(label13.Text))
            {
                { label4.Text = "Kötü Þans! Rakibiniz kazandý."; }
                lose += 1;
                label10.Text = Convert.ToString(lose);
                if (lose == 10)
                {
                    label11.Text = "GEÇMÝÞ OLSUN!\nrakibiniz oyunu kazandý.";
                    button1.Text = "Yeni Oyun";
                }
            }
            if (Convert.ToInt16(label12.Text) == Convert.ToInt16(label13.Text))
            {
                { label4.Text = "Berabere! Lütfen tekrar deneyin."; }
                draw += 1;
                label9.Text = Convert.ToString(draw);
                if (draw == 10)
                {
                    label11.Text = "OOPS!\noyunu berabere bitti.";
                    button1.Text = "Yeni Oyun";
                }
            }
        }
    }
}