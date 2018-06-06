namespace AcordesGuitarra
{
    partial class frmInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtpartitura = new System.Windows.Forms.RichTextBox();
            this.txtpartitura2 = new System.Windows.Forms.RichTextBox();
            this.lstpartitura = new System.Windows.Forms.ListBox();
            this.cboautor = new System.Windows.Forms.ComboBox();
            this.cbogenero = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btmcargarLista = new System.Windows.Forms.Button();
            this.rbtno = new System.Windows.Forms.RadioButton();
            this.rbtsi = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcapo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btmlimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1794, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarModificarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.archivoToolStripMenuItem.Text = "Canciones";
            // 
            // agregarModificarToolStripMenuItem
            // 
            this.agregarModificarToolStripMenuItem.Name = "agregarModificarToolStripMenuItem";
            this.agregarModificarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarModificarToolStripMenuItem.Text = "Agregar/Modificar";
            this.agregarModificarToolStripMenuItem.Click += new System.EventHandler(this.agregarModificarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.generoToolStripMenuItem.Text = "Genero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.generoToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtpartitura
            // 
            this.txtpartitura.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartitura.Location = new System.Drawing.Point(12, 39);
            this.txtpartitura.Name = "txtpartitura";
            this.txtpartitura.Size = new System.Drawing.Size(570, 960);
            this.txtpartitura.TabIndex = 23;
            this.txtpartitura.Text = "";
            // 
            // txtpartitura2
            // 
            this.txtpartitura2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartitura2.Location = new System.Drawing.Point(607, 39);
            this.txtpartitura2.Name = "txtpartitura2";
            this.txtpartitura2.Size = new System.Drawing.Size(570, 960);
            this.txtpartitura2.TabIndex = 24;
            this.txtpartitura2.Text = "";
            // 
            // lstpartitura
            // 
            this.lstpartitura.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstpartitura.FormattingEnabled = true;
            this.lstpartitura.ItemHeight = 18;
            this.lstpartitura.Location = new System.Drawing.Point(1213, 39);
            this.lstpartitura.Name = "lstpartitura";
            this.lstpartitura.Size = new System.Drawing.Size(554, 670);
            this.lstpartitura.TabIndex = 25;
            this.lstpartitura.SelectedIndexChanged += new System.EventHandler(this.lstpartitura_SelectedIndexChanged);
            // 
            // cboautor
            // 
            this.cboautor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboautor.FormattingEnabled = true;
            this.cboautor.Location = new System.Drawing.Point(1375, 860);
            this.cboautor.Name = "cboautor";
            this.cboautor.Size = new System.Drawing.Size(250, 21);
            this.cboautor.TabIndex = 28;
            // 
            // cbogenero
            // 
            this.cbogenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbogenero.FormattingEnabled = true;
            this.cbogenero.Location = new System.Drawing.Point(1375, 831);
            this.cbogenero.Name = "cbogenero";
            this.cbogenero.Size = new System.Drawing.Size(250, 21);
            this.cbogenero.TabIndex = 27;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(1375, 749);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(250, 20);
            this.txtnombre.TabIndex = 26;
            // 
            // btmcargarLista
            // 
            this.btmcargarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmcargarLista.Location = new System.Drawing.Point(1543, 921);
            this.btmcargarLista.Name = "btmcargarLista";
            this.btmcargarLista.Size = new System.Drawing.Size(133, 51);
            this.btmcargarLista.TabIndex = 29;
            this.btmcargarLista.Text = "CARGAR LISTA";
            this.btmcargarLista.UseVisualStyleBackColor = true;
            this.btmcargarLista.Click += new System.EventHandler(this.btmcargarLista_Click);
            // 
            // rbtno
            // 
            this.rbtno.AutoSize = true;
            this.rbtno.Location = new System.Drawing.Point(1435, 780);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(41, 17);
            this.rbtno.TabIndex = 31;
            this.rbtno.TabStop = true;
            this.rbtno.Text = "NO";
            this.rbtno.UseVisualStyleBackColor = true;
            // 
            // rbtsi
            // 
            this.rbtsi.AutoSize = true;
            this.rbtsi.Location = new System.Drawing.Point(1375, 780);
            this.rbtsi.Name = "rbtsi";
            this.rbtsi.Size = new System.Drawing.Size(35, 17);
            this.rbtsi.TabIndex = 30;
            this.rbtsi.TabStop = true;
            this.rbtsi.Text = "SI";
            this.rbtsi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1210, 864);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1210, 836);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Género:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1210, 780);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Capotrasto?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1210, 752);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre de Canción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1210, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ordenado por:";
            // 
            // txtcapo
            // 
            this.txtcapo.Location = new System.Drawing.Point(1375, 805);
            this.txtcapo.Name = "txtcapo";
            this.txtcapo.Size = new System.Drawing.Size(71, 20);
            this.txtcapo.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1210, 808);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Posicion del Capotrasto:";
            // 
            // btmlimpiar
            // 
            this.btmlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmlimpiar.Location = new System.Drawing.Point(1313, 921);
            this.btmlimpiar.Name = "btmlimpiar";
            this.btmlimpiar.Size = new System.Drawing.Size(133, 51);
            this.btmlimpiar.TabIndex = 39;
            this.btmlimpiar.Text = "LIMPIAR BUSQUEDA";
            this.btmlimpiar.UseVisualStyleBackColor = true;
            this.btmlimpiar.Click += new System.EventHandler(this.btmlimpiar_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 984);
            this.Controls.Add(this.btmlimpiar);
            this.Controls.Add(this.txtcapo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtno);
            this.Controls.Add(this.rbtsi);
            this.Controls.Add(this.btmcargarLista);
            this.Controls.Add(this.cboautor);
            this.Controls.Add(this.cbogenero);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lstpartitura);
            this.Controls.Add(this.txtpartitura2);
            this.Controls.Add(this.txtpartitura);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACORDES PARA GUITARRA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RichTextBox txtpartitura;
        private System.Windows.Forms.RichTextBox txtpartitura2;
        private System.Windows.Forms.ListBox lstpartitura;
        private System.Windows.Forms.ComboBox cboautor;
        private System.Windows.Forms.ComboBox cbogenero;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btmcargarLista;
        private System.Windows.Forms.RadioButton rbtno;
        private System.Windows.Forms.RadioButton rbtsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcapo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmlimpiar;
    }
}

