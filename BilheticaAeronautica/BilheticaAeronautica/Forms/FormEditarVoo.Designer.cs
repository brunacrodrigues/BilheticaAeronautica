namespace BilheticaAeronautica.Forms
{
    partial class FormEditarVoo
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
            btnGuardar = new Button();
            label14 = new Label();
            groupBoxPrecoBilhete = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            numericUpDownExecutivo = new NumericUpDown();
            numericUpDownEconomico = new NumericUpDown();
            horaPartidaPicker = new DateTimePicker();
            duracaoVoo = new DateTimePicker();
            label5 = new Label();
            comboBoxModelos = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            dataPartidaPicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            lblDisponibilidade = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblLugaresDisponiveis = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            lblNumeroVoo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button2 = new Button();
            button1 = new Button();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel4 = new Panel();
            panel1 = new Panel();
            btnFechar = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            groupBoxPrecoBilhete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEconomico).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(236, 175, 74);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(83, 4, 17);
            btnGuardar.Image = Properties.Resources.icons8_confirm_40;
            btnGuardar.Location = new Point(880, 509);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(401, 57);
            btnGuardar.TabIndex = 85;
            btnGuardar.Text = "        Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(83, 4, 17);
            label14.Location = new Point(89, 97);
            label14.Name = "label14";
            label14.Size = new Size(247, 40);
            label14.TabIndex = 200;
            label14.Text = "Modificar Voo";
            // 
            // groupBoxPrecoBilhete
            // 
            groupBoxPrecoBilhete.BackColor = Color.White;
            groupBoxPrecoBilhete.Controls.Add(label6);
            groupBoxPrecoBilhete.Controls.Add(label7);
            groupBoxPrecoBilhete.Controls.Add(numericUpDownExecutivo);
            groupBoxPrecoBilhete.Controls.Add(numericUpDownEconomico);
            groupBoxPrecoBilhete.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPrecoBilhete.ForeColor = Color.FromArgb(83, 4, 17);
            groupBoxPrecoBilhete.Location = new Point(880, 263);
            groupBoxPrecoBilhete.Name = "groupBoxPrecoBilhete";
            groupBoxPrecoBilhete.Size = new Size(338, 159);
            groupBoxPrecoBilhete.TabIndex = 199;
            groupBoxPrecoBilhete.TabStop = false;
            groupBoxPrecoBilhete.Text = "Definir Preço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(83, 4, 17);
            label6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(22, 109);
            label6.Name = "label6";
            label6.Size = new Size(113, 24);
            label6.TabIndex = 3;
            label6.Text = "Económico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(83, 4, 17);
            label7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Cornsilk;
            label7.Location = new Point(22, 50);
            label7.Name = "label7";
            label7.Size = new Size(102, 24);
            label7.TabIndex = 2;
            label7.Text = "Executivo";
            // 
            // numericUpDownExecutivo
            // 
            numericUpDownExecutivo.Font = new Font("Gadugi", 12F);
            numericUpDownExecutivo.Location = new Point(190, 48);
            numericUpDownExecutivo.Margin = new Padding(5, 4, 5, 4);
            numericUpDownExecutivo.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            numericUpDownExecutivo.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownExecutivo.Name = "numericUpDownExecutivo";
            numericUpDownExecutivo.Size = new Size(118, 34);
            numericUpDownExecutivo.TabIndex = 0;
            numericUpDownExecutivo.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericUpDownEconomico
            // 
            numericUpDownEconomico.Font = new Font("Gadugi", 12F);
            numericUpDownEconomico.Location = new Point(190, 107);
            numericUpDownEconomico.Margin = new Padding(5, 4, 5, 4);
            numericUpDownEconomico.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownEconomico.Minimum = new decimal(new int[] { 45, 0, 0, 0 });
            numericUpDownEconomico.Name = "numericUpDownEconomico";
            numericUpDownEconomico.Size = new Size(118, 34);
            numericUpDownEconomico.TabIndex = 1;
            numericUpDownEconomico.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // horaPartidaPicker
            // 
            horaPartidaPicker.CustomFormat = "HH:mm";
            horaPartidaPicker.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            horaPartidaPicker.Format = DateTimePickerFormat.Custom;
            horaPartidaPicker.Location = new Point(402, 532);
            horaPartidaPicker.Name = "horaPartidaPicker";
            horaPartidaPicker.ShowUpDown = true;
            horaPartidaPicker.Size = new Size(96, 34);
            horaPartidaPicker.TabIndex = 198;
            horaPartidaPicker.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // duracaoVoo
            // 
            duracaoVoo.CustomFormat = "HH:mm";
            duracaoVoo.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duracaoVoo.Format = DateTimePickerFormat.Custom;
            duracaoVoo.Location = new Point(606, 532);
            duracaoVoo.Name = "duracaoVoo";
            duracaoVoo.ShowUpDown = true;
            duracaoVoo.Size = new Size(85, 34);
            duracaoVoo.TabIndex = 197;
            duracaoVoo.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(236, 175, 74);
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(83, 4, 17);
            label5.Location = new Point(381, 491);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 196;
            label5.Text = "Hora de partida";
            // 
            // comboBoxModelos
            // 
            comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelos.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxModelos.FormattingEnabled = true;
            comboBoxModelos.ImeMode = ImeMode.On;
            comboBoxModelos.Location = new Point(234, 200);
            comboBoxModelos.Name = "comboBoxModelos";
            comboBoxModelos.Size = new Size(461, 32);
            comboBoxModelos.TabIndex = 195;
            comboBoxModelos.UseWaitCursor = true;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigem.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(234, 320);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(461, 32);
            comboBoxOrigem.TabIndex = 194;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestino.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(234, 416);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(461, 32);
            comboBoxDestino.TabIndex = 193;
            // 
            // dataPartidaPicker
            // 
            dataPartidaPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            dataPartidaPicker.Font = new Font("Gadugi", 12F);
            dataPartidaPicker.Format = DateTimePickerFormat.Short;
            dataPartidaPicker.Location = new Point(89, 532);
            dataPartidaPicker.MinDate = new DateTime(2025, 3, 25, 0, 0, 0, 0);
            dataPartidaPicker.Name = "dataPartidaPicker";
            dataPartidaPicker.Size = new Size(254, 34);
            dataPartidaPicker.TabIndex = 192;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(236, 175, 74);
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(83, 4, 17);
            label4.Location = new Point(606, 491);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 191;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(236, 175, 74);
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(83, 4, 17);
            label3.Location = new Point(89, 491);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 190;
            label3.Text = "Data de partida";
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.Font = new Font("Gadugi", 12F);
            lblDisponibilidade.ForeColor = Color.FromArgb(83, 4, 17);
            lblDisponibilidade.Location = new Point(234, 240);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(184, 24);
            lblDisponibilidade.TabIndex = 189;
            lblDisponibilidade.Text = "Lugares disponíveis:";
            lblDisponibilidade.Visible = false;
            // 
            // lblLugaresDisponiveis
            // 
            lblLugaresDisponiveis.Font = new Font("Gadugi", 12F);
            lblLugaresDisponiveis.ForeColor = Color.FromArgb(83, 4, 17);
            lblLugaresDisponiveis.Location = new Point(420, 240);
            lblLugaresDisponiveis.Name = "lblLugaresDisponiveis";
            lblLugaresDisponiveis.Size = new Size(107, 24);
            lblLugaresDisponiveis.TabIndex = 188;
            lblLugaresDisponiveis.Text = "autoLabel2";
            lblLugaresDisponiveis.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(83, 14, 17);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Cornsilk;
            button5.Location = new Point(89, 182);
            button5.Name = "button5";
            button5.Size = new Size(129, 72);
            button5.TabIndex = 187;
            button5.Text = "Modelo Avião";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(83, 14, 17);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(89, 402);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 186;
            button4.Text = "Destino";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(83, 14, 17);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(89, 309);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 185;
            button3.Text = "Origem";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Font = new Font("Gadugi", 12F);
            lblNumeroVoo.ForeColor = Color.FromArgb(83, 14, 7);
            lblNumeroVoo.Location = new Point(1287, 186);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(82, 24);
            lblNumeroVoo.TabIndex = 184;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(1152, 182);
            button2.Name = "button2";
            button2.Size = new Size(129, 32);
            button2.TabIndex = 183;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 14, 17);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(880, 182);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 182;
            button1.Text = "Id";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F);
            lblId.ForeColor = Color.FromArgb(83, 14, 7);
            lblId.Location = new Point(999, 186);
            lblId.Name = "lblId";
            lblId.Size = new Size(82, 24);
            lblId.TabIndex = 180;
            lblId.Text = "<none>";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1423, 56);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 601);
            panel4.TabIndex = 204;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1423, 56);
            panel1.TabIndex = 202;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(1342, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 57);
            btnFechar.TabIndex = 97;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 657);
            panel3.TabIndex = 201;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(1428, 5);
            panel2.TabIndex = 203;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = panel1;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = this;
            // 
            // FormEditarVoo
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1428, 662);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(groupBoxPrecoBilhete);
            Controls.Add(horaPartidaPicker);
            Controls.Add(duracaoVoo);
            Controls.Add(label5);
            Controls.Add(comboBoxModelos);
            Controls.Add(comboBoxOrigem);
            Controls.Add(comboBoxDestino);
            Controls.Add(dataPartidaPicker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDisponibilidade);
            Controls.Add(lblLugaresDisponiveis);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lblNumeroVoo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblId);
            Controls.Add(btnGuardar);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarVoo";
            Text = "FormEditarVoo";
            groupBoxPrecoBilhete.ResumeLayout(false);
            groupBoxPrecoBilhete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEconomico).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label14;
        private GroupBox groupBoxPrecoBilhete;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownExecutivo;
        private NumericUpDown numericUpDownEconomico;
        private DateTimePicker horaPartidaPicker;
        private DateTimePicker duracaoVoo;
        private Label label5;
        private ComboBox comboBoxModelos;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private DateTimePicker dataPartidaPicker;
        private Label label4;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDisponibilidade;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLugaresDisponiveis;
        private Button button5;
        private Button button4;
        private Button button3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumeroVoo;
        private Button button2;
        private Button button1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Panel panel4;
        private Panel panel1;
        private Button btnFechar;
        private Panel panel3;
        private Panel panel2;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}