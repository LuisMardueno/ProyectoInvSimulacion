﻿
namespace ProyectoSimulacion
{
    partial class Problema2
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrarJuego = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtApuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJuegos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridJuego = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridNumeros = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label31 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.Button();
            this.txtBorrar = new System.Windows.Forms.Button();
            this.btnGenNum = new System.Windows.Forms.Button();
            this.txtNumGen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtPerdidas = new System.Windows.Forms.Label();
            this.txtGanadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "VOLADOS (Aguila o Sol)";
            // 
            // btnBorrarJuego
            // 
            this.btnBorrarJuego.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnBorrarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarJuego.Location = new System.Drawing.Point(487, 464);
            this.btnBorrarJuego.Name = "btnBorrarJuego";
            this.btnBorrarJuego.Size = new System.Drawing.Size(132, 30);
            this.btnBorrarJuego.TabIndex = 68;
            this.btnBorrarJuego.Text = "Borrar Juego";
            this.btnBorrarJuego.UseVisualStyleBackColor = false;
            this.btnBorrarJuego.Click += new System.EventHandler(this.btnBorrarJuego_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(487, 428);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(132, 30);
            this.btnJugar.TabIndex = 67;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Dinero inicial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 70;
            this.label4.Text = "APUESTA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(192, 352);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(64, 20);
            this.txtMonto.TabIndex = 71;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtApuesta
            // 
            this.txtApuesta.Location = new System.Drawing.Point(192, 386);
            this.txtApuesta.Name = "txtApuesta";
            this.txtApuesta.Size = new System.Drawing.Size(64, 20);
            this.txtApuesta.TabIndex = 73;
            this.txtApuesta.TextChanged += new System.EventHandler(this.txtApuesta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Apuesta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtJuegos
            // 
            this.txtJuegos.Location = new System.Drawing.Point(192, 317);
            this.txtJuegos.Name = "txtJuegos";
            this.txtJuegos.Size = new System.Drawing.Size(64, 20);
            this.txtJuegos.TabIndex = 75;
            this.txtJuegos.TextChanged += new System.EventHandler(this.txtJuegos_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Numero de juegos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridJuego
            // 
            this.dataGridJuego.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.VD,
            this.Column3,
            this.AP});
            this.dataGridJuego.Location = new System.Drawing.Point(13, 428);
            this.dataGridJuego.Name = "dataGridJuego";
            this.dataGridJuego.Size = new System.Drawing.Size(468, 210);
            this.dataGridJuego.TabIndex = 76;
            this.dataGridJuego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJuego_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NumGenerados";
            this.Column2.Name = "Column2";
            // 
            // VD
            // 
            this.VD.HeaderText = "V o D";
            this.VD.Name = "VD";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dinero";
            this.Column3.Name = "Column3";
            // 
            // AP
            // 
            this.AP.HeaderText = "Apuesta";
            this.AP.Name = "AP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 582);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 77;
            this.label7.Text = "DERROTAS:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(487, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "VICTORIAS:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridNumeros
            // 
            this.dataGridNumeros.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.NumeroAleatorio});
            this.dataGridNumeros.Location = new System.Drawing.Point(408, 54);
            this.dataGridNumeros.Name = "dataGridNumeros";
            this.dataGridNumeros.Size = new System.Drawing.Size(235, 168);
            this.dataGridNumeros.TabIndex = 97;
            this.dataGridNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNumeros_CellContentClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Numeros";
            this.Nume.Name = "Nume";
            // 
            // NumeroAleatorio
            // 
            this.NumeroAleatorio.HeaderText = "Numero Aleatorio";
            this.NumeroAleatorio.Name = "NumeroAleatorio";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(24, 51);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(368, 31);
            this.label31.TabIndex = 147;
            this.label31.Text = "Generador pseudoaleatorio";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 24);
            this.label12.TabIndex = 146;
            this.label12.Text = "Num a generar=";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(99, 196);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 145;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(99, 161);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 20);
            this.txtXo.TabIndex = 144;
            this.txtXo.TextChanged += new System.EventHandler(this.txtXo_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(99, 126);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 143;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(99, 90);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 142;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 24);
            this.label13.TabIndex = 141;
            this.label13.Text = "M=";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 24);
            this.label14.TabIndex = 140;
            this.label14.Text = "Xo=";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(57, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 24);
            this.label15.TabIndex = 139;
            this.label15.Text = "C=";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(57, 86);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(36, 24);
            this.lblA.TabIndex = 138;
            this.lblA.Text = "A=";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.txtMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(519, -2);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(122, 48);
            this.txtMenu.TabIndex = 137;
            this.txtMenu.Text = "Menu";
            this.txtMenu.UseVisualStyleBackColor = false;
            this.txtMenu.Click += new System.EventHandler(this.txtMenu_Click_1);
            // 
            // txtBorrar
            // 
            this.txtBorrar.BackColor = System.Drawing.Color.PaleGreen;
            this.txtBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrar.Location = new System.Drawing.Point(225, 126);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(132, 30);
            this.txtBorrar.TabIndex = 136;
            this.txtBorrar.Text = "Borrar";
            this.txtBorrar.UseVisualStyleBackColor = false;
            this.txtBorrar.Click += new System.EventHandler(this.txtBorrar_Click_1);
            // 
            // btnGenNum
            // 
            this.btnGenNum.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGenNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenNum.Location = new System.Drawing.Point(227, 90);
            this.btnGenNum.Name = "btnGenNum";
            this.btnGenNum.Size = new System.Drawing.Size(132, 30);
            this.btnGenNum.TabIndex = 135;
            this.btnGenNum.Text = "Generar Numeros";
            this.btnGenNum.UseVisualStyleBackColor = false;
            this.btnGenNum.Click += new System.EventHandler(this.btnGenNum_Click_1);
            // 
            // txtNumGen
            // 
            this.txtNumGen.Location = new System.Drawing.Point(177, 227);
            this.txtNumGen.Name = "txtNumGen";
            this.txtNumGen.Size = new System.Drawing.Size(100, 20);
            this.txtNumGen.TabIndex = 134;
            this.txtNumGen.TextChanged += new System.EventHandler(this.txtNumGen_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 48);
            this.panel1.TabIndex = 148;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(510, 625);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 149;
            // 
            // txtPerdidas
            // 
            this.txtPerdidas.AutoSize = true;
            this.txtPerdidas.BackColor = System.Drawing.Color.Transparent;
            this.txtPerdidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdidas.Location = new System.Drawing.Point(603, 582);
            this.txtPerdidas.Name = "txtPerdidas";
            this.txtPerdidas.Size = new System.Drawing.Size(0, 18);
            this.txtPerdidas.TabIndex = 150;
            this.txtPerdidas.Click += new System.EventHandler(this.txtPerdidas_Click);
            // 
            // txtGanadas
            // 
            this.txtGanadas.AutoSize = true;
            this.txtGanadas.BackColor = System.Drawing.Color.Transparent;
            this.txtGanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanadas.Location = new System.Drawing.Point(603, 548);
            this.txtGanadas.Name = "txtGanadas";
            this.txtGanadas.Size = new System.Drawing.Size(0, 18);
            this.txtGanadas.TabIndex = 151;
            this.txtGanadas.Click += new System.EventHandler(this.txtGanadas_Click);
            // 
            // Problema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(646, 675);
            this.Controls.Add(this.txtGanadas);
            this.Controls.Add(this.txtPerdidas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.btnGenNum);
            this.Controls.Add(this.txtNumGen);
            this.Controls.Add(this.dataGridNumeros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridJuego);
            this.Controls.Add(this.txtJuegos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBorrarJuego);
            this.Controls.Add(this.btnJugar);
            this.Name = "Problema2";
            this.Text = "Volados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrarJuego;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtApuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJuegos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridJuego;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAleatorio;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button txtMenu;
        private System.Windows.Forms.Button txtBorrar;
        private System.Windows.Forms.Button btnGenNum;
        private System.Windows.Forms.TextBox txtNumGen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label txtPerdidas;
        private System.Windows.Forms.Label txtGanadas;
    }
}