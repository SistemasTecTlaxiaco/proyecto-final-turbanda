
namespace BIENES_RAICES
{
    partial class Form_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ventas));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.list_casa = new System.Windows.Forms.ListBox();
            this.DEl = new System.Windows.Forms.Button();
            this.Modi = new System.Windows.Forms.Button();
            this.Inser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enganche = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Contenido_Base = new System.Windows.Forms.DataGridView();
            this.id_ac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.list_persona = new System.Windows.Forms.ListBox();
            this.list_terreno = new System.Windows.Forms.ListBox();
            this.list_pago = new System.Windows.Forms.ListBox();
            this.list_plazo = new System.Windows.Forms.ListBox();
            this.list_amor = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = "VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 125);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(706, 545);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 76;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Fecha";
            // 
            // list_casa
            // 
            this.list_casa.FormattingEnabled = true;
            this.list_casa.Location = new System.Drawing.Point(382, 180);
            this.list_casa.Name = "list_casa";
            this.list_casa.Size = new System.Drawing.Size(145, 30);
            this.list_casa.TabIndex = 74;
            this.list_casa.SelectedIndexChanged += new System.EventHandler(this.list_casa_SelectedIndexChanged);
            // 
            // DEl
            // 
            this.DEl.Location = new System.Drawing.Point(288, 225);
            this.DEl.Name = "DEl";
            this.DEl.Size = new System.Drawing.Size(100, 23);
            this.DEl.TabIndex = 68;
            this.DEl.Text = "Eliminar";
            this.DEl.UseVisualStyleBackColor = true;
            this.DEl.Click += new System.EventHandler(this.DEl_Click);
            // 
            // Modi
            // 
            this.Modi.Location = new System.Drawing.Point(163, 225);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(100, 23);
            this.Modi.TabIndex = 67;
            this.Modi.Text = "Modificar";
            this.Modi.UseVisualStyleBackColor = true;
            this.Modi.Click += new System.EventHandler(this.Modi_Click);
            // 
            // Inser
            // 
            this.Inser.Location = new System.Drawing.Point(44, 225);
            this.Inser.Name = "Inser";
            this.Inser.Size = new System.Drawing.Size(100, 23);
            this.Inser.TabIndex = 66;
            this.Inser.Text = "Agregar";
            this.Inser.UseVisualStyleBackColor = true;
            this.Inser.Click += new System.EventHandler(this.Inser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Enganche";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Casa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Terreno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Persona";
            // 
            // enganche
            // 
            this.enganche.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enganche.Location = new System.Drawing.Point(732, 190);
            this.enganche.Name = "enganche";
            this.enganche.Size = new System.Drawing.Size(145, 20);
            this.enganche.TabIndex = 65;
            this.enganche.TextChanged += new System.EventHandler(this.enganche_TextChanged);
            // 
            // fecha
            // 
            this.fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fecha.Location = new System.Drawing.Point(556, 190);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(145, 20);
            this.fecha.TabIndex = 64;
            this.fecha.TextChanged += new System.EventHandler(this.fecha_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Contenido_Base);
            this.groupBox1.Location = new System.Drawing.Point(44, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1302, 255);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Contenido_Base
            // 
            this.Contenido_Base.AllowUserToAddRows = false;
            this.Contenido_Base.AllowUserToDeleteRows = false;
            this.Contenido_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contenido_Base.Location = new System.Drawing.Point(5, 19);
            this.Contenido_Base.Name = "Contenido_Base";
            this.Contenido_Base.ReadOnly = true;
            this.Contenido_Base.Size = new System.Drawing.Size(1278, 218);
            this.Contenido_Base.TabIndex = 0;
            this.Contenido_Base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_ac
            // 
            this.id_ac.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.id_ac.Enabled = false;
            this.id_ac.HideSelection = false;
            this.id_ac.Location = new System.Drawing.Point(7, 180);
            this.id_ac.Name = "id_ac";
            this.id_ac.Size = new System.Drawing.Size(19, 20);
            this.id_ac.TabIndex = 73;
            this.id_ac.TabStop = false;
            this.id_ac.TextChanged += new System.EventHandler(this.id_ac_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(909, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Forma de pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1072, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Plazo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1229, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Amortizacion";
            // 
            // list_persona
            // 
            this.list_persona.FormattingEnabled = true;
            this.list_persona.Location = new System.Drawing.Point(44, 180);
            this.list_persona.Name = "list_persona";
            this.list_persona.Size = new System.Drawing.Size(145, 30);
            this.list_persona.TabIndex = 82;
            this.list_persona.SelectedIndexChanged += new System.EventHandler(this.list_persona_SelectedIndexChanged);
            // 
            // list_terreno
            // 
            this.list_terreno.FormattingEnabled = true;
            this.list_terreno.Location = new System.Drawing.Point(210, 180);
            this.list_terreno.Name = "list_terreno";
            this.list_terreno.Size = new System.Drawing.Size(145, 30);
            this.list_terreno.TabIndex = 83;
            this.list_terreno.SelectedIndexChanged += new System.EventHandler(this.list_terreno_SelectedIndexChanged);
            // 
            // list_pago
            // 
            this.list_pago.FormattingEnabled = true;
            this.list_pago.Location = new System.Drawing.Point(912, 180);
            this.list_pago.Name = "list_pago";
            this.list_pago.Size = new System.Drawing.Size(145, 30);
            this.list_pago.TabIndex = 84;
            this.list_pago.SelectedIndexChanged += new System.EventHandler(this.list_pago_SelectedIndexChanged);
            // 
            // list_plazo
            // 
            this.list_plazo.FormattingEnabled = true;
            this.list_plazo.Location = new System.Drawing.Point(1075, 180);
            this.list_plazo.Name = "list_plazo";
            this.list_plazo.Size = new System.Drawing.Size(145, 30);
            this.list_plazo.TabIndex = 85;
            this.list_plazo.SelectedIndexChanged += new System.EventHandler(this.list_plazo_SelectedIndexChanged);
            // 
            // list_amor
            // 
            this.list_amor.FormattingEnabled = true;
            this.list_amor.Location = new System.Drawing.Point(1232, 180);
            this.list_amor.Name = "list_amor";
            this.list_amor.Size = new System.Drawing.Size(145, 30);
            this.list_amor.TabIndex = 86;
            this.list_amor.SelectedIndexChanged += new System.EventHandler(this.list_amor_SelectedIndexChanged);
            // 
            // Form_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 589);
            this.Controls.Add(this.list_amor);
            this.Controls.Add(this.list_plazo);
            this.Controls.Add(this.list_pago);
            this.Controls.Add(this.list_terreno);
            this.Controls.Add(this.list_persona);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_casa);
            this.Controls.Add(this.DEl);
            this.Controls.Add(this.Modi);
            this.Controls.Add(this.Inser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enganche);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.id_ac);
            this.Name = "Form_ventas";
            this.Text = "Ventas          ---- BIENES RAÍCES TLAXIACO----";
            this.Load += new System.EventHandler(this.Form_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox list_casa;
        private System.Windows.Forms.Button DEl;
        private System.Windows.Forms.Button Modi;
        private System.Windows.Forms.Button Inser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enganche;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Contenido_Base;
        private System.Windows.Forms.TextBox id_ac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_persona;
        private System.Windows.Forms.ListBox list_terreno;
        private System.Windows.Forms.ListBox list_pago;
        private System.Windows.Forms.ListBox list_plazo;
        private System.Windows.Forms.ListBox list_amor;
    }
}