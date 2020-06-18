using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCustomCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AhmetList ahm = new AhmetList();
            ahm.Add(1);
            ahm.Add(2);
            ahm.Add("Mehmet");

            ahm.Contains("Mehmet");
            ahm.Insert(2,"Dursun");
            ahm.Remove("Dursun");
        }
    }
}
