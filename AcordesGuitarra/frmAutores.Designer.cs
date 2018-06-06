namespace AcordesGuitarra
{
    partial class frmAutores
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
            this.txtautor = new System.Windows.Forms.TextBox();
            this.btmagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(59, 40);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(173, 20);
            this.txtautor.TabIndex = 4;
            // 
            // btmagregar
            // 
            this.btmagregar.Location = new System.Drawing.Point(88, 75);
            this.btmagregar.Name = "btmagregar";
            this.btmagregar.Size = new System.Drawing.Size(107, 37);
            this.btmagregar.TabIndex = 3;
            this.btmagregar.Text = "AGREGAR";
            this.btmagregar.UseVisualStyleBackColor = true;
            this.btmagregar.Click += new System.EventHandler(this.btmagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "AUTOR:";
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.btmagregar);
            this.Name = "frmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Button btmagregar;
        private System.Windows.Forms.Label label1;
    }
}