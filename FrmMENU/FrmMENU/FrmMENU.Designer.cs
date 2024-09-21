namespace FrmMENU
{
    partial class FrmMENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hABITACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOTELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESERVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.hABITACIONToolStripMenuItem,
            this.hOTELToolStripMenuItem,
            this.rESERVAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTE";
            // 
            // hABITACIONToolStripMenuItem
            // 
            this.hABITACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHabitacionToolStripMenuItem});
            this.hABITACIONToolStripMenuItem.Name = "hABITACIONToolStripMenuItem";
            this.hABITACIONToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.hABITACIONToolStripMenuItem.Text = "HABITACION";
            // 
            // hOTELToolStripMenuItem
            // 
            this.hOTELToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarHotelToolStripMenuItem});
            this.hOTELToolStripMenuItem.Name = "hOTELToolStripMenuItem";
            this.hOTELToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hOTELToolStripMenuItem.Text = "HOTEL";
            // 
            // rESERVAToolStripMenuItem
            // 
            this.rESERVAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReservaToolStripMenuItem});
            this.rESERVAToolStripMenuItem.Name = "rESERVAToolStripMenuItem";
            this.rESERVAToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rESERVAToolStripMenuItem.Text = "RESERVA";
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // registrarHabitacionToolStripMenuItem
            // 
            this.registrarHabitacionToolStripMenuItem.Name = "registrarHabitacionToolStripMenuItem";
            this.registrarHabitacionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarHabitacionToolStripMenuItem.Text = "Registrar Habitacion";
            this.registrarHabitacionToolStripMenuItem.Click += new System.EventHandler(this.registrarHabitacionToolStripMenuItem_Click);
            // 
            // registrarHotelToolStripMenuItem
            // 
            this.registrarHotelToolStripMenuItem.Name = "registrarHotelToolStripMenuItem";
            this.registrarHotelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarHotelToolStripMenuItem.Text = "Registrar Hotel";
            this.registrarHotelToolStripMenuItem.Click += new System.EventHandler(this.registrarHotelToolStripMenuItem_Click);
            // 
            // generarReservaToolStripMenuItem
            // 
            this.generarReservaToolStripMenuItem.Name = "generarReservaToolStripMenuItem";
            this.generarReservaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.generarReservaToolStripMenuItem.Text = "Generar Reserva";
            this.generarReservaToolStripMenuItem.Click += new System.EventHandler(this.generarReservaToolStripMenuItem_Click);
            // 
            // FrmMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 455);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Hotel ";
            this.Load += new System.EventHandler(this.FrmMENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hABITACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOTELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESERVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHabitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReservaToolStripMenuItem;
    }
}

