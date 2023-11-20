using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donanımbilgisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTümParçalar.Items.Count; i++) 
            {
                if (lstTümParçalar.Items[i].ToString()=="hoperlör"||
                    lstTümParçalar.Items[i].ToString() =="mikrofon"||
                    lstTümParçalar.Items[i].ToString() == "monitör"||
                     lstTümParçalar.Items[i].ToString() == "klavye")
                {
                    lstDisDonanim.Items.Add(lstTümParçalar.Items[i]);
                }
                else
                {
                    lstİcDonanim.Items.Add(lstTümParçalar.Items[i]);
                }
            }

        }
    }
}
