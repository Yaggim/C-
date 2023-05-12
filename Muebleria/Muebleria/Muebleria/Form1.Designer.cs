
namespace Muebleria
{
    partial class AgregarObjetosAlCamion
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
            this.lboxMediosDeTransporte = new System.Windows.Forms.ListBox();
            this.btnAgregarAlCamion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxEmpleados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.cboxEsFragil = new System.Windows.Forms.CheckBox();
            this.nboxLargo = new System.Windows.Forms.NumericUpDown();
            this.nboxAncho = new System.Windows.Forms.NumericUpDown();
            this.nboxAlto = new System.Windows.Forms.NumericUpDown();
            this.nboxPeso = new System.Windows.Forms.NumericUpDown();
            this.btnMostrarObjetosDelCamion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nboxLargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxMediosDeTransporte
            // 
            this.lboxMediosDeTransporte.FormattingEnabled = true;
            this.lboxMediosDeTransporte.Location = new System.Drawing.Point(30, 51);
            this.lboxMediosDeTransporte.Name = "lboxMediosDeTransporte";
            this.lboxMediosDeTransporte.Size = new System.Drawing.Size(248, 95);
            this.lboxMediosDeTransporte.TabIndex = 0;
            // 
            // btnAgregarAlCamion
            // 
            this.btnAgregarAlCamion.Location = new System.Drawing.Point(133, 329);
            this.btnAgregarAlCamion.Name = "btnAgregarAlCamion";
            this.btnAgregarAlCamion.Size = new System.Drawing.Size(174, 29);
            this.btnAgregarAlCamion.TabIndex = 1;
            this.btnAgregarAlCamion.Text = "Agregar al camión";
            this.btnAgregarAlCamion.UseVisualStyleBackColor = true;
            this.btnAgregarAlCamion.Click += new System.EventHandler(this.btnAgregarAlCamion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medios de transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lboxEmpleados
            // 
            this.lboxEmpleados.FormattingEnabled = true;
            this.lboxEmpleados.Location = new System.Drawing.Point(470, 51);
            this.lboxEmpleados.Name = "lboxEmpleados";
            this.lboxEmpleados.Size = new System.Drawing.Size(214, 95);
            this.lboxEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Largo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ancho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "EsFragil?";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(77, 155);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 11;
            // 
            // cboxEsFragil
            // 
            this.cboxEsFragil.AutoSize = true;
            this.cboxEsFragil.Location = new System.Drawing.Point(77, 300);
            this.cboxEsFragil.Name = "cboxEsFragil";
            this.cboxEsFragil.Size = new System.Drawing.Size(15, 14);
            this.cboxEsFragil.TabIndex = 16;
            this.cboxEsFragil.UseVisualStyleBackColor = true;
            // 
            // nboxLargo
            // 
            this.nboxLargo.Location = new System.Drawing.Point(77, 188);
            this.nboxLargo.Name = "nboxLargo";
            this.nboxLargo.Size = new System.Drawing.Size(120, 20);
            this.nboxLargo.TabIndex = 17;
            // 
            // nboxAncho
            // 
            this.nboxAncho.Location = new System.Drawing.Point(77, 214);
            this.nboxAncho.Name = "nboxAncho";
            this.nboxAncho.Size = new System.Drawing.Size(120, 20);
            this.nboxAncho.TabIndex = 18;
            // 
            // nboxAlto
            // 
            this.nboxAlto.Location = new System.Drawing.Point(77, 245);
            this.nboxAlto.Name = "nboxAlto";
            this.nboxAlto.Size = new System.Drawing.Size(120, 20);
            this.nboxAlto.TabIndex = 19;
            // 
            // nboxPeso
            // 
            this.nboxPeso.Location = new System.Drawing.Point(77, 271);
            this.nboxPeso.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nboxPeso.Name = "nboxPeso";
            this.nboxPeso.Size = new System.Drawing.Size(120, 20);
            this.nboxPeso.TabIndex = 20;
            // 
            // btnMostrarObjetosDelCamion
            // 
            this.btnMostrarObjetosDelCamion.Location = new System.Drawing.Point(466, 253);
            this.btnMostrarObjetosDelCamion.Name = "btnMostrarObjetosDelCamion";
            this.btnMostrarObjetosDelCamion.Size = new System.Drawing.Size(218, 105);
            this.btnMostrarObjetosDelCamion.TabIndex = 21;
            this.btnMostrarObjetosDelCamion.Text = "Mostrar objetos del camión";
            this.btnMostrarObjetosDelCamion.UseVisualStyleBackColor = true;
            this.btnMostrarObjetosDelCamion.Click += new System.EventHandler(this.btnMostrarObjetosDelCamion_Click);
            // 
            // AgregarObjetosAlCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarObjetosDelCamion);
            this.Controls.Add(this.nboxPeso);
            this.Controls.Add(this.nboxAlto);
            this.Controls.Add(this.nboxAncho);
            this.Controls.Add(this.nboxLargo);
            this.Controls.Add(this.cboxEsFragil);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarAlCamion);
            this.Controls.Add(this.lboxMediosDeTransporte);
            this.Name = "AgregarObjetosAlCamion";
            this.Text = "FormEmpresaDeTransporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nboxLargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nboxPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxMediosDeTransporte;
        private System.Windows.Forms.Button btnAgregarAlCamion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.CheckBox cboxEsFragil;
        private System.Windows.Forms.NumericUpDown nboxLargo;
        private System.Windows.Forms.NumericUpDown nboxAncho;
        private System.Windows.Forms.NumericUpDown nboxAlto;
        private System.Windows.Forms.NumericUpDown nboxPeso;
        private System.Windows.Forms.Button btnMostrarObjetosDelCamion;
    }
}

