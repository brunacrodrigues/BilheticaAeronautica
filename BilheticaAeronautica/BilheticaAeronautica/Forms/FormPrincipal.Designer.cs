namespace BilheticaAeronautica
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            btnVoos = new Button();
            btnAvioes = new Button();
            btnAeroportos = new Button();
            btnBilhetes = new Button();
            btnClientes = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnHome = new Button();
            btnSobre = new Button();
            panelSide = new Panel();
            panel4 = new Panel();
            lblHoras = new Label();
            button2 = new Button();
            panelControls = new Panel();
            panelHome = new Panel();
            panel6 = new Panel();
            label14 = new Label();
            btnTrocar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            datePickerDataPartida = new DateTimePicker();
            datePickerDataChegada = new DateTimePicker();
            btnPesquisar = new Button();
            label5 = new Label();
            label6 = new Label();
            totalAdultos = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            label7 = new Label();
            totalCriancas = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            label8 = new Label();
            TotalBebes = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            comboBoxDestino = new ComboBox();
            comboBoxOrigem = new ComboBox();
            comboBoxClasse = new ComboBox();
            panel1 = new Panel();
            checkBoxIdaEVolta = new CheckBox();
            checkBoxIda = new CheckBox();
            gridViewVoosAgendados = new DataGridView();
            label13 = new Label();
            comboBoxOrdenar = new ComboBox();
            timerHora = new System.Windows.Forms.Timer(components);
            dragControl1 = new DragControl();
            dragControl2 = new DragControl();
            dragControl3 = new DragControl();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panelHome.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)totalAdultos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalCriancas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalBebes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).BeginInit();
            SuspendLayout();
            // 
            // btnVoos
            // 
            btnVoos.BackColor = Color.FromArgb(83, 4, 17);
            btnVoos.FlatAppearance.BorderSize = 0;
            btnVoos.FlatStyle = FlatStyle.Flat;
            btnVoos.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnVoos.ForeColor = Color.Cornsilk;
            btnVoos.Image = Properties.Resources.icons8_airplane_take_off_48;
            btnVoos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoos.Location = new Point(16, 220);
            btnVoos.Name = "btnVoos";
            btnVoos.Size = new Size(270, 77);
            btnVoos.TabIndex = 0;
            btnVoos.Text = "Voos";
            btnVoos.UseVisualStyleBackColor = false;
            btnVoos.Click += btnVoos_Click;
            // 
            // btnAvioes
            // 
            btnAvioes.BackColor = Color.FromArgb(83, 4, 17);
            btnAvioes.FlatAppearance.BorderSize = 0;
            btnAvioes.FlatStyle = FlatStyle.Flat;
            btnAvioes.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnAvioes.ForeColor = Color.Cornsilk;
            btnAvioes.Image = Properties.Resources.icons8_plane_40__1_;
            btnAvioes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAvioes.Location = new Point(18, 298);
            btnAvioes.Name = "btnAvioes";
            btnAvioes.Size = new Size(268, 77);
            btnAvioes.TabIndex = 1;
            btnAvioes.Text = "   Aviões";
            btnAvioes.UseVisualStyleBackColor = false;
            btnAvioes.Click += btnAvioes_Click;
            // 
            // btnAeroportos
            // 
            btnAeroportos.BackColor = Color.FromArgb(83, 4, 17);
            btnAeroportos.FlatAppearance.BorderSize = 0;
            btnAeroportos.FlatStyle = FlatStyle.Flat;
            btnAeroportos.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnAeroportos.ForeColor = Color.Cornsilk;
            btnAeroportos.Image = Properties.Resources.icons8_location_48__1_;
            btnAeroportos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAeroportos.Location = new Point(16, 376);
            btnAeroportos.Name = "btnAeroportos";
            btnAeroportos.Size = new Size(270, 77);
            btnAeroportos.TabIndex = 2;
            btnAeroportos.Text = "          Aeroportos";
            btnAeroportos.UseVisualStyleBackColor = false;
            btnAeroportos.Click += btnAeroportos_Click;
            // 
            // btnBilhetes
            // 
            btnBilhetes.BackColor = Color.FromArgb(83, 4, 17);
            btnBilhetes.FlatAppearance.BorderSize = 0;
            btnBilhetes.FlatStyle = FlatStyle.Flat;
            btnBilhetes.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnBilhetes.ForeColor = Color.Cornsilk;
            btnBilhetes.Image = Properties.Resources.icons8_tickets_48__1_;
            btnBilhetes.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilhetes.Location = new Point(16, 454);
            btnBilhetes.Name = "btnBilhetes";
            btnBilhetes.Size = new Size(270, 77);
            btnBilhetes.TabIndex = 3;
            btnBilhetes.Text = "      Bilhetes";
            btnBilhetes.UseVisualStyleBackColor = false;
            btnBilhetes.Click += btnBilhetes_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(83, 4, 17);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnClientes.ForeColor = Color.Cornsilk;
            btnClientes.Image = Properties.Resources.icons8_passenger_48__2_;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(16, 532);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(270, 77);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "      Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 142);
            panel2.TabIndex = 75;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(83, 4, 17);
            pictureBox1.Image = Properties.Resources._22_removebg_preview3;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Controls.Add(btnHome);
            panel3.Controls.Add(btnSobre);
            panel3.Controls.Add(panelSide);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnVoos);
            panel3.Controls.Add(btnAvioes);
            panel3.Controls.Add(btnAeroportos);
            panel3.Controls.Add(btnBilhetes);
            panel3.Controls.Add(btnClientes);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 1083);
            panel3.TabIndex = 76;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(83, 4, 17);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.Cornsilk;
            btnHome.Image = Properties.Resources.icons8_search_40__1_;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(18, 142);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(268, 77);
            btnHome.TabIndex = 81;
            btnHome.Text = "      Pesquisar";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnSobre
            // 
            btnSobre.BackColor = Color.FromArgb(236, 175, 74);
            btnSobre.Dock = DockStyle.Bottom;
            btnSobre.FlatAppearance.BorderSize = 0;
            btnSobre.FlatStyle = FlatStyle.Flat;
            btnSobre.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSobre.ForeColor = Color.FromArgb(83, 4, 17);
            btnSobre.Image = Properties.Resources.icons8_about_48__1_;
            btnSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnSobre.Location = new Point(0, 1006);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(286, 77);
            btnSobre.TabIndex = 80;
            btnSobre.Text = "Sobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += btnSobre_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.Cornsilk;
            panelSide.Location = new Point(0, 142);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(12, 77);
            panelSide.TabIndex = 79;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Controls.Add(lblHoras);
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(286, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1643, 57);
            panel4.TabIndex = 77;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoras.ForeColor = Color.LightYellow;
            lblHoras.Location = new Point(1379, 15);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(110, 24);
            lblHoras.TabIndex = 0;
            lblHoras.Text = "HH:MM:SS";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(236, 175, 74);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_shutdown_52;
            button2.Location = new Point(1549, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 57);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelControls
            // 
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(286, 57);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1643, 1026);
            panelControls.TabIndex = 79;
            panelControls.Visible = false;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.White;
            panelHome.Controls.Add(panel6);
            panelHome.Controls.Add(panel1);
            panelHome.Controls.Add(gridViewVoosAgendados);
            panelHome.Controls.Add(label13);
            panelHome.Controls.Add(comboBoxOrdenar);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelHome.ForeColor = Color.FromArgb(83, 4, 17);
            panelHome.Location = new Point(286, 57);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1643, 1026);
            panelHome.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label14);
            panel6.Controls.Add(btnTrocar);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(datePickerDataPartida);
            panel6.Controls.Add(datePickerDataChegada);
            panel6.Controls.Add(btnPesquisar);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(totalAdultos);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(totalCriancas);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(TotalBebes);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(comboBoxDestino);
            panel6.Controls.Add(comboBoxOrigem);
            panel6.Controls.Add(comboBoxClasse);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(776, 949);
            panel6.TabIndex = 180;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(83, 4, 17);
            label14.Location = new Point(83, 36);
            label14.Name = "label14";
            label14.Size = new Size(259, 40);
            label14.TabIndex = 178;
            label14.Text = "Pesquisar Voos";
            // 
            // btnTrocar
            // 
            btnTrocar.BackColor = Color.FromArgb(83, 4, 17);
            btnTrocar.FlatAppearance.BorderSize = 0;
            btnTrocar.FlatStyle = FlatStyle.Flat;
            btnTrocar.Image = Properties.Resources.icons8_change_40;
            btnTrocar.Location = new Point(666, 199);
            btnTrocar.Margin = new Padding(5, 4, 5, 4);
            btnTrocar.Name = "btnTrocar";
            btnTrocar.Size = new Size(61, 57);
            btnTrocar.TabIndex = 154;
            btnTrocar.UseVisualStyleBackColor = false;
            btnTrocar.Click += btnTrocar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(83, 4, 17);
            label1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(96, 131);
            label1.Name = "label1";
            label1.Size = new Size(92, 27);
            label1.TabIndex = 155;
            label1.Text = "Origem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(83, 4, 17);
            label2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(96, 229);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 156;
            label2.Text = "Destino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(83, 4, 17);
            label3.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(96, 359);
            label3.Name = "label3";
            label3.Size = new Size(177, 27);
            label3.TabIndex = 157;
            label3.Text = "Data de partida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(83, 4, 17);
            label4.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(439, 359);
            label4.Name = "label4";
            label4.Size = new Size(189, 27);
            label4.TabIndex = 158;
            label4.Text = "Data de chegada";
            // 
            // datePickerDataPartida
            // 
            datePickerDataPartida.CalendarForeColor = Color.FromArgb(83, 4, 17);
            datePickerDataPartida.Location = new Point(96, 399);
            datePickerDataPartida.Name = "datePickerDataPartida";
            datePickerDataPartida.Size = new Size(288, 34);
            datePickerDataPartida.TabIndex = 159;
            // 
            // datePickerDataChegada
            // 
            datePickerDataChegada.CalendarForeColor = Color.FromArgb(83, 4, 17);
            datePickerDataChegada.Location = new Point(439, 399);
            datePickerDataChegada.Name = "datePickerDataChegada";
            datePickerDataChegada.Size = new Size(288, 34);
            datePickerDataChegada.TabIndex = 160;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(236, 175, 74);
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.FromArgb(83, 4, 17);
            btnPesquisar.Location = new Point(98, 895);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(629, 48);
            btnPesquisar.TabIndex = 161;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(83, 4, 17);
            label5.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.Cornsilk;
            label5.Location = new Point(96, 500);
            label5.Name = "label5";
            label5.Size = new Size(262, 27);
            label5.TabIndex = 163;
            label5.Text = "Número de Passageiros";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cornsilk;
            label6.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(83, 4, 17);
            label6.Location = new Point(98, 561);
            label6.Name = "label6";
            label6.Size = new Size(83, 24);
            label6.TabIndex = 164;
            label6.Text = "Adultos";
            // 
            // totalAdultos
            // 
            totalAdultos.BeforeTouchSize = new Size(81, 34);
            totalAdultos.Location = new Point(202, 557);
            totalAdultos.Name = "totalAdultos";
            totalAdultos.Size = new Size(81, 34);
            totalAdultos.TabIndex = 165;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cornsilk;
            label7.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(83, 4, 17);
            label7.Location = new Point(98, 656);
            label7.Name = "label7";
            label7.Size = new Size(89, 24);
            label7.TabIndex = 166;
            label7.Text = "Crianças";
            // 
            // totalCriancas
            // 
            totalCriancas.BeforeTouchSize = new Size(81, 34);
            totalCriancas.Location = new Point(202, 652);
            totalCriancas.Name = "totalCriancas";
            totalCriancas.Size = new Size(81, 34);
            totalCriancas.TabIndex = 167;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Cornsilk;
            label8.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(83, 4, 17);
            label8.Location = new Point(98, 748);
            label8.Name = "label8";
            label8.Size = new Size(66, 24);
            label8.TabIndex = 168;
            label8.Text = "Bebés";
            // 
            // TotalBebes
            // 
            TotalBebes.BeforeTouchSize = new Size(81, 34);
            TotalBebes.Location = new Point(202, 742);
            TotalBebes.Name = "TotalBebes";
            TotalBebes.Size = new Size(81, 34);
            TotalBebes.TabIndex = 169;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(83, 4, 17);
            label9.Location = new Point(96, 598);
            label9.Name = "label9";
            label9.Size = new Size(132, 20);
            label9.TabIndex = 170;
            label9.Text = "Mais de 12 anos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(83, 4, 17);
            label10.Location = new Point(96, 695);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 171;
            label10.Text = "2 a 11 anos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Gadugi", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(83, 4, 17);
            label12.Location = new Point(96, 783);
            label12.Name = "label12";
            label12.Size = new Size(180, 20);
            label12.TabIndex = 172;
            label12.Text = "Idade inferior a 2 anos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(83, 4, 17);
            label11.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.Cornsilk;
            label11.Location = new Point(439, 500);
            label11.Name = "label11";
            label11.Size = new Size(77, 27);
            label11.TabIndex = 174;
            label11.Text = "Classe";
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.BackColor = Color.White;
            comboBoxDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(96, 258);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(532, 32);
            comboBoxDestino.TabIndex = 175;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.BackColor = Color.White;
            comboBoxOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrigem.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxOrigem.ForeColor = Color.Black;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(96, 161);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(532, 32);
            comboBoxOrigem.TabIndex = 176;
            // 
            // comboBoxClasse
            // 
            comboBoxClasse.BackColor = Color.White;
            comboBoxClasse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClasse.FormattingEnabled = true;
            comboBoxClasse.Location = new Point(441, 553);
            comboBoxClasse.Name = "comboBoxClasse";
            comboBoxClasse.Size = new Size(286, 32);
            comboBoxClasse.TabIndex = 177;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 4, 17);
            panel1.Controls.Add(checkBoxIdaEVolta);
            panel1.Controls.Add(checkBoxIda);
            panel1.Location = new Point(794, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 81);
            panel1.TabIndex = 173;
            // 
            // checkBoxIdaEVolta
            // 
            checkBoxIdaEVolta.AutoSize = true;
            checkBoxIdaEVolta.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            checkBoxIdaEVolta.ForeColor = Color.Cornsilk;
            checkBoxIdaEVolta.Location = new Point(22, 27);
            checkBoxIdaEVolta.Name = "checkBoxIdaEVolta";
            checkBoxIdaEVolta.Size = new Size(145, 31);
            checkBoxIdaEVolta.TabIndex = 5;
            checkBoxIdaEVolta.Text = "Ida e volta";
            checkBoxIdaEVolta.UseVisualStyleBackColor = true;
            checkBoxIdaEVolta.Click += checkBoxIdaEVolta_Click;
            // 
            // checkBoxIda
            // 
            checkBoxIda.AutoSize = true;
            checkBoxIda.Font = new Font("Gadugi", 13.8F, FontStyle.Bold);
            checkBoxIda.ForeColor = Color.Cornsilk;
            checkBoxIda.Location = new Point(204, 27);
            checkBoxIda.Name = "checkBoxIda";
            checkBoxIda.Size = new Size(100, 31);
            checkBoxIda.TabIndex = 6;
            checkBoxIda.Text = "Só ida";
            checkBoxIda.UseVisualStyleBackColor = true;
            checkBoxIda.Click += checkBoxIda_Click;
            // 
            // gridViewVoosAgendados
            // 
            gridViewVoosAgendados.AllowUserToAddRows = false;
            gridViewVoosAgendados.AllowUserToDeleteRows = false;
            gridViewVoosAgendados.AllowUserToResizeColumns = false;
            gridViewVoosAgendados.AllowUserToResizeRows = false;
            gridViewVoosAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewVoosAgendados.BackgroundColor = Color.White;
            gridViewVoosAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewVoosAgendados.Location = new Point(794, 199);
            gridViewVoosAgendados.Name = "gridViewVoosAgendados";
            gridViewVoosAgendados.ReadOnly = true;
            gridViewVoosAgendados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewVoosAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewVoosAgendados.Size = new Size(775, 750);
            gridViewVoosAgendados.TabIndex = 162;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(83, 4, 17);
            label13.Location = new Point(1409, 134);
            label13.Name = "label13";
            label13.Size = new Size(130, 24);
            label13.TabIndex = 179;
            label13.Text = "Ordenar Por:";
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.BackColor = Color.White;
            comboBoxOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Location = new Point(1409, 161);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(160, 32);
            comboBoxOrdenar.TabIndex = 178;
            comboBoxOrdenar.SelectedIndexChanged += comboBoxOrdenar_SelectedIndexChanged;
            // 
            // timerHora
            // 
            timerHora.Tick += timerHora_Tick;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = this;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = panel4;
            // 
            // dragControl3
            // 
            dragControl3.SelectedControl = panel3;
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1929, 1083);
            Controls.Add(panelHome);
            Controls.Add(panelControls);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)totalAdultos).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalCriancas).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalBebes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewVoosAgendados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoos;
        private Button btnAvioes;
        private Button btnAeroportos;
        private Button btnBilhetes;
        private Button btnClientes;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelSide;
        private Button btnSobre;
        private Panel panelControls;
        private Button button2;
        private Button btnHome;
        private Panel panelHome;
        private Label label13;
        private ComboBox comboBoxOrdenar;
        private ComboBox comboBoxClasse;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private Label label11;
        private Panel panel1;
        private CheckBox checkBoxIdaEVolta;
        private Label label12;
        private Label label10;
        private Label label9;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt TotalBebes;
        private Label label8;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt totalCriancas;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt totalAdultos;
        private Label label6;
        private Label label5;
        private DataGridView gridViewVoosAgendados;
        private Button btnPesquisar;
        private DateTimePicker datePickerDataChegada;
        private DateTimePicker datePickerDataPartida;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTrocar;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label lblHoras;
        private System.Windows.Forms.Timer timerHora;
        private Label label14;
        private CheckBox checkBoxIda;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private DragControl dragControl3;
    }
}