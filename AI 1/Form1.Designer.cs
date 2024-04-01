namespace AI_1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.robot_eye;
            pictureBox1.Location = new Point(80, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.robot_eye;
            pictureBox2.Location = new Point(320, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 256);
            label1.Name = "label1";
            label1.Size = new Size(33, 38);
            label1.TabIndex = 2;
            label1.Text = "0";
            label1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(12, 372);
            button1.Name = "button1";
            button1.Size = new Size(162, 54);
            button1.TabIndex = 3;
            button1.Text = "Basla\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Location = new Point(80, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 70);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(80, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 70);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._925912_face_happy_ok_smile_smiley_icon;
            pictureBox3.Location = new Point(190, 235);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(447, 224);
            label2.Name = "label2";
            label2.Size = new Size(96, 38);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(416, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 43);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            textBox1.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "/", "*" });
            comboBox1.Location = new Point(416, 325);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 45);
            comboBox1.TabIndex = 9;
            comboBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(416, 383);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 43);
            textBox2.TabIndex = 10;
            textBox2.Text = "0";
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 378);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 43);
            textBox3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(625, 461);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
