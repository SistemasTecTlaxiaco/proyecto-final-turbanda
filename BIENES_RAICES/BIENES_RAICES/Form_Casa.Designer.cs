
namespace BIENES_RAICES
{
    partial class Form_Casa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Casa));
            this.cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DEl = new System.Windows.Forms.Button();
            this.Modi = new System.Windows.Forms.Button();
            this.Inser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Contenido_Base = new System.Windows.Forms.DataGridView();
            this.id_ac = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.list_sala = new System.Windows.Forms.ListBox();
            this.list_comedor = new System.Windows.Forms.ListBox();
            this.list_banio = new System.Windows.Forms.ListBox();
            this.list_recamara = new System.Windows.Forms.ListBox();
            this.list_cosina = new System.Windows.Forms.ListBox();
            this.list_jardin = new System.Windows.Forms.ListBox();
            this.list_cochera = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(875, 547);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 60;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 127);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cosinas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Recamaras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Baños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(358, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "CASAS";
            // 
            // DEl
            // 
            this.DEl.Location = new System.Drawing.Point(297, 242);
            this.DEl.Name = "DEl";
            this.DEl.Size = new System.Drawing.Size(100, 23);
            this.DEl.TabIndex = 46;
            this.DEl.Text = "Eliminar";
            this.DEl.UseVisualStyleBackColor = true;
            this.DEl.Click += new System.EventHandler(this.DEl_Click);
            // 
            // Modi
            // 
            this.Modi.Location = new System.Drawing.Point(172, 242);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(100, 23);
            this.Modi.TabIndex = 45;
            this.Modi.Text = "Modificar";
            this.Modi.UseVisualStyleBackColor = true;
            this.Modi.Click += new System.EventHandler(this.Modi_Click);
            // 
            // Inser
            // 
            this.Inser.Location = new System.Drawing.Point(53, 242);
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
            this.label4.Location = new System.Drawing.Point(554, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Jardin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Comedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Sala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo";
            // 
            // tipo
            // 
            this.tipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tipo.Location = new System.Drawing.Point(53, 207);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(100, 20);
            this.tipo.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Contenido_Base);
            this.groupBox1.Location = new System.Drawing.Point(53, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 255);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // Contenido_Base
            // 
            this.Contenido_Base.AllowUserToAddRows = false;
            this.Contenido_Base.AllowUserToDeleteRows = false;
            this.Contenido_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contenido_Base.Location = new System.Drawing.Point(6, 19);
            this.Contenido_Base.Name = "Contenido_Base";
            this.Contenido_Base.ReadOnly = true;
            this.Contenido_Base.Size = new System.Drawing.Size(861, 218);
            this.Contenido_Base.TabIndex = 0;
            this.Contenido_Base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_ac
            // 
            this.id_ac.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.id_ac.Enabled = false;
            this.id_ac.HideSelection = false;
            this.id_ac.Location = new System.Drawing.Point(16, 197);
            this.id_ac.Name = "id_ac";
            this.id_ac.Size = new System.Drawing.Size(19, 20);
            this.id_ac.TabIndex = 51;
            this.id_ac.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cochera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Precio";
            // 
            // precio
            // 
            this.precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.precio.Location = new System.Drawing.Point(732, 207);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(106, 20);
            this.precio.TabIndex = 43;
            // 
            // list_sala
            // 
            this.list_sala.FormattingEnabled = true;
            this.list_sala.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_sala.Location = new System.Drawing.Point(172, 197);
            this.list_sala.Name = "list_sala";
            this.list_sala.Size = new System.Drawing.Size(44, 30);
            this.list_sala.TabIndex = 63;
            // 
            // list_comedor
            // 
            this.list_comedor.FormattingEnabled = true;
            this.list_comedor.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_comedor.Location = new System.Drawing.Point(242, 197);
            this.list_comedor.Name = "list_comedor";
            this.list_comedor.Size = new System.Drawing.Size(46, 30);
            this.list_comedor.TabIndex = 64;
            // 
            // list_banio
            // 
            this.list_banio.FormattingEnabled = true;
            this.list_banio.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_banio.Location = new System.Drawing.Point(316, 197);
            this.list_banio.Name = "list_banio";
            this.list_banio.Size = new System.Drawing.Size(46, 30);
            this.list_banio.TabIndex = 65;
            // 
            // list_recamara
            // 
            this.list_recamara.FormattingEnabled = true;
            this.list_recamara.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.list_recamara.Location = new System.Drawing.Point(391, 197);
            this.list_recamara.Name = "list_recamara";
            this.list_recamara.Size = new System.Drawing.Size(46, 30);
            this.list_recamara.TabIndex = 66;
            // 
            // list_cosina
            // 
            this.list_cosina.FormattingEnabled = true;
            this.list_cosina.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_cosina.Location = new System.Drawing.Point(474, 197);
            this.list_cosina.Name = "list_cosina";
            this.list_cosina.Size = new System.Drawing.Size(46, 30);
            this.list_cosina.TabIndex = 67;
            // 
            // list_jardin
            // 
            this.list_jardin.FormattingEnabled = true;
            this.list_jardin.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_jardin.Location = new System.Drawing.Point(557, 197);
            this.list_jardin.Name = "list_jardin";
            this.list_jardin.Size = new System.Drawing.Size(46, 30);
            this.list_jardin.TabIndex = 68;
            // 
            // list_cochera
            // 
            this.list_cochera.FormattingEnabled = true;
            this.list_cochera.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.list_cochera.Location = new System.Drawing.Point(637, 197);
            this.list_cochera.Name = "list_cochera";
            this.list_cochera.Size = new System.Drawing.Size(46, 30);
            this.list_cochera.TabIndex = 69;
            // 
            // Form_Casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 582);
            this.Controls.Add(this.list_cochera);
            this.Controls.Add(this.list_jardin);
            this.Controls.Add(this.list_cosina);
            this.Controls.Add(this.list_recamara);
            this.Controls.Add(this.list_banio);
            this.Controls.Add(this.list_comedor);
            this.Controls.Add(this.list_sala);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DEl);
            this.Controls.Add(this.Modi);
            this.Controls.Add(this.Inser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.id_ac);
            this.Name = "Form_Casa";
            this.Text = "Casa           ---- BIENES RAÍCES TLAXIACO----";
            this.Load += new System.EventHandler(this.Form_Casa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenido_Base)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DEl;
        private System.Windows.Forms.Button Modi;
        private System.Windows.Forms.Button Inser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Contenido_Base;
        private System.Windows.Forms.TextBox id_ac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.ListBox list_sala;
        private System.Windows.Forms.ListBox list_comedor;
        private System.Windows.Forms.ListBox list_banio;
        private System.Windows.Forms.ListBox list_recamara;
        private System.Windows.Forms.ListBox list_cosina;
        private System.Windows.Forms.ListBox list_jardin;
        private System.Windows.Forms.ListBox list_cochera;
    }
}