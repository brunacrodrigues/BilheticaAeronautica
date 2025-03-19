namespace BilheticaAeronautica
{
    partial class FormAdicionarAeroporto
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
            label1 = new Label();
            txtNome = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel3 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtIATA = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            lblId = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            txtCidade = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            btnGuardar = new Button();
            txtPais = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            gradientLabel5 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            btnEditar = new Button();
            listBoxAeroportos = new ListBox();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(90, 64);
            label1.Name = "label1";
            label1.Size = new Size(389, 36);
            label1.TabIndex = 20;
            label1.Text = "Adicionar Novo Aeroporto";
            // 
            // txtNome
            // 
            txtNome.AutoSuggestFormula = false;
            txtNome.DisabledBackColor = SystemColors.Window;
            txtNome.EnabledBackColor = SystemColors.Window;
            txtNome.Location = new Point(235, 305);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(499, 38);
            txtNome.TabIndex = 18;
            // 
            // gradientLabel3
            // 
            gradientLabel3.BeforeTouchSize = new Size(129, 49);
            gradientLabel3.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel3.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel3.Location = new Point(90, 300);
            gradientLabel3.Name = "gradientLabel3";
            gradientLabel3.Size = new Size(129, 49);
            gradientLabel3.TabIndex = 17;
            gradientLabel3.Text = "Nome";
            gradientLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIATA
            // 
            txtIATA.AutoSuggestFormula = false;
            txtIATA.DisabledBackColor = SystemColors.Window;
            txtIATA.EnabledBackColor = SystemColors.Window;
            txtIATA.Location = new Point(235, 225);
            txtIATA.Name = "txtIATA";
            txtIATA.Size = new Size(224, 38);
            txtIATA.TabIndex = 16;
            // 
            // gradientLabel2
            // 
            gradientLabel2.BeforeTouchSize = new Size(129, 49);
            gradientLabel2.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel2.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel2.Location = new Point(90, 220);
            gradientLabel2.Name = "gradientLabel2";
            gradientLabel2.Size = new Size(129, 49);
            gradientLabel2.TabIndex = 15;
            gradientLabel2.Text = "IATA";
            gradientLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId
            // 
            lblId.Location = new Point(225, 153);
            lblId.Name = "lblId";
            lblId.Size = new Size(98, 27);
            lblId.TabIndex = 14;
            lblId.Text = "<none>";
            // 
            // gradientLabel1
            // 
            gradientLabel1.BeforeTouchSize = new Size(129, 49);
            gradientLabel1.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel1.Location = new Point(90, 140);
            gradientLabel1.Name = "gradientLabel1";
            gradientLabel1.Size = new Size(129, 49);
            gradientLabel1.TabIndex = 13;
            gradientLabel1.Text = "Id";
            gradientLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCidade
            // 
            txtCidade.AutoSuggestFormula = false;
            txtCidade.DisabledBackColor = SystemColors.Window;
            txtCidade.EnabledBackColor = SystemColors.Window;
            txtCidade.Location = new Point(944, 219);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(499, 38);
            txtCidade.TabIndex = 22;
            // 
            // gradientLabel4
            // 
            gradientLabel4.BeforeTouchSize = new Size(129, 49);
            gradientLabel4.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel4.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel4.Location = new Point(799, 214);
            gradientLabel4.Name = "gradientLabel4";
            gradientLabel4.Size = new Size(129, 49);
            gradientLabel4.TabIndex = 21;
            gradientLabel4.Text = "Cidade";
            gradientLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Navy;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1321, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 46);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPais
            // 
            txtPais.AutoSuggestFormula = false;
            txtPais.DisabledBackColor = SystemColors.Window;
            txtPais.EnabledBackColor = SystemColors.Window;
            txtPais.Location = new Point(944, 298);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(499, 38);
            txtPais.TabIndex = 26;
            // 
            // gradientLabel5
            // 
            gradientLabel5.BeforeTouchSize = new Size(129, 49);
            gradientLabel5.BorderSides = Border3DSide.Left | Border3DSide.Top | Border3DSide.Right | Border3DSide.Bottom;
            gradientLabel5.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradientLabel5.Location = new Point(799, 293);
            gradientLabel5.Name = "gradientLabel5";
            gradientLabel5.Size = new Size(129, 49);
            gradientLabel5.TabIndex = 25;
            gradientLabel5.Text = "País";
            gradientLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Navy;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(1325, 1026);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 46);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // listBoxAeroportos
            // 
            listBoxAeroportos.FormattingEnabled = true;
            listBoxAeroportos.ItemHeight = 27;
            listBoxAeroportos.Location = new Point(90, 479);
            listBoxAeroportos.Name = "listBoxAeroportos";
            listBoxAeroportos.Size = new Size(1208, 679);
            listBoxAeroportos.TabIndex = 28;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Crimson;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.ForeColor = Color.White;
            btnApagar.Location = new Point(1325, 1098);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(122, 46);
            btnApagar.TabIndex = 29;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            btnApagar.Click += btnApagar_Click;
            // 
            // FormAdicionarAeroporto
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 1198);
            Controls.Add(btnApagar);
            Controls.Add(listBoxAeroportos);
            Controls.Add(btnEditar);
            Controls.Add(txtPais);
            Controls.Add(gradientLabel5);
            Controls.Add(btnGuardar);
            Controls.Add(txtCidade);
            Controls.Add(gradientLabel4);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(gradientLabel3);
            Controls.Add(txtIATA);
            Controls.Add(gradientLabel2);
            Controls.Add(lblId);
            Controls.Add(gradientLabel1);
            Font = new Font("Gadugi", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAdicionarAeroporto";
            Text = "Registar Aeroporto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCapacidade;
        private Label label1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtNome;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel3;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtIATA;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblId;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtCidade;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Button btnGuardar;
        private Syncfusion.Windows.Forms.Grid.GridAwareTextBox txtPais;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel5;
        private Button btnEditar;
        private ListBox listBoxAeroportos;
        private Button btnApagar;
    }
}