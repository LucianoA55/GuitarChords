namespace AcordesGuitarra
{
    partial class frmAgregarCancion
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
            this.lstpartitura = new System.Windows.Forms.ListBox();
            this.btmnuevo = new System.Windows.Forms.Button();
            this.btmeditar = new System.Windows.Forms.Button();
            this.btmborrar = new System.Windows.Forms.Button();
            this.btmcancelar = new System.Windows.Forms.Button();
            this.btmguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbogenero = new System.Windows.Forms.ComboBox();
            this.txtcapo = new System.Windows.Forms.TextBox();
            this.rbtsi = new System.Windows.Forms.RadioButton();
            this.rbtno = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboautor = new System.Windows.Forms.ComboBox();
            this.txtpartitura = new System.Windows.Forms.RichTextBox();
            this.txtpartitura2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lstpartitura
            // 
            this.lstpartitura.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstpartitura.FormattingEnabled = true;
            this.lstpartitura.ItemHeight = 18;
            this.lstpartitura.Location = new System.Drawing.Point(1220, 12);
            this.lstpartitura.Name = "lstpartitura";
            this.lstpartitura.Size = new System.Drawing.Size(554, 670);
            this.lstpartitura.TabIndex = 3;
            this.lstpartitura.SelectedIndexChanged += new System.EventHandler(this.lstpartitura_SelectedIndexChanged);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmnuevo.Location = new System.Drawing.Point(1217, 933);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(101, 35);
            this.btmnuevo.TabIndex = 4;
            this.btmnuevo.Text = "NUEVO";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // btmeditar
            // 
            this.btmeditar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmeditar.Location = new System.Drawing.Point(1330, 933);
            this.btmeditar.Name = "btmeditar";
            this.btmeditar.Size = new System.Drawing.Size(101, 35);
            this.btmeditar.TabIndex = 5;
            this.btmeditar.Text = "EDITAR";
            this.btmeditar.UseVisualStyleBackColor = true;
            this.btmeditar.Click += new System.EventHandler(this.btmeditar_Click);
            // 
            // btmborrar
            // 
            this.btmborrar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmborrar.Location = new System.Drawing.Point(1443, 933);
            this.btmborrar.Name = "btmborrar";
            this.btmborrar.Size = new System.Drawing.Size(101, 35);
            this.btmborrar.TabIndex = 6;
            this.btmborrar.Text = "BORRAR";
            this.btmborrar.UseVisualStyleBackColor = true;
            this.btmborrar.Click += new System.EventHandler(this.btmborrar_Click);
            // 
            // btmcancelar
            // 
            this.btmcancelar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmcancelar.Location = new System.Drawing.Point(1556, 933);
            this.btmcancelar.Name = "btmcancelar";
            this.btmcancelar.Size = new System.Drawing.Size(101, 35);
            this.btmcancelar.TabIndex = 7;
            this.btmcancelar.Text = "CANCELAR";
            this.btmcancelar.UseVisualStyleBackColor = true;
            this.btmcancelar.Click += new System.EventHandler(this.btmcancelar_Click);
            // 
            // btmguardar
            // 
            this.btmguardar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmguardar.Location = new System.Drawing.Point(1669, 933);
            this.btmguardar.Name = "btmguardar";
            this.btmguardar.Size = new System.Drawing.Size(101, 35);
            this.btmguardar.TabIndex = 8;
            this.btmguardar.Text = "GUARDAR";
            this.btmguardar.UseVisualStyleBackColor = true;
            this.btmguardar.Click += new System.EventHandler(this.btmguardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1217, 725);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Canción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1217, 760);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Capotrasto?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1217, 795);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Posicion del Capotrasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1217, 830);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Género:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(1371, 724);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(250, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // cbogenero
            // 
            this.cbogenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogenero.FormattingEnabled = true;
            this.cbogenero.Location = new System.Drawing.Point(1371, 826);
            this.cbogenero.Name = "cbogenero";
            this.cbogenero.Size = new System.Drawing.Size(250, 21);
            this.cbogenero.TabIndex = 16;
            // 
            // txtcapo
            // 
            this.txtcapo.Location = new System.Drawing.Point(1371, 792);
            this.txtcapo.Name = "txtcapo";
            this.txtcapo.Size = new System.Drawing.Size(71, 20);
            this.txtcapo.TabIndex = 17;
            this.txtcapo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcapo_KeyPress);
            // 
            // rbtsi
            // 
            this.rbtsi.AutoSize = true;
            this.rbtsi.Location = new System.Drawing.Point(1371, 760);
            this.rbtsi.Name = "rbtsi";
            this.rbtsi.Size = new System.Drawing.Size(35, 17);
            this.rbtsi.TabIndex = 18;
            this.rbtsi.TabStop = true;
            this.rbtsi.Text = "SI";
            this.rbtsi.UseVisualStyleBackColor = true;
            // 
            // rbtno
            // 
            this.rbtno.AutoSize = true;
            this.rbtno.Location = new System.Drawing.Point(1412, 760);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(41, 17);
            this.rbtno.TabIndex = 19;
            this.rbtno.TabStop = true;
            this.rbtno.Text = "NO";
            this.rbtno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1217, 865);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Autor:";
            // 
            // cboautor
            // 
            this.cboautor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboautor.FormattingEnabled = true;
            this.cboautor.Location = new System.Drawing.Point(1371, 861);
            this.cboautor.Name = "cboautor";
            this.cboautor.Size = new System.Drawing.Size(250, 21);
            this.cboautor.TabIndex = 21;
            // 
            // txtpartitura
            // 
            this.txtpartitura.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartitura.Location = new System.Drawing.Point(12, 12);
            this.txtpartitura.Name = "txtpartitura";
            this.txtpartitura.Size = new System.Drawing.Size(570, 960);
            this.txtpartitura.TabIndex = 22;
            this.txtpartitura.Text = "";
            // 
            // txtpartitura2
            // 
            this.txtpartitura2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartitura2.Location = new System.Drawing.Point(616, 12);
            this.txtpartitura2.Name = "txtpartitura2";
            this.txtpartitura2.Size = new System.Drawing.Size(570, 960);
            this.txtpartitura2.TabIndex = 23;
            this.txtpartitura2.Text = "";
            // 
            // frmAgregarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 984);
            this.Controls.Add(this.txtpartitura2);
            this.Controls.Add(this.txtpartitura);
            this.Controls.Add(this.cboautor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtno);
            this.Controls.Add(this.rbtsi);
            this.Controls.Add(this.txtcapo);
            this.Controls.Add(this.cbogenero);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmguardar);
            this.Controls.Add(this.btmcancelar);
            this.Controls.Add(this.btmborrar);
            this.Controls.Add(this.btmeditar);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.lstpartitura);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1824, 1022);
            this.MinimumSize = new System.Drawing.Size(1824, 1022);
            this.Name = "frmAgregarCancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar/Modificar Canción";
            this.Load += new System.EventHandler(this.frmAgregarCancion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstpartitura;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmeditar;
        private System.Windows.Forms.Button btmborrar;
        private System.Windows.Forms.Button btmcancelar;
        private System.Windows.Forms.Button btmguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbogenero;
        private System.Windows.Forms.TextBox txtcapo;
        private System.Windows.Forms.RadioButton rbtsi;
        private System.Windows.Forms.RadioButton rbtno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboautor;
        private System.Windows.Forms.RichTextBox txtpartitura;
        private System.Windows.Forms.RichTextBox txtpartitura2;
    }
}