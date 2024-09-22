namespace Game_Form1
{
    partial class FrmSpeed
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
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numUD1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // numUD
            // 
            this.numUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD.Location = new System.Drawing.Point(139, 84);
            this.numUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(149, 27);
            this.numUD.TabIndex = 0;
            this.numUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(426, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "سرعت مهره را تعیین کنید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUD1
            // 
            this.numUD1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD1.Location = new System.Drawing.Point(139, 137);
            this.numUD1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD1.Name = "numUD1";
            this.numUD1.Size = new System.Drawing.Size(149, 27);
            this.numUD1.TabIndex = 0;
            this.numUD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmSpeed
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 287);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD1);
            this.Controls.Add(this.numUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSpeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSpeed_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown numUD;
        public System.Windows.Forms.NumericUpDown numUD1;
    }
}