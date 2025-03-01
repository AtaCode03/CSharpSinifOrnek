namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            Notlar ntl = new Notlar();
            ogr.ad = textBox1.Text;
            ogr.soyad = textBox2.Text;
            ogr.bolum = textBox3.Text;
            ntl.not1 = Convert.ToInt16(textBox4.Text);
            ntl.not2 = Convert.ToInt16(textBox5.Text);
            ntl.not3 = Convert.ToInt16(textBox6.Text);
            ntl.ortalama = (ntl.not1 + ntl.not2 + ntl.not3) / 3;
            textBox7.Text = ntl.ortalama.ToString();

            listBox1.Items.Add(ogr.ad + " " + ogr.soyad + " " + ogr.bolum + " Ortalama: " + ntl.ortalama);
        }
    }
}
