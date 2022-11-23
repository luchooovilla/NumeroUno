namespace UltimoPobreTitoVillaFinal.Interfaz
{
    partial class frmRegistroRECLAMO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroReclamo = new System.Windows.Forms.TextBox();
            this.btnAceptarReclamo = new System.Windows.Forms.Button();
            this.btnCancelarReclamo = new System.Windows.Forms.Button();
            this.txtFechaReclamo = new System.Windows.Forms.TextBox();
            this.txtEstadoReclamo = new System.Windows.Forms.TextBox();
            this.txtDescripcionReclamo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Reclamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // txtNumeroReclamo
            // 
            this.txtNumeroReclamo.Location = new System.Drawing.Point(261, 45);
            this.txtNumeroReclamo.Name = "txtNumeroReclamo";
            this.txtNumeroReclamo.Size = new System.Drawing.Size(299, 39);
            this.txtNumeroReclamo.TabIndex = 4;
            // 
            // btnAceptarReclamo
            // 
            this.btnAceptarReclamo.Location = new System.Drawing.Point(680, 136);
            this.btnAceptarReclamo.Name = "btnAceptarReclamo";
            this.btnAceptarReclamo.Size = new System.Drawing.Size(150, 46);
            this.btnAceptarReclamo.TabIndex = 8;
            this.btnAceptarReclamo.Text = "Aceptar";
            this.btnAceptarReclamo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReclamo
            // 
            this.btnCancelarReclamo.Location = new System.Drawing.Point(680, 317);
            this.btnCancelarReclamo.Name = "btnCancelarReclamo";
            this.btnCancelarReclamo.Size = new System.Drawing.Size(150, 46);
            this.btnCancelarReclamo.TabIndex = 9;
            this.btnCancelarReclamo.Text = "Cancelar";
            this.btnCancelarReclamo.UseVisualStyleBackColor = true;
            // 
            // txtFechaReclamo
            // 
            this.txtFechaReclamo.Location = new System.Drawing.Point(160, 143);
            this.txtFechaReclamo.Name = "txtFechaReclamo";
            this.txtFechaReclamo.Size = new System.Drawing.Size(299, 39);
            this.txtFechaReclamo.TabIndex = 10;
            // 
            // txtEstadoReclamo
            // 
            this.txtEstadoReclamo.Location = new System.Drawing.Point(160, 264);
            this.txtEstadoReclamo.Name = "txtEstadoReclamo";
            this.txtEstadoReclamo.Size = new System.Drawing.Size(299, 39);
            this.txtEstadoReclamo.TabIndex = 11;
            // 
            // txtDescripcionReclamo
            // 
            this.txtDescripcionReclamo.Location = new System.Drawing.Point(200, 391);
            this.txtDescripcionReclamo.Name = "txtDescripcionReclamo";
            this.txtDescripcionReclamo.Size = new System.Drawing.Size(299, 39);
            this.txtDescripcionReclamo.TabIndex = 12;
            // 
            // frmRegistroRECLAMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 502);
            this.Controls.Add(this.txtDescripcionReclamo);
            this.Controls.Add(this.txtEstadoReclamo);
            this.Controls.Add(this.txtFechaReclamo);
            this.Controls.Add(this.btnCancelarReclamo);
            this.Controls.Add(this.btnAceptarReclamo);
            this.Controls.Add(this.txtNumeroReclamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistroRECLAMO";
            this.Text = "frmRegistroRECLAMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumeroReclamo;
        private Button btnAceptarReclamo;
        private Button btnCancelarReclamo;
        private TextBox txtFechaReclamo;
        private TextBox txtEstadoReclamo;
        private TextBox txtDescripcionReclamo;
    }
}