using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Form1
{
    public partial class FrmSpeed : Form
    {
        public FrmSpeed()
        {
            InitializeComponent();
        }
        bool success = false;
        private void button1_Click(object sender, EventArgs e)
        {
            success = true;
            this.Close();
        }

        private void FrmSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
                e.Cancel = true;
        }
    }
}
