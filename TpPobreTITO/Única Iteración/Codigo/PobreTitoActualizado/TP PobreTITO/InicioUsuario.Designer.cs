namespace TP_PobreTITO
{
    partial class InicioUsuario
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
            this.btnReportarIncidente = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportarIncidente
            // 
            this.btnReportarIncidente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportarIncidente.Location = new System.Drawing.Point(266, 95);
            this.btnReportarIncidente.Name = "btnReportarIncidente";
            this.btnReportarIncidente.Size = new System.Drawing.Size(262, 65);
            this.btnReportarIncidente.TabIndex = 0;
            this.btnReportarIncidente.Text = "Reportar Incidente";
            this.btnReportarIncidente.UseVisualStyleBackColor = true;
            this.btnReportarIncidente.Click += new System.EventHandler(this.btnReportarIncidente_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerHistorial.Location = new System.Drawing.Point(264, 201);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(260, 62);
            this.btnVerHistorial.TabIndex = 1;
            this.btnVerHistorial.Text = "Ver Historial de Incidentes Reportados";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(330, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 36);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btn3_Click);
            // 
            // InicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnReportarIncidente);
            this.Name = "InicioUsuario";
            this.Text = "InicioUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReportarIncidente;
        private Button btnVerHistorial;
        private Button btnSalir;
    }
}