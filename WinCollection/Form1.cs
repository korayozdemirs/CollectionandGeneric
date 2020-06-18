using System;
using System.Collections;
using System.Windows.Forms;

namespace WinCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList ary = new ArrayList();
            IList ary2 = new ArrayList();
            ICollection ary3 = new ArrayList();
            IEnumerable ary4 = new ArrayList();

            ary.Add(1);
            ary.Add("0 Ahmet");
            ary.Add("1 Ahmet");
            ary.Add("2 Ahmet");
            ary.Add(10.3);

            //Cevriye isimli elemanı araya ekle
            ary.Insert(1, "Cevriye");
            //Cevriye isimli elemanı kaldır
            ary.Remove("Cevriye");
            //Dizi sıralama
            ary.Sort();
            //dizide varmı kontrol
            ary.Contains(1);
            //diziyi temizler
            ary.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(3, "Three");
            sortedList.Add(4, "Four");
            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(2, "Two");

            //indexdeki key
            object value = sortedList.GetKey(3);
            //3 Numaralı anahtarı kaldırır
            sortedList.Remove(3);
            //Indexdeki elemanı kaldırma
            sortedList.RemoveAt(3);
            //Diziyi temizleme
            sortedList.Clear();

            SortedList sortedList1 = new SortedList()
            {
                 {3, "Three"},
                 {4, "Four"},
                 {1, "One"},
                 {5, "Five"},
                 {2, "Two"}
            };

            foreach (DictionaryEntry kv in sortedList1)
            {
                string format = string.Format("Key : {0} Value : {1}", kv.Key, kv.Value);
                listBox1.Items.Add(format);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            //Kaç eleman var
            int sayi = ht.Count;
            //3 Numaralı Key kaldırma
            ht.Remove(3);
            //Diziyi sıfırlama
            //ht.Clear();
            //İçeriyormu 3 numaralı key kontrol
            ht.Contains(3);
            //İçeriyormu Three numaralı value kontrol
            ht.ContainsValue("Three");

            foreach (DictionaryEntry kv in ht)
            {
                string format = string.Format("Key : {0} Value : {1}", kv.Key, kv.Value);
                listBox1.Items.Add(format);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Lifo mantığı ile çalışı
            Stack myStack = new Stack();
            //Eleman Ekleme
            myStack.Push(1);
            myStack.Push("Ahmet");
            myStack.Push("Dursun");

            //eleman çıkarma
            myStack.Pop();

            //Son gireni öğrenme
            object sonGiren = myStack.Peek();

            //Eleman Kontrol
            myStack.Contains("Ahmet");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Fifo mantıgı vardır
            Queue queue = new Queue();

            //Eleman ekleme
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            //Eleman Çıkarma
            queue.Dequeue();

            //Son gireni öğrenme
            object sonGiren = queue.Peek();

            //Diziyi sıfırlama
            queue.Clear();

        }
    }
}
