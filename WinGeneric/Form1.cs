using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGeneric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            //Eleman ekleme
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);

            //dizi sıralama
            sayilar.Sort();
            //Eleman kaldımra 3 numarayı
            sayilar.Remove(3);
            //Araya eleman ekleme 0 index e  12 degerını ekleme
            sayilar.Insert(0, 12);
            //içeriyormu kontrol
            sayilar.Contains(3);
        }
        List<string> isimler = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string isim in isimler)
            {
                listBox1.Items.Add(isim);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> numaraIsim = new Dictionary<int, string>();
            //Eleman ekleme
            numaraIsim.Add(1, "Ahmet");
            numaraIsim.Add(2, "Mehmet");
            //numaraIsim.Add(2, "Dursun");

            //Dizi temizleme
            numaraIsim.Clear();

            //3 numaralı Key içeriyor mu
            numaraIsim.ContainsKey(3);

            numaraIsim.ContainsValue("Ahmet");

            foreach (KeyValuePair<int, string> item in numaraIsim)
            {
                string format = string.Format("Key : {0} Value : {1}", item.Key, item.Value);
                listBox1.Items.Add(format);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortedList<string, int> genericSorted = new SortedList<string, int>();
            genericSorted.Add("Ahmet", 1);
        }
    }
}
