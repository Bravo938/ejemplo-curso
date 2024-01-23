namespace ejem2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroFavorito = new System.Windows.Forms.Label();
            this.butVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(134, 523);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(241, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lwElementos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lwElementos.BackgroundImage")));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(190, 372);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(428, 145);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelNombre.Location = new System.Drawing.Point(170, 77);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 18);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFecha.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelFecha.Location = new System.Drawing.Point(110, 109);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(118, 18);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(241, 109);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(277, 22);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(241, 146);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(170, 20);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "Te Gusta El Chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(273, 22);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(236, 38);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Perfil Persona";
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(30, 21);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(70, 20);
            this.rbBlanco.TabIndex = 0;
            this.rbBlanco.TabStop = true;
            this.rbBlanco.Text = "Blanco";
            this.rbBlanco.UseVisualStyleBackColor = true;
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(167, 21);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(66, 20);
            this.rbNegro.TabIndex = 0;
            this.rbNegro.TabStop = true;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = true;
            this.rbNegro.CheckedChanged += new System.EventHandler(this.rbNegro_CheckedChanged);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTipo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBoxTipo.Controls.Add(this.rbNegro);
            this.groupBoxTipo.Controls.Add(this.rbBlanco);
            this.groupBoxTipo.Location = new System.Drawing.Point(207, 183);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(268, 56);
            this.groupBoxTipo.TabIndex = 3;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(131, 248);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(97, 16);
            this.labelColor.TabIndex = 12;
            this.labelColor.Text = "Color Favorito: ";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(244, 245);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(265, 24);
            this.cboColorFavorito.TabIndex = 4;
            this.cboColorFavorito.SelectedIndexChanged += new System.EventHandler(this.cboColorFavorito_SelectedIndexChanged);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(245, 275);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 22);
            this.num.TabIndex = 5;
            // 
            // labelNumeroFavorito
            // 
            this.labelNumeroFavorito.AutoSize = true;
            this.labelNumeroFavorito.Location = new System.Drawing.Point(131, 277);
            this.labelNumeroFavorito.Name = "labelNumeroFavorito";
            this.labelNumeroFavorito.Size = new System.Drawing.Size(110, 16);
            this.labelNumeroFavorito.TabIndex = 15;
            this.labelNumeroFavorito.Text = "Numero Favorito:";
            // 
            // butVerPerfil
            // 
            this.butVerPerfil.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.butVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butVerPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVerPerfil.Location = new System.Drawing.Point(134, 322);
            this.butVerPerfil.Name = "butVerPerfil";
            this.butVerPerfil.Size = new System.Drawing.Size(107, 44);
            this.butVerPerfil.TabIndex = 6;
            this.butVerPerfil.Text = "Ver &Perfil";
            this.butVerPerfil.UseVisualStyleBackColor = false;
            this.butVerPerfil.Click += new System.EventHandler(this.butVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.butVerPerfil);
            this.Controls.Add(this.labelNumeroFavorito);
            this.Controls.Add(this.num);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.MaximumSize = new System.Drawing.Size(1031, 605);
            this.MinimumSize = new System.Drawing.Size(818, 562);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formunaliro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label labelNumeroFavorito;
        private System.Windows.Forms.Button butVerPerfil;
    }
}

