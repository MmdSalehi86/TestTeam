using System.Windows.Forms;

namespace Game_Form1
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
        }

        bool cancelExit = true;

        private void FrmTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cancelExit;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (label1.Text == "0")
            {
                cancelExit = false;
                timer1.Enabled = false;
                this.Close();
            }
            label1.Text = (int.Parse(label1.Text) - 1).ToString();
        }
    }
}
