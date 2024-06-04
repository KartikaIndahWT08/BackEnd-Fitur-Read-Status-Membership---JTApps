namespace Homepage
{
    partial class Form2
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
            reundedClass11 = new reundedClass1();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            reundedClass11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // reundedClass11
            // 
            reundedClass11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reundedClass11.BackColor = Color.White;
            reundedClass11.Controls.Add(label2);
            reundedClass11.Controls.Add(label1);
            reundedClass11.Controls.Add(textBox1);
            reundedClass11.Controls.Add(pictureBox3);
            reundedClass11.CornerRadius = 8;
            reundedClass11.Location = new Point(114, 53);
            reundedClass11.Name = "reundedClass11";
            reundedClass11.Size = new Size(503, 40);
            reundedClass11.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 13);
            label2.Name = "label2";
            label2.Size = new Size(289, 20);
            label2.TabIndex = 3;
            label2.Text = "                                                                      ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(30, 10);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Mau kemana hari ini?";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(30, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 20);
            textBox1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Vector;
            pictureBox3.Location = new Point(3, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reundedClass11);
            Name = "Form2";
            Text = "Form2";
            reundedClass11.ResumeLayout(false);
            reundedClass11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private reundedClass1 reundedClass11;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox3;
    }
}