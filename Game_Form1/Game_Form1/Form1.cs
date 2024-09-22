using System;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Game_Form1
{
    public partial class Game_Form1 : Form
    {
        public Game_Form1()
        {
            InitializeComponent();

            RenderOptions.ProcessRenderMode = System.Windows.Interop.RenderMode.Default;
            if ("kazem" == "kazem")
            {
                Console.WriteLine("Hello Kazem");
            }
        }

        int speed = 3, loop = 5;
        public static Keys keyP1 = Keys.Left, keyP2 = Keys.Right;
        bool game = false, keyUp = true;

        private void Game_Form1_Load(object sender, EventArgs e)
        {
            scopeP1.Left = this.Width / 2 - scopeP1.Width;
            scopeP2.Left = scopeP1.Right;
            pic1.Left = scopeP2.Left - pic1.Width / 2;
        }

        private void Game_Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (pic1.Visible)
            {
                if (e.KeyCode == keyP2)
                {
                    pic1.BeginInvoke((MethodInvoker)async delegate
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            pic1.Left += speed;
                            await Task.Delay(8);
                        }
                    });
                }
                if (e.KeyCode == keyP1)
                {
                    pic1.BeginInvoke((MethodInvoker)async delegate
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            pic1.Left -= speed;
                            await Task.Delay(8);
                        }
                    });
                }
                return;
            }
            else if (!keyUp)
            {
                keyUp = true;
                return;
            }
            else if (e.KeyCode == Keys.Space)
            {
                FrmTimer f = new FrmTimer();
                f.ShowDialog();
                pic1.Visible = true;
                game = true;
            }
        }

        private async void pic1_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    pic1.BeginInvoke((MethodInvoker)delegate
                    {
                        if (pic1.Left <= scopeP1.Left)
                        {
                            if (game)
                            {
                                game = false;
                                MessageBox.Show("Player1 Winner", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Game_Form1_Load(null, null);
                                pic1.Visible = false;
                            }
                        }
                        else if (pic1.Right >= scopeP2.Right)
                        {
                            if (game)
                            {
                                game = false;
                                pic1.Visible = false;
                                MessageBox.Show("Player2 Winner", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Game_Form1_Load(null, null);
                            }
                        }
                    });
                });
            }
            catch
            {
                return;
            }
        }

        private void سرعتمهرهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSpeed f = new FrmSpeed();
            f.numUD.Value = speed;
            f.numUD1.Value = loop;
            f.ShowDialog();
            speed = (int)f.numUD.Value;
            loop = (int)f.numUD1.Value;
        }

        private void دکمهبازیکن1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKeyPl f = new FrmKeyPl(keyP2);
            f.ShowDialog();
            if (f.Key != Keys.None)
                keyP1 = f.Key;
            keyUp = false;
        }

        private void دکمهبازیکن2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKeyPl f = new FrmKeyPl(keyP1);
            f.ShowDialog();
            if (f.Key != Keys.None)
                keyP2 = f.Key;
            keyUp = false;
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            if (game)
            {
                if (e.Button == MouseButtons.Right)
                {
                    pic1.BeginInvoke((MethodInvoker)async delegate
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            pic1.Left += speed;
                            await Task.Delay(8);
                        }
                    });
                }
                if (e.Button == MouseButtons.Left)
                {
                    pic1.BeginInvoke((MethodInvoker)async delegate
                    {
                        for (int i = 0; i < loop; i++)
                        {
                            pic1.Left -= speed;
                            await Task.Delay(8);
                        }
                    });
                }
            }
        }
    }
}
