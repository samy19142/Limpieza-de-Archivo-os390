namespace Limpieza_os390
{
    partial class frmPrincipal
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(82, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 37);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar Lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(82, 62);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(102, 37);
            this.btn_procesar.TabIndex = 2;
            this.btn_procesar.Text = "Procesar Archivos";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btn_procesar);
            this.groupBox1.Location = new System.Drawing.Point(440, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 7);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(407, 433);
            this.listBoxFiles.TabIndex = 4;
            this.listBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(440, 177);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(246, 263);
            this.txtResultado.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 452);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Limpieza Archivos os390";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

