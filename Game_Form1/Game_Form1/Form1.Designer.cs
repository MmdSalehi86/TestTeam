namespace Game_Form1
{
    partial class Game_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.scopeP1 = new System.Windows.Forms.PictureBox();
            this.scopeP2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دکمهبازیکن1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دکمهبازیکن2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سرعتمهرهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeP2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic1.BackColor = System.Drawing.Color.Lime;
            this.pic1.Location = new System.Drawing.Point(291, 240);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(50, 45);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            this.pic1.LocationChanged += new System.EventHandler(this.pic1_LocationChanged);
            this.pic1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            // 
            // scopeP1
            // 
            this.scopeP1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scopeP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.scopeP1.Location = new System.Drawing.Point(18, 85);
            this.scopeP1.Name = "scopeP1";
            this.scopeP1.Size = new System.Drawing.Size(300, 360);
            this.scopeP1.TabIndex = 1;
            this.scopeP1.TabStop = false;
            this.scopeP1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            // 
            // scopeP2
            // 
            this.scopeP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scopeP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.scopeP2.Location = new System.Drawing.Point(318, 85);
            this.scopeP2.Name = "scopeP2";
            this.scopeP2.Size = new System.Drawing.Size(300, 360);
            this.scopeP2.TabIndex = 1;
            this.scopeP2.TabStop = false;
            this.scopeP2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیماتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(647, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دکمهبازیکن1ToolStripMenuItem,
            this.دکمهبازیکن2ToolStripMenuItem,
            this.سرعتمهرهToolStripMenuItem});
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // دکمهبازیکن1ToolStripMenuItem
            // 
            this.دکمهبازیکن1ToolStripMenuItem.Name = "دکمهبازیکن1ToolStripMenuItem";
            this.دکمهبازیکن1ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.دکمهبازیکن1ToolStripMenuItem.Text = "دکمه بازیکن 1";
            this.دکمهبازیکن1ToolStripMenuItem.Click += new System.EventHandler(this.دکمهبازیکن1ToolStripMenuItem_Click);
            // 
            // دکمهبازیکن2ToolStripMenuItem
            // 
            this.دکمهبازیکن2ToolStripMenuItem.Name = "دکمهبازیکن2ToolStripMenuItem";
            this.دکمهبازیکن2ToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.دکمهبازیکن2ToolStripMenuItem.Text = "دکمه بازیکن 2";
            this.دکمهبازیکن2ToolStripMenuItem.Click += new System.EventHandler(this.دکمهبازیکن2ToolStripMenuItem_Click);
            // 
            // سرعتمهرهToolStripMenuItem
            // 
            this.سرعتمهرهToolStripMenuItem.Name = "سرعتمهرهToolStripMenuItem";
            this.سرعتمهرهToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.سرعتمهرهToolStripMenuItem.Text = "سرعت مهره";
            this.سرعتمهرهToolStripMenuItem.Click += new System.EventHandler(this.سرعتمهرهToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 494);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(647, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "برای شروع بازی دکمه فاصله را فشار دهید";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Game_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.scopeP2);
            this.Controls.Add(this.scopeP1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Game_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Form1";
            this.Load += new System.EventHandler(this.Game_Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeP2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox scopeP1;
        private System.Windows.Forms.PictureBox scopeP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دکمهبازیکن1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دکمهبازیکن2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سرعتمهرهToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

