namespace BilheticaAeronautica.UserControls
{
    partial class UCBilhetes
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
            btnAlterarLugar = new Button();
            gridViewBilhetesVendidos = new DataGridView();
            btnVenderBilhetes = new Button();
            groupBox2 = new GroupBox();
            comboBoxVoos = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnCancelarBilhete = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesVendidos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAlterarLugar
            // 
            btnAlterarLugar.BackColor = Color.Black;
            btnAlterarLugar.FlatAppearance.BorderSize = 0;
            btnAlterarLugar.FlatStyle = FlatStyle.Flat;
            btnAlterarLugar.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnAlterarLugar.ForeColor = Color.White;
            btnAlterarLugar.Image = Properties.Resources.icons8_flight_seat_40;
            btnAlterarLugar.Location = new Point(1327, 857);
            btnAlterarLugar.Margin = new Padding(4);
            btnAlterarLugar.Name = "btnAlterarLugar";
            btnAlterarLugar.Size = new Size(214, 63);
            btnAlterarLugar.TabIndex = 94;
            btnAlterarLugar.Text = "  Alterar Lugar";
            btnAlterarLugar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterarLugar.UseVisualStyleBackColor = false;
            btnAlterarLugar.Click += btnAlterarLugar_Click;
            // 
            // gridViewBilhetesVendidos
            // 
            gridViewBilhetesVendidos.AllowUserToAddRows = false;
            gridViewBilhetesVendidos.AllowUserToDeleteRows = false;
            gridViewBilhetesVendidos.AllowUserToResizeColumns = false;
            gridViewBilhetesVendidos.AllowUserToResizeRows = false;
            gridViewBilhetesVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewBilhetesVendidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewBilhetesVendidos.BackgroundColor = Color.White;
            gridViewBilhetesVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewBilhetesVendidos.Location = new Point(103, 479);
            gridViewBilhetesVendidos.Margin = new Padding(4);
            gridViewBilhetesVendidos.MultiSelect = false;
            gridViewBilhetesVendidos.Name = "gridViewBilhetesVendidos";
            gridViewBilhetesVendidos.ReadOnly = true;
            gridViewBilhetesVendidos.RowHeadersVisible = false;
            gridViewBilhetesVendidos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewBilhetesVendidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewBilhetesVendidos.Size = new Size(1216, 511);
            gridViewBilhetesVendidos.TabIndex = 93;
            // 
            // btnVenderBilhetes
            // 
            btnVenderBilhetes.BackColor = Color.FromArgb(236, 175, 74);
            btnVenderBilhetes.FlatAppearance.BorderSize = 0;
            btnVenderBilhetes.FlatStyle = FlatStyle.Flat;
            btnVenderBilhetes.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVenderBilhetes.ForeColor = Color.FromArgb(83, 4, 13);
            btnVenderBilhetes.Image = Properties.Resources.icons8_tickets_50__1_;
            btnVenderBilhetes.Location = new Point(414, 282);
            btnVenderBilhetes.Margin = new Padding(3, 4, 3, 4);
            btnVenderBilhetes.Name = "btnVenderBilhetes";
            btnVenderBilhetes.Size = new Size(546, 65);
            btnVenderBilhetes.TabIndex = 91;
            btnVenderBilhetes.Text = "                Vender Bilhetes";
            btnVenderBilhetes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVenderBilhetes.UseVisualStyleBackColor = false;
            btnVenderBilhetes.Click += btnVenderBilhetes_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxVoos);
            groupBox2.Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(83, 4, 17);
            groupBox2.Location = new Point(105, 105);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1214, 155);
            groupBox2.TabIndex = 90;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selecionar Voo";
            // 
            // comboBoxVoos
            // 
            comboBoxVoos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoos.ForeColor = Color.FromArgb(83, 4, 17);
            comboBoxVoos.FormattingEnabled = true;
            comboBoxVoos.Location = new Point(18, 62);
            comboBoxVoos.Margin = new Padding(3, 4, 3, 4);
            comboBoxVoos.Name = "comboBoxVoos";
            comboBoxVoos.Size = new Size(1174, 35);
            comboBoxVoos.TabIndex = 4;
            comboBoxVoos.SelectedIndexChanged += comboBoxVoos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(83, 4, 17);
            label2.Location = new Point(103, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 40);
            label2.TabIndex = 96;
            label2.Text = "Gerir Bilhetes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(83, 4, 17);
            label3.Location = new Point(103, 416);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(302, 40);
            label3.TabIndex = 97;
            label3.Text = "Bilhetes Vendidos";
            // 
            // btnCancelarBilhete
            // 
            btnCancelarBilhete.BackColor = Color.Firebrick;
            btnCancelarBilhete.FlatAppearance.BorderSize = 0;
            btnCancelarBilhete.FlatStyle = FlatStyle.Flat;
            btnCancelarBilhete.Font = new Font("Gadugi", 12F, FontStyle.Bold);
            btnCancelarBilhete.ForeColor = Color.White;
            btnCancelarBilhete.Image = Properties.Resources.icons8_cancel_30;
            btnCancelarBilhete.Location = new Point(1327, 928);
            btnCancelarBilhete.Margin = new Padding(4);
            btnCancelarBilhete.Name = "btnCancelarBilhete";
            btnCancelarBilhete.Size = new Size(214, 62);
            btnCancelarBilhete.TabIndex = 98;
            btnCancelarBilhete.Text = "  Cancelar Bilhete";
            btnCancelarBilhete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarBilhete.UseVisualStyleBackColor = false;
            btnCancelarBilhete.Click += btnCancelarBilhete_Click_1;
            // 
            // UCBilhetes
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancelarBilhete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAlterarLugar);
            Controls.Add(gridViewBilhetesVendidos);
            Controls.Add(btnVenderBilhetes);
            Controls.Add(groupBox2);
            Font = new Font("Gadugi", 12F);
            Margin = new Padding(4);
            Name = "UCBilhetes";
            Size = new Size(1643, 1026);
            ((System.ComponentModel.ISupportInitialize)gridViewBilhetesVendidos).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAlterarLugar;
        private DataGridView gridViewBilhetesVendidos;
        private Button btnVenderBilhetes;
        private GroupBox groupBox2;
        private ComboBox comboBoxVoos;
        private Label label2;
        private Label label3;
        private Button btnCancelarBilhete;
    }
}
