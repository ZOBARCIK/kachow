namespace kachow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuHighlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS Reference Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(101, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(608, 49);
            textBox1.TabIndex = 0;
            textBox1.Text = "Yarın akşam müsait misin?";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("MS Reference Sans Serif", 20F);
            button1.Location = new Point(140, 294);
            button1.Name = "button1";
            button1.Size = new Size(258, 79);
            button1.TabIndex = 1;
            button1.Text = "EVET(KA-CHOW)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 64);
            button2.Font = new Font("MS Reference Sans Serif", 10F);
            button2.Location = new Point(480, 320);
            button2.Name = "button2";
            button2.Size = new Size(57, 39);
            button2.TabIndex = 2;
            button2.Text = "NO :/";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8de9f0ac_07cc_4b59_8434_a81c00f56a6c_840_True;
            pictureBox1.Location = new Point(332, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bladerunner2049_ryan_gosling;
            pictureBox2.Location = new Point(53, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 135);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.jake_gyllenhaal_stare;
            pictureBox3.Location = new Point(10, 294);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(124, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Tag = "";
            Text = "KA-CHOW";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
