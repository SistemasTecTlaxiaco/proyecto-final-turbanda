
namespace BIENES_RAICES
{
    partial class Form_Agrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agrega));
            this.Add_cliente = new System.Windows.Forms.Button();
            this.tipo_plazo = new System.Windows.Forms.Button();
            this.Tipo_terreno = new System.Windows.Forms.Button();
            this.terreno = new System.Windows.Forms.Button();
            this.casa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.f_pago = new System.Windows.Forms.Button();
            this.amortizacion = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_cliente
            // 
            this.Add_cliente.Location = new System.Drawing.Point(80, 200);
            this.Add_cliente.Name = "Add_cliente";
            this.Add_cliente.Size = new System.Drawing.Size(108, 72);
            this.Add_cliente.TabIndex = 0;
            this.Add_cliente.Text = "Agregar Cliente";
            this.Add_cliente.UseVisualStyleBackColor = true;
            this.Add_cliente.Click += new System.EventHandler(this.Add_cliente_Click);
            // 
            // tipo_plazo
            // 
            this.tipo_plazo.Location = new System.Drawing.Point(446, 200);
            this.tipo_plazo.Name = "tipo_plazo";
            this.tipo_plazo.Size = new System.Drawing.Size(108, 72);
            this.tipo_plazo.TabIndex = 1;
            this.tipo_plazo.Text = "Tipo de plazo";
            this.tipo_plazo.UseVisualStyleBackColor = true;
            this.tipo_plazo.Click += new System.EventHandler(this.tipo_plazo_Click);
            // 
            // Tipo_terreno
            // 
            this.Tipo_terreno.Location = new System.Drawing.Point(255, 200);
            this.Tipo_terreno.Name = "Tipo_terreno";
            this.Tipo_terreno.Size = new System.Drawing.Size(108, 72);
            this.Tipo_terreno.TabIndex = 2;
            this.Tipo_terreno.Text = "Tipo de terreno";
            this.Tipo_terreno.UseVisualStyleBackColor = true;
            this.Tipo_terreno.Click += new System.EventHandler(this.Tipo_terreno_Click);
            // 
            // terreno
            // 
            this.terreno.Location = new System.Drawing.Point(255, 318);
            this.terreno.Name = "terreno";
            this.terreno.Size = new System.Drawing.Size(108, 72);
            this.terreno.TabIndex = 3;
            this.terreno.Text = "Terreno";
            this.terreno.UseVisualStyleBackColor = true;
            this.terreno.Click += new System.EventHandler(this.terreno_Click);
            // 
            // casa
            // 
            this.casa.Location = new System.Drawing.Point(80, 318);
            this.casa.Name = "casa";
            this.casa.Size = new System.Drawing.Size(108, 72);
            this.casa.TabIndex = 4;
            this.casa.Text = "Casa";
            this.casa.UseVisualStyleBackColor = true;
            this.casa.Click += new System.EventHandler(this.casa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "AGREGAR, MODIFICAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(608, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 125);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // f_pago
            // 
            this.f_pago.Location = new System.Drawing.Point(446, 318);
            this.f_pago.Name = "f_pago";
            this.f_pago.Size = new System.Drawing.Size(108, 72);
            this.f_pago.TabIndex = 7;
            this.f_pago.Text = "Forma de pago";
            this.f_pago.UseVisualStyleBackColor = true;
            this.f_pago.Click += new System.EventHandler(this.f_pago_Click);
            // 
            // amortizacion
            // 
            this.amortizacion.Location = new System.Drawing.Point(608, 200);
            this.amortizacion.Name = "amortizacion";
            this.amortizacion.Size = new System.Drawing.Size(108, 72);
            this.amortizacion.TabIndex = 8;
            this.amortizacion.Text = "Amortizacion";
            this.amortizacion.UseVisualStyleBackColor = true;
            this.amortizacion.Click += new System.EventHandler(this.amortizacion_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(664, 393);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 39;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Form_Agrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.amortizacion);
            this.Controls.Add(this.f_pago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.casa);
            this.Controls.Add(this.terreno);
            this.Controls.Add(this.Tipo_terreno);
            this.Controls.Add(this.tipo_plazo);
            this.Controls.Add(this.Add_cliente);
            this.Name = "Form_Agrega";
            this.Text = "Agregar        ---- BIENES RAÍCES TLAXIACO----";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_cliente;
        private System.Windows.Forms.Button tipo_plazo;
        private System.Windows.Forms.Button Tipo_terreno;
        private System.Windows.Forms.Button terreno;
        private System.Windows.Forms.Button casa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button f_pago;
        private System.Windows.Forms.Button amortizacion;
        private System.Windows.Forms.Button cerrar;
    }
}