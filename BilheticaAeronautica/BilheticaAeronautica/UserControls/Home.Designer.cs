namespace BilheticaAeronautica.UserControls
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTrocar = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxOrigem = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            comboBoxDestino = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            checkBoxIdaEVolta = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            dataPartida = new DateTimePicker();
            dataChegada = new DateTimePicker();
            btnPesquisar = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            totalAdultos = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            totalCriancas = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            label7 = new Label();
            TotalBebes = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            comboBoxClasse = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalAdultos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalCriancas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalBebes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTrocar
            // 
            btnTrocar.BackColor = Color.Black;
            btnTrocar.FlatAppearance.BorderSize = 0;
            btnTrocar.FlatStyle = FlatStyle.Flat;
            btnTrocar.Image = Properties.Resources.icons8_replace_50;
            btnTrocar.Location = new Point(487, 235);
            btnTrocar.Margin = new Padding(5, 4, 5, 4);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(81, 76);
            btnTrocar.TabIndex = 0;
            btnTrocar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 141);
            label1.Name = "label1";
            label1.Size = new Size(113, 34);
            label1.TabIndex = 1;
            label1.Text = "Origem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 277);
            label2.Name = "label2";
            label2.Size = new Size(116, 34);
            label2.TabIndex = 2;
            label2.Text = "Destino";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(99, 183);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.ShowSymbolFontPreview = false;
            comboBoxOrigem.Size = new Size(360, 39);
            comboBoxOrigem.TabIndex = 3;
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(255, 255, 255);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(225, 225, 225);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(225, 225, 225);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(114, 114, 114);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(94, 94, 94);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(225, 225, 225);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ScrollBarBackColor = Color.FromArgb(225, 225, 225);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbColor = Color.FromArgb(255, 255, 255);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbDisabledColor = Color.FromArgb(225, 225, 225);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbHoverColor = Color.FromArgb(197, 197, 197);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxOrigem.ThemeStyle.ScrollBarStyle.ThumbPressedColor = Color.FromArgb(197, 197, 197);
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(99, 316);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.ShowSymbolFontPreview = false;
            comboBoxDestino.Size = new Size(362, 39);
            comboBoxDestino.TabIndex = 4;
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(255, 255, 255);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(225, 225, 225);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(225, 225, 225);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(114, 114, 114);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(94, 94, 94);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(225, 225, 225);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ScrollBarBackColor = Color.FromArgb(225, 225, 225);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbColor = Color.FromArgb(255, 255, 255);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbDisabledColor = Color.FromArgb(225, 225, 225);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbHoverColor = Color.FromArgb(197, 197, 197);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxDestino.ThemeStyle.ScrollBarStyle.ThumbPressedColor = Color.FromArgb(197, 197, 197);
            // 
            // checkBoxIdaEVolta
            // 
            checkBoxIdaEVolta.AutoSize = true;
            checkBoxIdaEVolta.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            checkBoxIdaEVolta.Location = new Point(22, 27);
            checkBoxIdaEVolta.Name = "checkBoxIdaEVolta";
            checkBoxIdaEVolta.Size = new Size(145, 31);
            checkBoxIdaEVolta.TabIndex = 5;
            checkBoxIdaEVolta.Text = "Ida e volta";
            checkBoxIdaEVolta.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            checkBox1.Location = new Point(204, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 31);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Só ida";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 410);
            label3.Name = "label3";
            label3.Size = new Size(219, 34);
            label3.TabIndex = 8;
            label3.Text = "Data de partida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 410);
            label4.Name = "label4";
            label4.Size = new Size(234, 34);
            label4.TabIndex = 9;
            label4.Text = "Data de chegada";
            // 
            // dataPartida
            // 
            dataPartida.Location = new Point(97, 463);
            dataPartida.Name = "dataPartida";
            dataPartida.Size = new Size(250, 38);
            dataPartida.TabIndex = 10;
            // 
            // dataChegada
            // 
            dataChegada.Location = new Point(394, 457);
            dataChegada.Name = "dataChegada";
            dataChegada.Size = new Size(250, 38);
            dataChegada.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkGoldenrod;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(97, 920);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(547, 57);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(724, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 756);
            dataGridView1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(97, 551);
            label5.Name = "label5";
            label5.Size = new Size(166, 34);
            label5.TabIndex = 15;
            label5.Text = "Passageiros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkGoldenrod;
            label6.Location = new Point(99, 612);
            label6.Name = "label6";
            label6.Size = new Size(91, 27);
            label6.TabIndex = 16;
            label6.Text = "Adultos";
            // 
            // totalAdultos
            // 
            totalAdultos.BeforeTouchSize = new Size(81, 38);
            totalAdultos.Location = new Point(203, 608);
            totalAdultos.Name = "totalAdultos";
            totalAdultos.Size = new Size(81, 38);
            totalAdultos.TabIndex = 17;
            // 
            // totalCriancas
            // 
            totalCriancas.BeforeTouchSize = new Size(81, 38);
            totalCriancas.Location = new Point(203, 703);
            totalCriancas.Name = "totalCriancas";
            totalCriancas.Size = new Size(81, 38);
            totalCriancas.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGoldenrod;
            label7.Location = new Point(99, 707);
            label7.Name = "label7";
            label7.Size = new Size(98, 27);
            label7.TabIndex = 18;
            label7.Text = "Crianças";
            // 
            // TotalBebes
            // 
            TotalBebes.BeforeTouchSize = new Size(81, 38);
            TotalBebes.Location = new Point(203, 793);
            TotalBebes.Name = "TotalBebes";
            TotalBebes.Size = new Size(81, 38);
            TotalBebes.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGoldenrod;
            label8.Location = new Point(99, 799);
            label8.Name = "label8";
            label8.Size = new Size(73, 27);
            label8.TabIndex = 20;
            label8.Text = "Bebés";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(97, 649);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 22;
            label9.Text = "Mais de 12 anos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(97, 746);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 23;
            label10.Text = "2 a 11 anos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(97, 834);
            label12.Name = "label12";
            label12.Size = new Size(180, 20);
            label12.TabIndex = 25;
            label12.Text = "Idade inferior a 2 anos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(checkBoxIdaEVolta);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(97, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 81);
            panel1.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Gadugi", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(394, 551);
            label11.Name = "label11";
            label11.Size = new Size(94, 34);
            label11.TabIndex = 27;
            label11.Text = "Classe";
            // 
            // comboBoxClasse
            // 
            comboBoxClasse.FormattingEnabled = true;
            comboBoxClasse.Location = new Point(394, 600);
            comboBoxClasse.Name = "comboBoxClasse";
            comboBoxClasse.ShowSymbolFontPreview = false;
            comboBoxClasse.Size = new Size(250, 39);
            comboBoxClasse.TabIndex = 28;
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonBackColor = Color.FromArgb(255, 255, 255);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonBorderColor = Color.FromArgb(225, 225, 225);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBackColor = Color.FromArgb(225, 225, 225);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBackColor = Color.FromArgb(114, 114, 114);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonHoverBorderColor = Color.FromArgb(94, 94, 94);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBackColor = Color.FromArgb(225, 225, 225);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ArrowButtonPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ScrollBarBackColor = Color.FromArgb(225, 225, 225);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbColor = Color.FromArgb(255, 255, 255);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbDisabledBorderColor = Color.FromArgb(210, 210, 210);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbDisabledColor = Color.FromArgb(225, 225, 225);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbHoverBorderColor = Color.FromArgb(171, 171, 171);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbHoverColor = Color.FromArgb(197, 197, 197);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbPressedBorderColor = Color.FromArgb(150, 150, 150);
            comboBoxClasse.ThemeStyle.ScrollBarStyle.ThumbPressedColor = Color.FromArgb(197, 197, 197);
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxClasse);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(TotalBebes);
            Controls.Add(label8);
            Controls.Add(totalCriancas);
            Controls.Add(label7);
            Controls.Add(totalAdultos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnPesquisar);
            Controls.Add(dataChegada);
            Controls.Add(dataPartida);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTrocar);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Home";
            Size = new Size(1515, 1059);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalAdultos).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalCriancas).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalBebes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrocar;
        private Label label1;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.FontComboBox comboBoxOrigem;
        private Syncfusion.Windows.Forms.Tools.FontComboBox comboBoxDestino;
        private CheckBox checkBoxIdaEVolta;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker dataPartida;
        private DateTimePicker dataChegada;
        private Button btnPesquisar;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt totalAdultos;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt totalCriancas;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt TotalBebes;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Panel panel1;
        private Label label11;
        private Syncfusion.Windows.Forms.Tools.FontComboBox comboBoxClasse;
    }
}
