namespace PraticadeEnsinoDeComputabilidade
{
    partial class Form1
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
            this.lblValoresVariaveis = new System.Windows.Forms.Label();
            this.txtValoresVariaveis = new System.Windows.Forms.TextBox();
            this.lblFormaInfixa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFormaIndefinida = new System.Windows.Forms.TextBox();
            this.lblFormaIndefinida = new System.Windows.Forms.Label();
            this.btnConverterFormaIndefinida = new System.Windows.Forms.Button();
            this.btnConverterInfixa = new System.Windows.Forms.Button();
            this.btnConverterPosFixa = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtFormaPosfixa = new System.Windows.Forms.TextBox();
            this.txtFormaInfixa = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPosFixa = new System.Windows.Forms.Label();
            this.btnCalcularInfixa = new System.Windows.Forms.Button();
            this.btnCalcularPosfixa = new System.Windows.Forms.Button();
            this.btnCalcularIndefinada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValoresVariaveis
            // 
            this.lblValoresVariaveis.AutoSize = true;
            this.lblValoresVariaveis.Location = new System.Drawing.Point(20, 21);
            this.lblValoresVariaveis.Name = "lblValoresVariaveis";
            this.lblValoresVariaveis.Size = new System.Drawing.Size(359, 13);
            this.lblValoresVariaveis.TabIndex = 0;
            this.lblValoresVariaveis.Text = "Insira os valores das variaveis separados por \",\" (Virgula). Ex : 10,20,30,40";
            // 
            // txtValoresVariaveis
            // 
            this.txtValoresVariaveis.Location = new System.Drawing.Point(34, 37);
            this.txtValoresVariaveis.Name = "txtValoresVariaveis";
            this.txtValoresVariaveis.Size = new System.Drawing.Size(345, 20);
            this.txtValoresVariaveis.TabIndex = 1;
            // 
            // lblFormaInfixa
            // 
            this.lblFormaInfixa.AutoSize = true;
            this.lblFormaInfixa.Location = new System.Drawing.Point(8, 0);
            this.lblFormaInfixa.Name = "lblFormaInfixa";
            this.lblFormaInfixa.Size = new System.Drawing.Size(64, 13);
            this.lblFormaInfixa.TabIndex = 2;
            this.lblFormaInfixa.Text = "Forma Infixa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcularIndefinada);
            this.panel1.Controls.Add(this.btnCalcularPosfixa);
            this.panel1.Controls.Add(this.btnCalcularInfixa);
            this.panel1.Controls.Add(this.txtFormaIndefinida);
            this.panel1.Controls.Add(this.lblFormaIndefinida);
            this.panel1.Controls.Add(this.btnConverterFormaIndefinida);
            this.panel1.Controls.Add(this.btnConverterInfixa);
            this.panel1.Controls.Add(this.btnConverterPosFixa);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.txtFormaPosfixa);
            this.panel1.Controls.Add(this.txtFormaInfixa);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.lblPosFixa);
            this.panel1.Controls.Add(this.lblFormaInfixa);
            this.panel1.Location = new System.Drawing.Point(23, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 292);
            this.panel1.TabIndex = 3;
            // 
            // txtFormaIndefinida
            // 
            this.txtFormaIndefinida.Location = new System.Drawing.Point(11, 176);
            this.txtFormaIndefinida.Name = "txtFormaIndefinida";
            this.txtFormaIndefinida.Size = new System.Drawing.Size(170, 20);
            this.txtFormaIndefinida.TabIndex = 12;
            // 
            // lblFormaIndefinida
            // 
            this.lblFormaIndefinida.AutoSize = true;
            this.lblFormaIndefinida.Location = new System.Drawing.Point(8, 160);
            this.lblFormaIndefinida.Name = "lblFormaIndefinida";
            this.lblFormaIndefinida.Size = new System.Drawing.Size(81, 13);
            this.lblFormaIndefinida.TabIndex = 11;
            this.lblFormaIndefinida.Text = "Infixa? Posfixa?";
            // 
            // btnConverterFormaIndefinida
            // 
            this.btnConverterFormaIndefinida.Location = new System.Drawing.Point(187, 173);
            this.btnConverterFormaIndefinida.Name = "btnConverterFormaIndefinida";
            this.btnConverterFormaIndefinida.Size = new System.Drawing.Size(166, 23);
            this.btnConverterFormaIndefinida.TabIndex = 10;
            this.btnConverterFormaIndefinida.Text = "Converter para Infixa ou Posfixa";
            this.btnConverterFormaIndefinida.UseVisualStyleBackColor = true;
            this.btnConverterFormaIndefinida.Click += new System.EventHandler(this.btnConverterFormaIndefinida_Click);
            // 
            // btnConverterInfixa
            // 
            this.btnConverterInfixa.Location = new System.Drawing.Point(217, 97);
            this.btnConverterInfixa.Name = "btnConverterInfixa";
            this.btnConverterInfixa.Size = new System.Drawing.Size(136, 23);
            this.btnConverterInfixa.TabIndex = 9;
            this.btnConverterInfixa.Text = "Converter para Infixa";
            this.btnConverterInfixa.UseVisualStyleBackColor = true;
            this.btnConverterInfixa.Click += new System.EventHandler(this.btnConverterInfixa_Click);
            // 
            // btnConverterPosFixa
            // 
            this.btnConverterPosFixa.Location = new System.Drawing.Point(217, 16);
            this.btnConverterPosFixa.Name = "btnConverterPosFixa";
            this.btnConverterPosFixa.Size = new System.Drawing.Size(136, 23);
            this.btnConverterPosFixa.TabIndex = 8;
            this.btnConverterPosFixa.Text = "Converter para Posfixa";
            this.btnConverterPosFixa.UseVisualStyleBackColor = true;
            this.btnConverterPosFixa.Click += new System.EventHandler(this.btnConverterPosFixa_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(64, 262);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // txtFormaPosfixa
            // 
            this.txtFormaPosfixa.Location = new System.Drawing.Point(11, 97);
            this.txtFormaPosfixa.Name = "txtFormaPosfixa";
            this.txtFormaPosfixa.Size = new System.Drawing.Size(172, 20);
            this.txtFormaPosfixa.TabIndex = 6;
            // 
            // txtFormaInfixa
            // 
            this.txtFormaInfixa.Location = new System.Drawing.Point(11, 16);
            this.txtFormaInfixa.Name = "txtFormaInfixa";
            this.txtFormaInfixa.Size = new System.Drawing.Size(172, 20);
            this.txtFormaInfixa.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(3, 269);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // lblPosFixa
            // 
            this.lblPosFixa.AutoSize = true;
            this.lblPosFixa.Location = new System.Drawing.Point(8, 81);
            this.lblPosFixa.Name = "lblPosFixa";
            this.lblPosFixa.Size = new System.Drawing.Size(73, 13);
            this.lblPosFixa.TabIndex = 3;
            this.lblPosFixa.Text = "Forma Posfixa";
            // 
            // btnCalcularInfixa
            // 
            this.btnCalcularInfixa.Location = new System.Drawing.Point(11, 42);
            this.btnCalcularInfixa.Name = "btnCalcularInfixa";
            this.btnCalcularInfixa.Size = new System.Drawing.Size(75, 19);
            this.btnCalcularInfixa.TabIndex = 14;
            this.btnCalcularInfixa.Text = "Calcular";
            this.btnCalcularInfixa.UseVisualStyleBackColor = true;
            this.btnCalcularInfixa.Click += new System.EventHandler(this.btnCalcularInfixa_Click);
            // 
            // btnCalcularPosfixa
            // 
            this.btnCalcularPosfixa.Location = new System.Drawing.Point(11, 123);
            this.btnCalcularPosfixa.Name = "btnCalcularPosfixa";
            this.btnCalcularPosfixa.Size = new System.Drawing.Size(78, 19);
            this.btnCalcularPosfixa.TabIndex = 15;
            this.btnCalcularPosfixa.Text = "Calcular";
            this.btnCalcularPosfixa.UseVisualStyleBackColor = true;
            this.btnCalcularPosfixa.Click += new System.EventHandler(this.btnCalcularPosfixa_Click);
            // 
            // btnCalcularIndefinada
            // 
            this.btnCalcularIndefinada.Location = new System.Drawing.Point(11, 202);
            this.btnCalcularIndefinada.Name = "btnCalcularIndefinada";
            this.btnCalcularIndefinada.Size = new System.Drawing.Size(78, 19);
            this.btnCalcularIndefinada.TabIndex = 16;
            this.btnCalcularIndefinada.Text = "Calcular";
            this.btnCalcularIndefinada.UseVisualStyleBackColor = true;
            this.btnCalcularIndefinada.Click += new System.EventHandler(this.btnCalcularIndefinada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValoresVariaveis);
            this.Controls.Add(this.lblValoresVariaveis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValoresVariaveis;
        private System.Windows.Forms.TextBox txtValoresVariaveis;
        private System.Windows.Forms.Label lblFormaInfixa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtFormaPosfixa;
        private System.Windows.Forms.TextBox txtFormaInfixa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPosFixa;
        private System.Windows.Forms.Button btnConverterInfixa;
        private System.Windows.Forms.Button btnConverterPosFixa;
        private System.Windows.Forms.TextBox txtFormaIndefinida;
        private System.Windows.Forms.Label lblFormaIndefinida;
        private System.Windows.Forms.Button btnConverterFormaIndefinida;
        private System.Windows.Forms.Button btnCalcularIndefinada;
        private System.Windows.Forms.Button btnCalcularPosfixa;
        private System.Windows.Forms.Button btnCalcularInfixa;
    }
}

