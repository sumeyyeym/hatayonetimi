using System;
using System.Windows.Forms;

namespace hatahata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHataYonetimsiz_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler, telefon numarasını sisteme girebildin!");
        }

        private void BtnHataYonetimli_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefon numarasını sisteme girebildin!");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

            }
        }

        private void BtnHataYonetimliMesaj_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefon numarasını sisteme girebildin!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

                //loglama için;

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHataYonetimliMesaj1_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefon numarasını sisteme girebildin!");
            }
            catch (DivideByZeroException ex) //sıfıra bölünme hatası
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

                //loglama için;

                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex) //dizin sınırları dışındaydı
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

                //loglama için;

                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) //format hatası
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

                //loglama için;

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) //istisnasız her daim en altta olacak
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

                //loglama için;

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHataYonetimliFinally_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler, telefon numarasını sisteme girebildin!");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sayısal verilerden oluşan formatla giriniz.");

            }
            finally
            {
                MessageBox.Show("Bu alan içerisinde yer alan kod blokları her zaman çalışacaktır.");
            }
        }
    }
}
