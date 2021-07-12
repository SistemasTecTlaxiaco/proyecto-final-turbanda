
namespace BIENES_RAICES
{
    partial class Form_terreno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_terreno));
            this.cerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.list_tipo_terreno = new System.Windows.Forms.ListBox();
            this.DEl = new System.Windows.Forms.Button();
            this.Modi = new System.Windows.Forms.Button();
            this.Inser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dire = new System.Windows.Forms.TextBox();
            this.metros = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Contenido_Base = new System.Windows.Forms.DataGridView();
            this.id_ac = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(743, 545);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 58;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Precio";
            // 
            // list_tipo_terreno
            // 
            this.list_tipo_terreno.FormattingEnabled = true;
            this.list_tipo_terreno.Location = new System.Drawing.Point(306, 183);
            this.list_tipo_terreno.Name = "list_tipo_terreno";
            this.list_tipo_terreno.Size = new System.Drawing.Size(100, 30);
            this.list_tipo_terreno.TabIndex = 52;
            // 
            // DEl
            // 
            this.DEl.Location = new System.Drawing.Point(306, 228);
            this.DEl.Name = "DEl";
            this.DEl.Size = new System.Drawing.Size(100, 23);
            this.DEl.TabIndex = 46;
            this.DEl.Text = "Eliminar";
            this.DEl.UseVisualStyleBackColor = true;
            this.DEl.Click += new System.EventHandler(this.DEl_Click);
            // 
            // Modi
            // 
            this.Modi.Location = new System.Drawing.Point(181, 228);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(100, 23);
            this.Modi.TabIndex = 45;
            this.Modi.Text = "Modificar";
            this.Modi.UseVisualStyleBackColor = true;
            this.Modi.Click += new System.EventHandler(this.Modi_Click);
            // 
            // Inser
            // 
            this.Inser.Location = new System.Drawing.Point(62, 228);
            this.Inser.Name = "Inser";
            this.Inser.Size = new System.Drawing.Size(100, 23);
            this.Inser.TabIndex = 44;
            this.Inser.Text = "Agregar";
            this.Inser.UseVisualStyleBackColor = true;
            this.Inser.Click += new System.EventHandler(this.Inser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo de terreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Metros cuadrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo";
            // 
            // Dire
            // 
            this.Dire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Dire.Location = new System.Drawing.Point(586, 183);
            this.Dire.Name = "Dire";
            this.Dire.Size = new System.Drawing.Size(226, 20);
            this.Dire.TabIndex = 43;
            // 
            // metros
            // 
            this.metros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.metros.Location = new System.Drawing.Point(181, 183);
            this.metros.Name = "metros";
            this.metros.Size = new System.Drawing.Size(100, 20);
            this.metros.TabIndex = 41;
            // 
            // tipo
            // 
            this.tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipo.Location = new System.Drawing.Point(62, 183);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(100, 20);
            this.tipo.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Contenido_Base);
            this.groupBox1.Location = new System.Drawing.Point(62, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 255);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terrenos";
            // 
            // Contenido_Base
            // 
            this.Contenido_Base.AllowUserToAddRows = false;
            this.Contenido_Base.AllowUserToDeleteRows = false;
            this.Contenido_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contenido_Base.Location = new System.Drawing.Point(5, 19);
            this.Contenido_Base.Name = "Contenido_Base";
            this.Contenido_Base.ReadOnly = true;
            this.Contenido_Base.Size = new System.Drawing.Size(745, 218);
            this.Contenido_Base.TabIndex = 0;
            this.Contenido_Base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_ac
            // 
            this.id_ac.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.id_ac.Enabled = false;
            this.id_ac.HideSelection = false;
            this.id_ac.Location = new System.Drawing.Point(25, 183);
            this.id_ac.Name = "id_ac";
            this.id_ac.Size = new System.Drawing.Size(19, 20);
            this.id_ac.TabIndex = 51;
            this.id_ac.TabStop = false;
            // 
            // precio
            // 
            this.precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.precio.Location = new System.Drawing.Point(438, 183);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(685, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 125);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "TERRENOS";
            // 
            // Form_terreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_tipo_terreno);
            this.Controls.Add(this.DEl);
            this.Controls.Add(this.Modi);
            this.Controls.Add(this.Inser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dire);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.metros);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.id_ac);
            this.Name = "Form_terreno";
            this.Text = "Terrenos       ---- BIENES RAÍCES TLAXIACO----";
            this.Load += new System.EventHandler(this.Form_terreno_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox list_tipo_terreno;
        private System.Windows.Forms.Button DEl;
        private System.Windows.Forms.Button Modi;
        private System.Windows.Forms.Button Inser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Dire;
        private System.Windows.Forms.TextBox metros;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Contenido_Base;
        private System.Windows.Forms.TextBox id_ac;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}