
namespace BIENES_RAICES
{
    partial class Form_pagos
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
            this.cerrar = new System.Windows.Forms.Button();
            this.DEl = new System.Windows.Forms.Button();
            this.Modi = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.id_ac = new System.Windows.Forms.TextBox();
            this.data_tipo_terreno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.t_forma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_tipo_terreno)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(259, 373);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(54, 22);
            this.cerrar.TabIndex = 47;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // DEl
            // 
            this.DEl.Location = new System.Drawing.Point(223, 195);
            this.DEl.Name = "DEl";
            this.DEl.Size = new System.Drawing.Size(62, 23);
            this.DEl.TabIndex = 46;
            this.DEl.Text = "Eliminar";
            this.DEl.UseVisualStyleBackColor = true;
            this.DEl.Click += new System.EventHandler(this.DEl_Click);
            // 
            // Modi
            // 
            this.Modi.Location = new System.Drawing.Point(133, 195);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(62, 23);
            this.Modi.TabIndex = 45;
            this.Modi.Text = "Modificar";
            this.Modi.UseVisualStyleBackColor = true;
            this.Modi.Click += new System.EventHandler(this.Modi_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(41, 195);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(62, 23);
            this.Insert.TabIndex = 44;
            this.Insert.Text = "Agregar";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Agegar_Click);
            // 
            // id_ac
            // 
            this.id_ac.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.id_ac.Enabled = false;
            this.id_ac.HideSelection = false;
            this.id_ac.Location = new System.Drawing.Point(16, 132);
            this.id_ac.Name = "id_ac";
            this.id_ac.Size = new System.Drawing.Size(19, 20);
            this.id_ac.TabIndex = 43;
            this.id_ac.TabStop = false;
            // 
            // data_tipo_terreno
            // 
            this.data_tipo_terreno.AllowUserToDeleteRows = false;
            this.data_tipo_terreno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tipo_terreno.Location = new System.Drawing.Point(41, 247);
            this.data_tipo_terreno.Name = "data_tipo_terreno";
            this.data_tipo_terreno.ReadOnly = true;
            this.data_tipo_terreno.Size = new System.Drawing.Size(244, 101);
            this.data_tipo_terreno.TabIndex = 42;
            this.data_tipo_terreno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tipo_terreno_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "FORMA DE PAGO";
            // 
            // t_forma
            // 
            this.t_forma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.t_forma.Location = new System.Drawing.Point(41, 132);
            this.t_forma.Name = "t_forma";
            this.t_forma.Size = new System.Drawing.Size(100, 20);
            this.t_forma.TabIndex = 40;
            // 
            // Form_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.DEl);
            this.Controls.Add(this.Modi);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.id_ac);
            this.Controls.Add(this.data_tipo_terreno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_forma);
            this.Name = "Form_pagos";
            this.Text = "FORMA DE PAGO";
            this.Load += new System.EventHandler(this.Form_pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_tipo_terreno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button DEl;
        private System.Windows.Forms.Button Modi;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox id_ac;
        private System.Windows.Forms.DataGridView data_tipo_terreno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_forma;
    }
}