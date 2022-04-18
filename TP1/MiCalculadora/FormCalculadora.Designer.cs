namespace MiCalculadora
{
    partial class FormCalculadora
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirABinario = new System.Windows.Forms.Button();
            this.txtbOperando1 = new System.Windows.Forms.TextBox();
            this.txtbOperando2 = new System.Windows.Forms.TextBox();
            this.btnConvetirADecimal = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lst_Operaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 324);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(158, 49);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btn_Operar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(336, 324);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(182, 52);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btnConvertirABinario
            // 
            this.btnConvertirABinario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertirABinario.Location = new System.Drawing.Point(12, 396);
            this.btnConvertirABinario.Name = "btnConvertirABinario";
            this.btnConvertirABinario.Size = new System.Drawing.Size(239, 49);
            this.btnConvertirABinario.TabIndex = 8;
            this.btnConvertirABinario.Text = "Convertir a Binario";
            this.btnConvertirABinario.UseVisualStyleBackColor = true;
            this.btnConvertirABinario.Click += new System.EventHandler(this.btn_ConvertirABinario_Click);
            // 
            // txtbOperando1
            // 
            this.txtbOperando1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbOperando1.Location = new System.Drawing.Point(12, 261);
            this.txtbOperando1.Multiline = true;
            this.txtbOperando1.Name = "txtbOperando1";
            this.txtbOperando1.Size = new System.Drawing.Size(158, 38);
            this.txtbOperando1.TabIndex = 0;
            this.txtbOperando1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbOperando2
            // 
            this.txtbOperando2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbOperando2.Location = new System.Drawing.Point(356, 261);
            this.txtbOperando2.Multiline = true;
            this.txtbOperando2.Name = "txtbOperando2";
            this.txtbOperando2.Size = new System.Drawing.Size(162, 38);
            this.txtbOperando2.TabIndex = 2;
            this.txtbOperando2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConvetirADecimal
            // 
            this.btnConvetirADecimal.Location = new System.Drawing.Point(269, 396);
            this.btnConvetirADecimal.Name = "btnConvetirADecimal";
            this.btnConvetirADecimal.Size = new System.Drawing.Size(249, 49);
            this.btnConvetirADecimal.TabIndex = 9;
            this.btnConvetirADecimal.Text = "Convertir a Decimal";
            this.btnConvetirADecimal.UseVisualStyleBackColor = true;
            this.btnConvetirADecimal.Click += new System.EventHandler(this.btn_ConvetirADecimal_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 324);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 49);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 100);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(532, 120);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "0";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownHeight = 120;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.IntegralHeight = false;
            this.cmbOperador.Location = new System.Drawing.Point(205, 261);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 38);
            this.cmbOperador.TabIndex = 10;
            // 
            // lst_Operaciones
            // 
            this.lst_Operaciones.AccessibleName = "lstOperaciones";
            this.lst_Operaciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_Operaciones.FormattingEnabled = true;
            this.lst_Operaciones.ItemHeight = 28;
            this.lst_Operaciones.Location = new System.Drawing.Point(571, 54);
            this.lst_Operaciones.MultiColumn = true;
            this.lst_Operaciones.Name = "lst_Operaciones";
            this.lst_Operaciones.Size = new System.Drawing.Size(346, 452);
            this.lst_Operaciones.TabIndex = 11;
            // 
            // FormCalculadora
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(919, 509);
            this.Controls.Add(this.lst_Operaciones);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvetirADecimal);
            this.Controls.Add(this.txtbOperando2);
            this.Controls.Add(this.txtbOperando1);
            this.Controls.Add(this.btnConvertirABinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnOperar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Martin Marinovich del Curso 2ºE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConvertirABinario;
        private System.Windows.Forms.TextBox txtbOperando1;
        public System.Windows.Forms.TextBox txtbOperando2;
        private System.Windows.Forms.Button btnConvetirADecimal;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        public System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.ListBox lst_Operaciones;
    }
}