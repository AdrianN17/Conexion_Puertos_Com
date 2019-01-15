namespace Puertos_Com
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cports = new System.Windows.Forms.ComboBox();
            this.btopen = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // cports
            // 
            this.cports.FormattingEnabled = true;
            this.cports.Location = new System.Drawing.Point(154, 47);
            this.cports.Name = "cports";
            this.cports.Size = new System.Drawing.Size(121, 24);
            this.cports.TabIndex = 1;
            // 
            // btopen
            // 
            this.btopen.Location = new System.Drawing.Point(315, 47);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(75, 23);
            this.btopen.TabIndex = 2;
            this.btopen.Text = "Open";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(430, 47);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(75, 23);
            this.btclose.TabIndex = 3;
            this.btclose.Text = "Close";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(571, 52);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(60, 17);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "No Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 125);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btopen);
            this.Controls.Add(this.cports);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lector Bluetooth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cports;
        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.Button btclose;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb1;
    }
}

