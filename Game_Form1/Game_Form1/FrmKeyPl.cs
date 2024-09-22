using System.Windows.Forms;

namespace Game_Form1
{
    public partial class FrmKeyPl : Form
    {
        public FrmKeyPl(Keys plKey)
        {
            InitializeComponent();
            Key = plKey;
        }

        public Keys Key { get; set; }
        bool success = false;
        private void FrmKeyPl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.ShiftKey
                && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu
                && e.KeyCode != Keys.Space && e.KeyCode != Keys.LWin && e.KeyCode != Keys.RWin)
            {
                if (Key == e.KeyCode)
                {
                    MessageBox.Show("دکمه انتخابی تکراری است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                success = true;
                Key = e.KeyCode;
                this.Close();
            }
            else if (e.KeyCode == Keys.Space)
            {
                success = true;
                Key = Keys.None;
                this.Close();
            }
            else
                MessageBox.Show("دکمه انتخابی مجاز نیست", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmKeyPl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
                e.Cancel = true;
        }
    }
}
