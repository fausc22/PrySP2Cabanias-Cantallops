
namespace SP2CantallopsFausto
{
    partial class frmReserva
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
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.LstTarjetas = new System.Windows.Forms.ComboBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.MrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.MrcFormadepago = new System.Windows.Forms.GroupBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.MrcTipoCabaña = new System.Windows.Forms.GroupBox();
            this.lblDías = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.LstTipo = new System.Windows.Forms.ComboBox();
            this.LstPersonas = new System.Windows.Forms.ComboBox();
            this.MrcTitular = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.MrcAdicionales.SuspendLayout();
            this.MrcFormadepago.SuspendLayout();
            this.MrcTipoCabaña.SuspendLayout();
            this.MrcTitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(6, 19);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(398, 351);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(119, 39);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(6, 19);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 2;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // LstTarjetas
            // 
            this.LstTarjetas.FormattingEnabled = true;
            this.LstTarjetas.Location = new System.Drawing.Point(155, 65);
            this.LstTarjetas.Name = "LstTarjetas";
            this.LstTarjetas.Size = new System.Drawing.Size(167, 21);
            this.LstTarjetas.TabIndex = 3;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(12, 30);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(49, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(430, 48);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(57, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // MrcAdicionales
            // 
            this.MrcAdicionales.Controls.Add(this.chkCocina);
            this.MrcAdicionales.Controls.Add(this.chkHeladera);
            this.MrcAdicionales.Controls.Add(this.chkTelevisor);
            this.MrcAdicionales.Location = new System.Drawing.Point(12, 118);
            this.MrcAdicionales.Name = "MrcAdicionales";
            this.MrcAdicionales.Size = new System.Drawing.Size(140, 100);
            this.MrcAdicionales.TabIndex = 6;
            this.MrcAdicionales.TabStop = false;
            this.MrcAdicionales.Text = "Adicionales";
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(6, 42);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 13;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(6, 65);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 14;
            this.chkTelevisor.Text = "Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // MrcFormadepago
            // 
            this.MrcFormadepago.Controls.Add(this.lblTarjeta);
            this.MrcFormadepago.Controls.Add(this.optEfectivo);
            this.MrcFormadepago.Controls.Add(this.optTarjeta);
            this.MrcFormadepago.Controls.Add(this.LstTarjetas);
            this.MrcFormadepago.Location = new System.Drawing.Point(177, 118);
            this.MrcFormadepago.Name = "MrcFormadepago";
            this.MrcFormadepago.Size = new System.Drawing.Size(342, 100);
            this.MrcFormadepago.TabIndex = 7;
            this.MrcFormadepago.TabStop = false;
            this.MrcFormadepago.Text = "Forma de Pago";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(152, 46);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(45, 13);
            this.lblTarjeta.TabIndex = 18;
            this.lblTarjeta.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(6, 41);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 12;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // MrcTipoCabaña
            // 
            this.MrcTipoCabaña.Controls.Add(this.lblDías);
            this.MrcTipoCabaña.Controls.Add(this.lblPersonas);
            this.MrcTipoCabaña.Controls.Add(this.lblTipo);
            this.MrcTipoCabaña.Controls.Add(this.LstTipo);
            this.MrcTipoCabaña.Controls.Add(this.LstPersonas);
            this.MrcTipoCabaña.Controls.Add(this.txtDias);
            this.MrcTipoCabaña.Location = new System.Drawing.Point(12, 12);
            this.MrcTipoCabaña.Name = "MrcTipoCabaña";
            this.MrcTipoCabaña.Size = new System.Drawing.Size(507, 100);
            this.MrcTipoCabaña.TabIndex = 8;
            this.MrcTipoCabaña.TabStop = false;
            this.MrcTipoCabaña.Text = "Tipo de Cabaña";
            // 
            // lblDías
            // 
            this.lblDías.AutoSize = true;
            this.lblDías.Location = new System.Drawing.Point(394, 51);
            this.lblDías.Name = "lblDías";
            this.lblDías.Size = new System.Drawing.Size(30, 13);
            this.lblDías.TabIndex = 17;
            this.lblDías.Text = "Días";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(219, 51);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 17;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo";
            // 
            // LstTipo
            // 
            this.LstTipo.FormattingEnabled = true;
            this.LstTipo.Location = new System.Drawing.Point(63, 48);
            this.LstTipo.Name = "LstTipo";
            this.LstTipo.Size = new System.Drawing.Size(121, 21);
            this.LstTipo.TabIndex = 10;
            this.LstTipo.SelectedIndexChanged += new System.EventHandler(this.LstTipo_SelectedIndexChanged);
            // 
            // LstPersonas
            // 
            this.LstPersonas.FormattingEnabled = true;
            this.LstPersonas.Location = new System.Drawing.Point(276, 48);
            this.LstPersonas.Name = "LstPersonas";
            this.LstPersonas.Size = new System.Drawing.Size(64, 21);
            this.LstPersonas.TabIndex = 11;
            // 
            // MrcTitular
            // 
            this.MrcTitular.Controls.Add(this.txtNombre);
            this.MrcTitular.Controls.Add(this.lblTelefono);
            this.MrcTitular.Controls.Add(this.txtTelefono);
            this.MrcTitular.Controls.Add(this.lblNombres);
            this.MrcTitular.Location = new System.Drawing.Point(12, 233);
            this.MrcTitular.Name = "MrcTitular";
            this.MrcTitular.Size = new System.Drawing.Size(507, 100);
            this.MrcTitular.TabIndex = 9;
            this.MrcTitular.TabStop = false;
            this.MrcTitular.Text = "Titular de la Reserva";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(424, 20);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 59);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(63, 56);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(424, 20);
            this.txtTelefono.TabIndex = 15;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 397);
            this.Controls.Add(this.MrcAdicionales);
            this.Controls.Add(this.MrcTitular);
            this.Controls.Add(this.MrcTipoCabaña);
            this.Controls.Add(this.MrcFormadepago);
            this.Controls.Add(this.cmdAceptar);
            this.Name = "frmReserva";
            this.Text = "Reservas de Cabañas";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.MrcAdicionales.ResumeLayout(false);
            this.MrcAdicionales.PerformLayout();
            this.MrcFormadepago.ResumeLayout(false);
            this.MrcFormadepago.PerformLayout();
            this.MrcTipoCabaña.ResumeLayout(false);
            this.MrcTipoCabaña.PerformLayout();
            this.MrcTitular.ResumeLayout(false);
            this.MrcTitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.ComboBox LstTarjetas;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox MrcAdicionales;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.GroupBox MrcFormadepago;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.GroupBox MrcTipoCabaña;
        private System.Windows.Forms.Label lblDías;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox LstTipo;
        private System.Windows.Forms.ComboBox LstPersonas;
        private System.Windows.Forms.GroupBox MrcTitular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}

