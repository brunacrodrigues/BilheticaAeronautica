namespace BilheticaAeronautica.Forms
{
    partial class FormVenderBilhetes
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
            checkedListBoxLugares = new CheckedListBox();
            comboBoxTipoLugar = new ComboBox();
            label1 = new Label();
            lblNumeroVoo = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button2 = new Button();
            lblOrigemDestino = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnCheckout = new Button();
            gridViewBilhetesAComprar = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtTelefonePassageiro = new TextBox();
            label4 = new Label();
            txtEmailPassageiro = new TextBox();
            label3 = new Label();
            txtPassaportePassageiro = new TextBox();
            label2 = new Label();
            txtNomePassageiro = new TextBox();
            btnAdicionarPassageiro = new Button();
            btnRemover = new Button();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            comboBoxClientesExistentes = new ComboBox();
            linkLabelRegistarNovo = new LinkLabel();
            label6 = new Label();
            btnCancelarCompra = new Button();
            btnFechar = new Button();
            panel1 = new Panel();
            dragControl1 = new DragControl();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dragControl2 = new DragControl();
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesAComprar).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBoxLugares
            // 
            checkedListBoxLugares.CheckOnClick = true;
            checkedListBoxLugares.FormattingEnabled = true;
            checkedListBoxLugares.Location = new Point(62, 283);
            checkedListBoxLugares.Margin = new Padding(5, 4, 5, 4);
            checkedListBoxLugares.Name = "checkedListBoxLugares";
            checkedListBoxLugares.Size = new Size(213, 532);
            checkedListBoxLugares.TabIndex = 1;
            checkedListBoxLugares.ItemCheck += checkedListBoxLugares_ItemCheck;
            // 
            // comboBoxTipoLugar
            // 
            comboBoxTipoLugar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipoLugar.Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipoLugar.FormattingEnabled = true;
            comboBoxTipoLugar.Location = new Point(62, 220);
            comboBoxTipoLugar.Margin = new Padding(5, 4, 5, 4);
            comboBoxTipoLugar.Name = "comboBoxTipoLugar";
            comboBoxTipoLugar.Size = new Size(213, 35);
            comboBoxTipoLugar.TabIndex = 2;
            comboBoxTipoLugar.SelectedIndexChanged += comboBoxTipoLugar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(83, 4, 17);
            label1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 189);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Lugar";
            // 
            // lblNumeroVoo
            // 
            lblNumeroVoo.ForeColor = Color.FromArgb(83, 14, 7);
            lblNumeroVoo.Location = new Point(197, 87);
            lblNumeroVoo.Name = "lblNumeroVoo";
            lblNumeroVoo.Size = new Size(95, 27);
            lblNumeroVoo.TabIndex = 45;
            lblNumeroVoo.Text = "<none>";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(83, 4, 17);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(62, 78);
            button2.Name = "button2";
            button2.Size = new Size(129, 49);
            button2.TabIndex = 44;
            button2.Text = "Nº de Voo";
            button2.UseVisualStyleBackColor = false;
            // 
            // lblOrigemDestino
            // 
            lblOrigemDestino.ForeColor = Color.FromArgb(83, 4, 17);
            lblOrigemDestino.Location = new Point(928, 87);
            lblOrigemDestino.Name = "lblOrigemDestino";
            lblOrigemDestino.Size = new Size(95, 27);
            lblOrigemDestino.TabIndex = 46;
            lblOrigemDestino.Text = "<none>";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(236, 175, 74);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.FromArgb(83, 14, 7);
            btnCheckout.Image = Properties.Resources.icons8_confirm_50__1_;
            btnCheckout.Location = new Point(918, 758);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(627, 62);
            btnCheckout.TabIndex = 81;
            btnCheckout.Text = "             Confirmar Lugares";
            btnCheckout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // gridViewBilhetesAComprar
            // 
            gridViewBilhetesAComprar.AllowUserToAddRows = false;
            gridViewBilhetesAComprar.AllowUserToDeleteRows = false;
            gridViewBilhetesAComprar.AllowUserToResizeColumns = false;
            gridViewBilhetesAComprar.AllowUserToResizeRows = false;
            gridViewBilhetesAComprar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewBilhetesAComprar.BackgroundColor = Color.White;
            gridViewBilhetesAComprar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewBilhetesAComprar.GridColor = Color.White;
            gridViewBilhetesAComprar.Location = new Point(918, 220);
            gridViewBilhetesAComprar.Name = "gridViewBilhetesAComprar";
            gridViewBilhetesAComprar.ReadOnly = true;
            gridViewBilhetesAComprar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewBilhetesAComprar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewBilhetesAComprar.Size = new Size(627, 532);
            gridViewBilhetesAComprar.TabIndex = 82;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefonePassageiro);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmailPassageiro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassaportePassageiro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNomePassageiro);
            groupBox1.Enabled = false;
            groupBox1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(83, 14, 7);
            groupBox1.Location = new Point(386, 283);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 469);
            groupBox1.TabIndex = 83;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Passageiro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(83, 4, 17);
            label5.Location = new Point(15, 323);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txtTelefonePassageiro
            // 
            txtTelefonePassageiro.Font = new Font("Gadugi", 12F);
            txtTelefonePassageiro.Location = new Point(19, 353);
            txtTelefonePassageiro.Name = "txtTelefonePassageiro";
            txtTelefonePassageiro.Size = new Size(372, 34);
            txtTelefonePassageiro.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(83, 4, 17);
            label4.Location = new Point(15, 231);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmailPassageiro
            // 
            txtEmailPassageiro.Font = new Font("Gadugi", 12F);
            txtEmailPassageiro.Location = new Point(19, 261);
            txtEmailPassageiro.Name = "txtEmailPassageiro";
            txtEmailPassageiro.Size = new Size(372, 34);
            txtEmailPassageiro.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(83, 4, 17);
            label3.Location = new Point(15, 139);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 6;
            label3.Text = "Passaporte";
            // 
            // txtPassaportePassageiro
            // 
            txtPassaportePassageiro.Font = new Font("Gadugi", 12F);
            txtPassaportePassageiro.Location = new Point(19, 169);
            txtPassaportePassageiro.Name = "txtPassaportePassageiro";
            txtPassaportePassageiro.Size = new Size(372, 34);
            txtPassaportePassageiro.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(14, 49);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 4;
            label2.Text = "Nome Completo";
            // 
            // txtNomePassageiro
            // 
            txtNomePassageiro.Font = new Font("Gadugi", 12F);
            txtNomePassageiro.Location = new Point(19, 79);
            txtNomePassageiro.Name = "txtNomePassageiro";
            txtNomePassageiro.Size = new Size(372, 34);
            txtNomePassageiro.TabIndex = 0;
            // 
            // btnAdicionarPassageiro
            // 
            btnAdicionarPassageiro.BackColor = Color.FromArgb(83, 14, 7);
            btnAdicionarPassageiro.FlatAppearance.BorderSize = 0;
            btnAdicionarPassageiro.FlatStyle = FlatStyle.Flat;
            btnAdicionarPassageiro.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarPassageiro.ForeColor = Color.White;
            btnAdicionarPassageiro.Image = Properties.Resources.icons8_add_40;
            btnAdicionarPassageiro.Location = new Point(386, 758);
            btnAdicionarPassageiro.Name = "btnAdicionarPassageiro";
            btnAdicionarPassageiro.Size = new Size(449, 62);
            btnAdicionarPassageiro.TabIndex = 82;
            btnAdicionarPassageiro.Text = "     Adicionar Passageiro";
            btnAdicionarPassageiro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarPassageiro.UseVisualStyleBackColor = false;
            btnAdicionarPassageiro.Click += btnAdicionarPassageiro_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Black;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Image = Properties.Resources.icons8_flight_seat_40;
            btnRemover.Location = new Point(1551, 221);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(208, 69);
            btnRemover.TabIndex = 85;
            btnRemover.Text = "  Remover do Carrinho";
            btnRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // autoLabel1
            // 
            autoLabel1.BackColor = Color.FromArgb(83, 4, 17);
            autoLabel1.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.White;
            autoLabel1.Location = new Point(386, 189);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(204, 27);
            autoLabel1.TabIndex = 86;
            autoLabel1.Text = "Selecionar Cliente";
            // 
            // comboBoxClientesExistentes
            // 
            comboBoxClientesExistentes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientesExistentes.FormattingEnabled = true;
            comboBoxClientesExistentes.Location = new Point(386, 220);
            comboBoxClientesExistentes.Name = "comboBoxClientesExistentes";
            comboBoxClientesExistentes.Size = new Size(449, 35);
            comboBoxClientesExistentes.TabIndex = 87;
            comboBoxClientesExistentes.SelectedIndexChanged += comboBoxClientesExistentes_SelectedIndexChanged;
            // 
            // linkLabelRegistarNovo
            // 
            linkLabelRegistarNovo.ActiveLinkColor = Color.Black;
            linkLabelRegistarNovo.AutoSize = true;
            linkLabelRegistarNovo.BackColor = Color.FromArgb(236, 175, 74);
            linkLabelRegistarNovo.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelRegistarNovo.LinkColor = Color.FromArgb(83, 4, 17);
            linkLabelRegistarNovo.Location = new Point(700, 189);
            linkLabelRegistarNovo.Name = "linkLabelRegistarNovo";
            linkLabelRegistarNovo.Size = new Size(135, 24);
            linkLabelRegistarNovo.TabIndex = 88;
            linkLabelRegistarNovo.TabStop = true;
            linkLabelRegistarNovo.Text = "Registar Novo";
            linkLabelRegistarNovo.LinkClicked += linkLabelRegistarNovo_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(83, 4, 17);
            label6.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(918, 186);
            label6.Name = "label6";
            label6.Size = new Size(105, 27);
            label6.TabIndex = 89;
            label6.Text = "Carrinho";
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.BackColor = Color.Firebrick;
            btnCancelarCompra.FlatAppearance.BorderSize = 0;
            btnCancelarCompra.FlatStyle = FlatStyle.Flat;
            btnCancelarCompra.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarCompra.ForeColor = Color.White;
            btnCancelarCompra.Image = Properties.Resources.icons8_cancel_30;
            btnCancelarCompra.Location = new Point(1551, 296);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(208, 70);
            btnCancelarCompra.TabIndex = 90;
            btnCancelarCompra.Text = "   Cancelar    Compra";
            btnCancelarCompra.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarCompra.UseVisualStyleBackColor = false;
            btnCancelarCompra.Click += btnCancelarCompra_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Firebrick;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.icons8_close_50;
            btnFechar.Location = new Point(1728, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 54);
            btnFechar.TabIndex = 91;
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 14, 7);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1809, 55);
            panel1.TabIndex = 92;
            // 
            // dragControl1
            // 
            dragControl1.SelectedControl = panel1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(83, 4, 17);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 921);
            panel2.Name = "panel2";
            panel2.Size = new Size(1809, 5);
            panel2.TabIndex = 93;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(83, 4, 17);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 866);
            panel3.TabIndex = 94;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(83, 4, 17);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1804, 55);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 866);
            panel4.TabIndex = 95;
            // 
            // dragControl2
            // 
            dragControl2.SelectedControl = this;
            // 
            // FormVenderBilhetes
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1809, 926);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnAdicionarPassageiro);
            Controls.Add(panel1);
            Controls.Add(btnCancelarCompra);
            Controls.Add(label6);
            Controls.Add(linkLabelRegistarNovo);
            Controls.Add(comboBoxClientesExistentes);
            Controls.Add(autoLabel1);
            Controls.Add(btnRemover);
            Controls.Add(groupBox1);
            Controls.Add(gridViewBilhetesAComprar);
            Controls.Add(btnCheckout);
            Controls.Add(lblOrigemDestino);
            Controls.Add(lblNumeroVoo);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipoLugar);
            Controls.Add(checkedListBoxLugares);
            Font = new Font("Gadugi", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormVenderBilhetes";
            Text = "FormVenderBilhetes";
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesAComprar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxLugares;
        private ComboBox comboBoxTipoLugar;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblNumeroVoo;
        private Button button2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblOrigemDestino;
        private Button btnCheckout;
        private DataGridView gridViewBilhetesAComprar;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtNomePassageiro;
        private Label label3;
        private TextBox txtPassaportePassageiro;
        private Label label5;
        private TextBox txtTelefonePassageiro;
        private Label label4;
        private TextBox txtEmailPassageiro;
        private Button btnAdicionarPassageiro;
        private Button btnRemover;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private ComboBox comboBoxClientesExistentes;
        private LinkLabel linkLabelRegistarNovo;
        private Label label6;
        private Button btnCancelarCompra;
        private Button btnFechar;
        private Panel panel1;
        private DragControl dragControl1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private DragControl dragControl2;
    }
}