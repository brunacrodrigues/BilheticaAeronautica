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
            horaPartida = new DateTimePicker();
            duracaoVoo = new DateTimePicker();
            label5 = new Label();
            comboBoxModelos = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            dataPartida = new DateTimePicker();
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
            btnGuardar = new Button();
            label1 = new Label();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            SuspendLayout();
            // 
            // horaPartida
            // 
            horaPartida.CustomFormat = "HH:mm";
            horaPartida.Format = DateTimePickerFormat.Custom;
            horaPartida.Location = new Point(1112, 272);
            horaPartida.Name = "horaPartida";
            horaPartida.ShowUpDown = true;
            horaPartida.Size = new Size(85, 38);
            horaPartida.TabIndex = 99;
            horaPartida.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // duracaoVoo
            // 
            duracaoVoo.CustomFormat = "HH:mm";
            duracaoVoo.Format = DateTimePickerFormat.Custom;
            duracaoVoo.Location = new Point(796, 365);
            duracaoVoo.Name = "duracaoVoo";
            duracaoVoo.ShowUpDown = true;
            duracaoVoo.Size = new Size(85, 38);
            duracaoVoo.TabIndex = 98;
            duracaoVoo.Value = new DateTime(2025, 3, 18, 10, 55, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGoldenrod;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.Location = new Point(1075, 230);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 97;
            label5.Text = "Hora de partida";
            // 
            // comboBoxModelos
            // 
            comboBoxModelos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelos.FormattingEnabled = true;
            comboBoxModelos.ImeMode = ImeMode.On;
            comboBoxModelos.Location = new Point(242, 231);
            comboBoxModelos.Name = "comboBoxModelos";
            comboBoxModelos.Size = new Size(461, 35);
            comboBoxModelos.TabIndex = 96;
            comboBoxModelos.UseWaitCursor = true;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(242, 351);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(461, 35);
            comboBoxOrigem.TabIndex = 95;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(242, 447);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(461, 35);
            comboBoxDestino.TabIndex = 94;
            // 
            // dataPartida
            // 
            dataPartida.CustomFormat = "dd/MM/yyyy HH:mm";
            dataPartida.Font = new Font("Gadugi", 12F);
            dataPartida.Format = DateTimePickerFormat.Short;
            dataPartida.Location = new Point(796, 271);
            dataPartida.Name = "dataPartida";
            dataPartida.Size = new Size(254, 34);
            dataPartida.TabIndex = 93;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGoldenrod;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.Location = new Point(796, 328);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 92;
            label4.Text = "Duração";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGoldenrod;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.Location = new Point(796, 230);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 91;
            label3.Text = "Data de partida";
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.Font = new Font("Gadugi", 12F);
            lblDisponibilidade.Location = new Point(242, 271);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(184, 24);
            lblDisponibilidade.TabIndex = 90;
            lblDisponibilidade.Text = "Lugares disponíveis:";
            lblDisponibilidade.Visible = false;
            // 
            // lblLugaresDisponiveis
            // 
            lblLugaresDisponiveis.Font = new Font("Gadugi", 12F);
            lblLugaresDisponiveis.Location = new Point(428, 271);
            lblLugaresDisponiveis.Name = "lblLugaresDisponiveis";
            lblLugaresDisponiveis.Size = new Size(107, 24);
            lblLugaresDisponiveis.TabIndex = 89;
            lblLugaresDisponiveis.Text = "autoLabel2";
            lblLugaresDisponiveis.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(97, 213);
            button5.Name = "button5";
            button5.Size = new Size(129, 72);
            button5.TabIndex = 88;
            button5.Text = "Modelo Avião";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(97, 433);
            button4.Name = "button4";
            button4.Size = new Size(129, 49);
            button4.TabIndex = 87;
            button4.Text = "Destino";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(97, 340);
            button3.Name = "button3";
            button3.Size = new Size(129, 49);
            button3.TabIndex = 86;
            button3.Text = "Origem";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.Location = new Point(931, 142);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(95, 27);
            lblNumeroVoo.TabIndex = 85;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(796, 133);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 84;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(97, 133);
            button1.Name = "button1";
            button1.Size = new Size(129, 49);
            button1.TabIndex = 83;
            button1.Text = "Id";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGoldenrod;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(1049, 447);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(185, 46);
            btnGuardar.TabIndex = 82;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(82, 49);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 81;
            label1.Text = "Modificar Voo";
            // 
            // lblId
            // 
            lblId.Location = new Point(232, 145);
            lblId.Name = "lblId";
            lblId.Size = new Size(95, 27);
            lblId.TabIndex = 80;
            lblId.Text = "<none>";
            // 
            // FormEditarVoo
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 598);
            Controls.Add(horaPartida);
            Controls.Add(duracaoVoo);
            Controls.Add(label5);
            Controls.Add(comboBoxModelos);
            Controls.Add(comboBoxOrigem);
            Controls.Add(comboBoxDestino);
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
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(lblId);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormEditarVoo";
            Text = "FormEditarVoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker horaPartida;
        private DateTimePicker duracaoVoo;
        private Label label5;
        private ComboBox comboBoxModelos;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private DateTimePicker dataPartida;
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
        private Button btnGuardar;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
    }
}