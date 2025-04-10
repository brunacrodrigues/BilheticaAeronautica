namespace BilheticaAeronautica.UserControls
{
    partial class ucVoos
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
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            numericUpDownExecutivo = new NumericUpDown();
            numericUpDownEconomico = new NumericUpDown();
            btnVenderBilhetes = new Button();
            horaPartidaPicker = new DateTimePicker();
            duracaoVoo = new DateTimePicker();
            label5 = new Label();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            gridViewVoosAgendados = new DataGridView();
            btnCancelar = new Button();
            btnEditar = new Button();
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
            btnAgendar = new Button();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1 = new Panel();
            label1 = new Label();
            label14 = new Label();
            comboBoxModelos = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEconomico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDownExecutivo);
            groupBox1.Controls.Add(numericUpDownEconomico);
            groupBox1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(83, 4, 17);
            groupBox1.Location = new Point(942, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 159);
            groupBox1.TabIndex = 107;
            groupBox1.TabStop = false;
            groupBox1.Text = "Definir Preço";
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
            // btnVenderBilhetes
            // 
            btnVenderBilhetes.BackColor = Color.FromArgb(236, 175, 74);
            btnVenderBilhetes.FlatAppearance.BorderSize = 0;
            btnVenderBilhetes.FlatStyle = FlatStyle.Flat;
            btnVenderBilhetes.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVenderBilhetes.ForeColor = Color.FromArgb(83, 14, 7);
            btnVenderBilhetes.Image = Properties.Resources.icons8_two_tickets_30__1_;
            btnVenderBilhetes.ImageAlign = ContentAlignment.MiddleLeft;
            btnVenderBilhetes.Location = new Point(1349, 785);
            btnVenderBilhetes.Name = "btnVenderBilhetes";
            btnVenderBilhetes.Size = new Size(206, 63);
            btnVenderBilhetes.TabIndex = 106;
            btnVenderBilhetes.Text = "Vender Bilhetes";
            btnVenderBilhetes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVenderBilhetes.UseVisualStyleBackColor = false;
            btnVenderBilhetes.Click += btnVenderBilhetes_Click;
            // 
            // horaPartidaPicker
            // 
            horaPartidaPicker.CustomFormat = "HH:mm";
            horaPartidaPicker.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            horaPartidaPicker.Format = DateTimePickerFormat.Custom;
            horaPartidaPicker.Location = new Point(411, 459);
            horaPartidaPicker.Name = "horaPartidaPicker";
            horaPartidaPicker.ShowUpDown = true;
            horaPartidaPicker.Size = new Size(96, 34);
            horaPartidaPicker.TabIndex = 105;
            horaPartidaPicker.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // duracaoVoo
            // 
            duracaoVoo.CustomFormat = "HH:mm";
            duracaoVoo.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            duracaoVoo.Format = DateTimePickerFormat.Custom;
            duracaoVoo.Location = new Point(615, 459);
            duracaoVoo.Name = "duracaoVoo";
            duracaoVoo.ShowUpDown = true;
            duracaoVoo.Size = new Size(85, 34);
            duracaoVoo.TabIndex = 104;
            duracaoVoo.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(236, 175, 74);
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(83, 4, 17);
            label5.Location = new Point(390, 418);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 103;
            label5.Text = "Hora de partida";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigem.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(243, 247);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(461, 32);
            comboBoxOrigem.TabIndex = 101;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestino.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(243, 343);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(461, 32);
            comboBoxDestino.TabIndex = 100;
            // 
            // gridViewVoosAgendados
            // 
            gridViewVoosAgendados.AllowUserToAddRows = false;
            gridViewVoosAgendados.AllowUserToDeleteRows = false;
            gridViewVoosAgendados.AllowUserToResizeColumns = false;
            gridViewVoosAgendados.AllowUserToResizeRows = false;
            gridViewVoosAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewVoosAgendados.BackgroundColor = Color.White;
            gridViewVoosAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewVoosAgendados.GridColor = Color.White;
            gridViewVoosAgendados.Location = new Point(98, 632);
            gridViewVoosAgendados.Name = "gridViewVoosAgendados";
            gridViewVoosAgendados.ReadOnly = true;
            gridViewVoosAgendados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewVoosAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewVoosAgendados.Size = new Size(1246, 351);
            gridViewVoosAgendados.TabIndex = 99;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = Properties.Resources.icons8_cancel_30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(1349, 920);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 63);
            btnCancelar.TabIndex = 98;
            btnCancelar.Text = "  Cancelar Voo";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Image = Properties.Resources.icons8_edit_30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(1350, 854);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(206, 60);
            btnEditar.TabIndex = 97;
            btnEditar.Text = "  Editar Voo";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dataPartidaPicker
            // 
            dataPartidaPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            dataPartidaPicker.Font = new Font("Gadugi", 12F);
            dataPartidaPicker.Format = DateTimePickerFormat.Short;
            dataPartidaPicker.Location = new Point(98, 459);
            dataPartidaPicker.MinDate = new DateTime(2025, 3, 25, 0, 0, 0, 0);
            dataPartidaPicker.Name = "dataPartidaPicker";
            dataPartidaPicker.Size = new Size(254, 34);
            dataPartidaPicker.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(236, 175, 74);
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(83, 4, 17);
            label4.Location = new Point(615, 418);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 94;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(236, 175, 74);
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(83, 4, 17);
            label3.Location = new Point(98, 418);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 93;
            label3.Text = "Data de partida";
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.Font = new Font("Gadugi", 12F);
            lblDisponibilidade.ForeColor = Color.FromArgb(83, 4, 17);
            lblDisponibilidade.Location = new Point(243, 167);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(184, 24);
            lblDisponibilidade.TabIndex = 92;
            lblDisponibilidade.Text = "Lugares disponíveis:";
            lblDisponibilidade.Visible = false;
            // 
            // lblLugaresDisponiveis
            // 
            lblLugaresDisponiveis.Font = new Font("Gadugi", 12F);
            lblLugaresDisponiveis.ForeColor = Color.FromArgb(83, 4, 17);
            lblLugaresDisponiveis.Location = new Point(429, 167);
            lblLugaresDisponiveis.Name = "lblLugaresDisponiveis";
            lblLugaresDisponiveis.Size = new Size(107, 24);
            lblLugaresDisponiveis.TabIndex = 91;
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
            button5.Location = new Point(98, 109);
            button5.Name = "button5";
            button5.Size = new Size(129, 72);
            button5.TabIndex = 90;
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
            button4.Location = new Point(98, 329);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 89;
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
            button3.Location = new Point(98, 236);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 88;
            button3.Text = "Origem";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroVoo.ForeColor = Color.FromArgb(83, 14, 7);
            lblNumeroVoo.Location = new Point(1349, 113);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(85, 24);
            lblNumeroVoo.TabIndex = 87;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 14, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(1214, 109);
            button2.Name = "button2";
            button2.Size = new Size(129, 32);
            button2.TabIndex = 86;
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
            button1.Location = new Point(942, 109);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 85;
            button1.Text = "Id";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.FromArgb(236, 175, 74);
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.FromArgb(83, 4, 17);
            btnAgendar.Image = Properties.Resources.icons8_confirm_40;
            btnAgendar.Location = new Point(942, 436);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(401, 57);
            btnAgendar.TabIndex = 84;
            btnAgendar.Text = "        Agendar Voo";
            btnAgendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lblId
            // 
            lblId.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(83, 14, 7);
            lblId.Location = new Point(1061, 113);
            lblId.Name = "lblId";
            lblId.Size = new Size(85, 24);
            lblId.TabIndex = 82;
            lblId.Text = "<none>";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Location = new Point(0, 529);
            panel1.Name = "panel1";
            panel1.Size = new Size(1643, 23);
            panel1.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(83, 4, 17);
            label1.Location = new Point(98, 573);
            label1.Name = "label1";
            label1.Size = new Size(286, 40);
            label1.TabIndex = 180;
            label1.Text = "Voos Agendados";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(83, 4, 17);
            label14.Location = new Point(98, 24);
            label14.Name = "label14";
            label14.Size = new Size(324, 40);
            label14.TabIndex = 179;
            label14.Text = "Agendar Novo Voo";
            // 
            // comboBoxModelos
            // 
            comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelos.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxModelos.FormattingEnabled = true;
            comboBoxModelos.Location = new Point(243, 130);
            comboBoxModelos.Name = "comboBoxModelos";
            comboBoxModelos.Size = new Size(461, 32);
            comboBoxModelos.TabIndex = 181;
            // 
            // ucVoos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(comboBoxModelos);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btnVenderBilhetes);
            Controls.Add(horaPartidaPicker);
            Controls.Add(duracaoVoo);
            Controls.Add(label5);
            Controls.Add(comboBoxOrigem);
            Controls.Add(comboBoxDestino);
            Controls.Add(gridViewVoosAgendados);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
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
            Controls.Add(btnAgendar);
            Controls.Add(lblId);
            Name = "ucVoos";
            Size = new Size(1643, 1026);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEconomico).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownExecutivo;
        private NumericUpDown numericUpDownEconomico;
        private Button btnVenderBilhetes;
        private DateTimePicker horaPartidaPicker;
        private DateTimePicker duracaoVoo;
        private Label label5;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private DataGridView gridViewVoosAgendados;
        private Button btnCancelar;
        private Button btnEditar;
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
        private Button btnAgendar;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Panel panel1;
        private Label label14;
        private Label label1;
        private ComboBox comboBoxModelos;
    }
}
