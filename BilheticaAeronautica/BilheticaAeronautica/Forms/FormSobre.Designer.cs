namespace BilheticaAeronautica.Forms
{
    partial class FormSobre
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            btnFechar = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(83, 4, 17);
            groupBox1.Location = new Point(91, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Créditos";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Cornsilk;
            textBox3.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(83, 4, 17);
            textBox3.Location = new Point(218, 144);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(246, 38);
            textBox3.TabIndex = 123;
            textBox3.Text = "10/04/2025";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Cornsilk;
            textBox2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(83, 4, 17);
            textBox2.Location = new Point(218, 222);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(246, 38);
            textBox2.TabIndex = 122;
            textBox2.Text = "1.0.0";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Cornsilk;
            textBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(83, 4, 17);
            textBox1.Location = new Point(218, 65);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(246, 38);
            textBox1.TabIndex = 121;
            textBox1.Text = "Bruna Rodrigues";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(53, 137);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 120;
            button2.Text = "Data";
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(53, 215);
            button5.Name = "button5";
            button5.Size = new Size(129, 49);
            button5.TabIndex = 119;
            button5.Text = "Versão";
            button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(53, 58);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 118;
            button1.Text = "Autora";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 44);
            panel1.TabIndex = 204;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(652, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(53, 44);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(700, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 402);
            panel4.TabIndex = 206;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 441);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 5);
            panel2.TabIndex = 207;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 397);
            panel3.TabIndex = 208;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = panel1;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = this;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(705, 446);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormSobre";
            Text = "FormSobre";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button5;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel1;
        private Button btnFechar;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}