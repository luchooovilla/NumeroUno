namespace TD.Patrones.TemplateMethod.UI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboCreditos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSolicitar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(69, 66);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(329, 24);
            this.cboClientes.TabIndex = 1;
            // 
            // cboCreditos
            // 
            this.cboCreditos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCreditos.FormattingEnabled = true;
            this.cboCreditos.Location = new System.Drawing.Point(69, 151);
            this.cboCreditos.Name = "cboCreditos";
            this.cboCreditos.Size = new System.Drawing.Size(329, 24);
            this.cboCreditos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Créditos Disponibles";
            // 
            // cmdSolicitar
            // 
            this.cmdSolicitar.Location = new System.Drawing.Point(69, 223);
            this.cmdSolicitar.Name = "cmdSolicitar";
            this.cmdSolicitar.Size = new System.Drawing.Size(175, 36);
            this.cmdSolicitar.TabIndex = 4;
            this.cmdSolicitar.Text = "Solicitar";
            this.cmdSolicitar.UseVisualStyleBackColor = true;
            this.cmdSolicitar.Click += new System.EventHandler(this.cmdSolicitar_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(69, 277);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(703, 140);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.cmdSolicitar);
            this.Controls.Add(this.cboCreditos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Template Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSolicitar;
        private System.Windows.Forms.RichTextBox resultado;
    }
}

