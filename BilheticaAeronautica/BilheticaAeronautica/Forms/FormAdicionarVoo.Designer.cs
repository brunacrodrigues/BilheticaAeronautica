namespace BilheticaAeronautica.Forms
{
    partial class FormAdicionarVoo
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
            btnAgendar = new Button();
            label1 = new Label();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button1 = new Button();
            button2 = new Button();
            lblNumeroVoo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblLugaresDisponiveis = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblDisponibilidade = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            dataPartida = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnEditar = new Button();
            gridViewVoosAgendados = new DataGridView();
            comboBoxDestino = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxModelos = new ComboBox();
            label5 = new Label();
            duracaoVoo = new DateTimePicker();
            horaPartida = new DateTimePicker();
            btnVenderBilhetes = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).BeginInit();
            SuspendLayout();
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.DarkGoldenrod;
            btnAgendar.FlatAppearance.BorderSize = 0;
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = Color.Black;
            btnAgendar.Location = new Point(1064, 432);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(185, 46);
            btnAgendar.TabIndex = 36;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(97, 34);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 33;
            label1.Text = "Agendar Novo Voo";
            // 
            // lblId
            // 
            lblId.Location = new Point(247, 130);
            lblId.Name = "lblId";
            lblId.Size = new Size(95, 27);
            lblId.TabIndex = 28;
            lblId.Text = "<none>";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(112, 118);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 39;
            button1.Text = "Id";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(811, 118);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 40;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Location = new Point(946, 127);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(95, 27);
            lblNumeroVoo.TabIndex = 41;
            lblNumeroVoo.Text = "<none>";
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(112, 325);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 42;
            button3.Text = "Origem";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(112, 418);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 44;
            button4.Text = "Destino";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(112, 198);
            button5.Name = "button5";
            button5.Size = new Size(129, 72);
            button5.TabIndex = 46;
            button5.Text = "Modelo Avião";
            button5.UseVisualStyleBackColor = false;
            // 
            // lblLugaresDisponiveis
            // 
            lblLugaresDisponiveis.Font = new Font("Gadugi", 12F);
            lblLugaresDisponiveis.Location = new Point(443, 256);
            lblLugaresDisponiveis.Name = "lblLugaresDisponiveis";
            lblLugaresDisponiveis.Size = new Size(107, 24);
            lblLugaresDisponiveis.TabIndex = 48;
            lblLugaresDisponiveis.Text = "autoLabel2";
            lblLugaresDisponiveis.Visible = false;
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.Font = new Font("Gadugi", 12F);
            lblDisponibilidade.Location = new Point(257, 256);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(184, 24);
            lblDisponibilidade.TabIndex = 49;
            lblDisponibilidade.Text = "Lugares disponíveis:";
            lblDisponibilidade.Visible = false;
            // 
            // dataPartida
            // 
            dataPartida.CustomFormat = "dd/MM/yyyy HH:mm";
            dataPartida.Font = new Font("Gadugi", 12F);
            dataPartida.Format = DateTimePickerFormat.Short;
            dataPartida.Location = new Point(811, 256);
            dataPartida.Name = "dataPartida";
            dataPartida.Size = new Size(254, 34);
            dataPartida.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGoldenrod;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.Location = new Point(811, 313);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 51;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGoldenrod;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.Location = new Point(811, 215);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 50;
            label3.Text = "Data de partida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(112, 524);
            label2.Name = "label2";
            label2.Size = new Size(251, 36);
            label2.TabIndex = 63;
            label2.Text = "Voos Agendados";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1268, 945);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 63);
            btnCancelar.TabIndex = 65;
            btnCancelar.Text = "Cancelar Voo";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Black;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(1268, 859);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 60);
            btnEditar.TabIndex = 64;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // gridViewVoosAgendados
            // 
            gridViewVoosAgendados.AllowUserToAddRows = false;
            gridViewVoosAgendados.AllowUserToDeleteRows = false;
            gridViewVoosAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewVoosAgendados.Location = new Point(112, 576);
            gridViewVoosAgendados.Name = "gridViewVoosAgendados";
            gridViewVoosAgendados.RowHeadersWidth = 51;
            gridViewVoosAgendados.Size = new Size(1137, 432);
            gridViewVoosAgendados.TabIndex = 67;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(257, 432);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(461, 35);
            comboBoxDestino.TabIndex = 68;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(257, 336);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(461, 35);
            comboBoxOrigem.TabIndex = 69;
            // 
            // comboBoxModelos
            // 
            comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelos.FormattingEnabled = true;
            comboBoxModelos.ImeMode = ImeMode.On;
            comboBoxModelos.Location = new Point(257, 216);
            comboBoxModelos.Name = "comboBoxModelos";
            comboBoxModelos.Size = new Size(461, 35);
            comboBoxModelos.TabIndex = 70;
            comboBoxModelos.UseWaitCursor = true;
            comboBoxModelos.SelectedIndexChanged += comboBoxModelos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGoldenrod;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.Location = new Point(1090, 215);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 72;
            label5.Text = "Hora de partida";
            // 
            // duracaoVoo
            // 
            duracaoVoo.CustomFormat = "HH:mm";
            duracaoVoo.Format = DateTimePickerFormat.Custom;
            duracaoVoo.Location = new Point(811, 350);
            duracaoVoo.Name = "duracaoVoo";
            duracaoVoo.ShowUpDown = true;
            duracaoVoo.Size = new Size(85, 38);
            duracaoVoo.TabIndex = 78;
            duracaoVoo.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // horaPartida
            // 
            horaPartida.CustomFormat = "HH:mm";
            horaPartida.Format = DateTimePickerFormat.Custom;
            horaPartida.Location = new Point(1127, 257);
            horaPartida.Name = "horaPartida";
            horaPartida.ShowUpDown = true;
            horaPartida.Size = new Size(85, 38);
            horaPartida.TabIndex = 79;
            horaPartida.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // btnVenderBilhetes
            // 
            btnVenderBilhetes.BackColor = Color.DarkGoldenrod;
            btnVenderBilhetes.FlatAppearance.BorderSize = 0;
            btnVenderBilhetes.FlatStyle = FlatStyle.Flat;
            btnVenderBilhetes.Location = new Point(1268, 576);
            btnVenderBilhetes.Name = "btnVenderBilhetes";
            btnVenderBilhetes.Size = new Size(158, 74);
            btnVenderBilhetes.TabIndex = 80;
            btnVenderBilhetes.Text = "Vender Bilhetes";
            btnVenderBilhetes.UseVisualStyleBackColor = false;
            btnVenderBilhetes.Click += btnVenderBilhetes_Click;
            // 
            // FormAdicionarVoo
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 1020);
            Controls.Add(btnVenderBilhetes);
            Controls.Add(horaPartida);
            Controls.Add(duracaoVoo);
            Controls.Add(label5);
            Controls.Add(comboBoxModelos);
            Controls.Add(comboBoxOrigem);
            Controls.Add(comboBoxDestino);
            Controls.Add(gridViewVoosAgendados);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(label2);
            Controls.Add(dataPartida);
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
            Controls.Add(label1);
            Controls.Add(lblId);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAdicionarVoo";
            Text = "FormAdicionarVoo";
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgendar;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Button button1;
        private Button button2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumeroVoo;
        private Button button3;
        private Button button4;
        private Button button5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLugaresDisponiveis;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblDisponibilidade;
        private DateTimePicker dataPartida;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancelar;
        private Button btnEditar;
        private DataGridView gridViewVoosAgendados;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxModelos;
        private Label label5;
        private DateTimePicker duracaoVoo;
        private DateTimePicker horaPartida;
        private Button btnVenderBilhetes;
    }
}