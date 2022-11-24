namespace TP_PobreTITO
{
    partial class ReportarIncidente
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.cbxTipoReporte = new System.Windows.Forms.ComboBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnReportarIncidente = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUbicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(25, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tipo de Reporte";
            // 
            // cbxTipoReporte
            // 
            this.cbxTipoReporte.FormattingEnabled = true;
            this.cbxTipoReporte.Items.AddRange(new object[] {
            "Reporte de Vecino"});
            this.cbxTipoReporte.Location = new System.Drawing.Point(25, 50);
            this.cbxTipoReporte.Name = "cbxTipoReporte";
            this.cbxTipoReporte.Size = new System.Drawing.Size(205, 23);
            this.cbxTipoReporte.TabIndex = 1;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(25, 285);
            this.txtBoxDescripcion.MaxLength = 500;
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(704, 162);
            this.txtBoxDescripcion.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(25, 261);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(204, 21);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Descripcion del Incidente";
            // 
            // btnReportarIncidente
            // 
            this.btnReportarIncidente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportarIncidente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportarIncidente.Location = new System.Drawing.Point(317, 476);
            this.btnReportarIncidente.Name = "btnReportarIncidente";
            this.btnReportarIncidente.Size = new System.Drawing.Size(132, 46);
            this.btnReportarIncidente.TabIndex = 4;
            this.btnReportarIncidente.Text = "Reportar Incidente";
            this.btnReportarIncidente.UseVisualStyleBackColor = true;
            this.btnReportarIncidente.Click += new System.EventHandler(this.btnReportarIncidente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(320, 548);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 36);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbxArea
            // 
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Items.AddRange(new object[] {
            "Transito",
            "Deportes",
            "Espacios Verdes"});
            this.cbxArea.Location = new System.Drawing.Point(25, 133);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(207, 23);
            this.cbxArea.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(25, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(126, 21);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Area Municipal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ubicacion";
            // 
            // txtBoxUbicacion
            // 
            this.txtBoxUbicacion.Location = new System.Drawing.Point(25, 201);
            this.txtBoxUbicacion.Name = "txtBoxUbicacion";
            this.txtBoxUbicacion.Size = new System.Drawing.Size(704, 23);
            this.txtBoxUbicacion.TabIndex = 9;
            // 
            // ReportarIncidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.txtBoxUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cbxArea);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReportarIncidente);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.cbxTipoReporte);
            this.Controls.Add(this.lbl1);
            this.Name = "ReportarIncidente";
            this.Text = "ReportarIncidente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private ComboBox cbxTipoReporte;
        private TextBox txtBoxDescripcion;
        private Label lbl2;
        private Button btnReportarIncidente;
        private Button btnVolver;
        private ComboBox cbxArea;
        private Label lbl3;
        private Label label1;
        private TextBox txtBoxUbicacion;
    }
}