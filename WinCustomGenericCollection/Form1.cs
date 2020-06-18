using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCustomGenericCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyGeneric<int> list = new MyGeneric<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            bool contains = list.Contains(3);

            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
