﻿namespace UI
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtNOME = new System.Windows.Forms.TabPage();
            this.cbESTADO = new System.Windows.Forms.ComboBox();
            this.txtFONE2 = new System.Windows.Forms.MaskedTextBox();
            this.txtFONE1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtBAIRRO = new System.Windows.Forms.TextBox();
            this.txtDATA_NASC = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtENDERECO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOD_CLIENTE = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMASCINO = new System.Windows.Forms.RadioButton();
            this.rbFEMENINO = new System.Windows.Forms.RadioButton();
            this.ckRESTRICAO = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btGRAVAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btFECHAR = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.txtNOME.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.txtNOME);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // txtNOME
            // 
            this.txtNOME.Controls.Add(this.panel2);
            this.txtNOME.Controls.Add(this.ckRESTRICAO);
            this.txtNOME.Controls.Add(this.groupBox1);
            this.txtNOME.Controls.Add(this.cbESTADO);
            this.txtNOME.Controls.Add(this.txtFONE2);
            this.txtNOME.Controls.Add(this.txtFONE1);
            this.txtNOME.Controls.Add(this.txtCIDADE);
            this.txtNOME.Controls.Add(this.txtCEP);
            this.txtNOME.Controls.Add(this.txtBAIRRO);
            this.txtNOME.Controls.Add(this.txtDATA_NASC);
            this.txtNOME.Controls.Add(this.txtCPF);
            this.txtNOME.Controls.Add(this.txtENDERECO);
            this.txtNOME.Controls.Add(this.textBox1);
            this.txtNOME.Controls.Add(this.label7);
            this.txtNOME.Controls.Add(this.label10);
            this.txtNOME.Controls.Add(this.label9);
            this.txtNOME.Controls.Add(this.label8);
            this.txtNOME.Controls.Add(this.CEP);
            this.txtNOME.Controls.Add(this.label6);
            this.txtNOME.Controls.Add(this.label5);
            this.txtNOME.Controls.Add(this.label4);
            this.txtNOME.Controls.Add(this.label3);
            this.txtNOME.Controls.Add(this.label2);
            this.txtNOME.Controls.Add(this.txtCOD_CLIENTE);
            this.txtNOME.Controls.Add(this.label1);
            this.txtNOME.Controls.Add(this.panel1);
            this.txtNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(4, 22);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Padding = new System.Windows.Forms.Padding(3);
            this.txtNOME.Size = new System.Drawing.Size(656, 335);
            this.txtNOME.TabIndex = 0;
            this.txtNOME.Text = "Cadastro";
            this.txtNOME.UseVisualStyleBackColor = true;
            // 
            // cbESTADO
            // 
            this.cbESTADO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbESTADO.FormattingEnabled = true;
            this.cbESTADO.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbESTADO.Location = new System.Drawing.Point(540, 195);
            this.cbESTADO.Name = "cbESTADO";
            this.cbESTADO.Size = new System.Drawing.Size(80, 21);
            this.cbESTADO.TabIndex = 10;
            this.cbESTADO.SelectedIndexChanged += new System.EventHandler(this.cbESTADO_SelectedIndexChanged);
            // 
            // txtFONE2
            // 
            this.txtFONE2.Location = new System.Drawing.Point(171, 254);
            this.txtFONE2.Mask = "(00) 0000-0000";
            this.txtFONE2.Name = "txtFONE2";
            this.txtFONE2.Size = new System.Drawing.Size(100, 20);
            this.txtFONE2.TabIndex = 12;
            // 
            // txtFONE1
            // 
            this.txtFONE1.Location = new System.Drawing.Point(20, 254);
            this.txtFONE1.Mask = "(00) 0000-0000";
            this.txtFONE1.Name = "txtFONE1";
            this.txtFONE1.Size = new System.Drawing.Size(100, 20);
            this.txtFONE1.TabIndex = 11;
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCIDADE.Location = new System.Drawing.Point(171, 195);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(311, 20);
            this.txtCIDADE.TabIndex = 9;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(20, 195);
            this.txtCEP.Mask = "00,000,-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 8;
            // 
            // txtBAIRRO
            // 
            this.txtBAIRRO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBAIRRO.Location = new System.Drawing.Point(370, 139);
            this.txtBAIRRO.Name = "txtBAIRRO";
            this.txtBAIRRO.Size = new System.Drawing.Size(250, 20);
            this.txtBAIRRO.TabIndex = 7;
            // 
            // txtDATA_NASC
            // 
            this.txtDATA_NASC.Location = new System.Drawing.Point(540, 83);
            this.txtDATA_NASC.Mask = "00/00/0000";
            this.txtDATA_NASC.Name = "txtDATA_NASC";
            this.txtDATA_NASC.Size = new System.Drawing.Size(80, 20);
            this.txtDATA_NASC.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(370, 83);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(112, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtENDERECO
            // 
            this.txtENDERECO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtENDERECO.Location = new System.Drawing.Point(20, 139);
            this.txtENDERECO.Name = "txtENDERECO";
            this.txtENDERECO.Size = new System.Drawing.Size(300, 20);
            this.txtENDERECO.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(20, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fone 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fone 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cidade";
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP.Location = new System.Drawing.Point(16, 179);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(31, 13);
            this.CEP.TabIndex = 8;
            this.CEP.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Nasc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtCOD_CLIENTE
            // 
            this.txtCOD_CLIENTE.Location = new System.Drawing.Point(16, 22);
            this.txtCOD_CLIENTE.Mask = "00000";
            this.txtCOD_CLIENTE.Name = "txtCOD_CLIENTE";
            this.txtCOD_CLIENTE.PromptChar = ' ';
            this.txtCOD_CLIENTE.Size = new System.Drawing.Size(100, 20);
            this.txtCOD_CLIENTE.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 52);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFEMENINO);
            this.groupBox1.Controls.Add(this.rbMASCINO);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(319, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 43);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMASCINO
            // 
            this.rbMASCINO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMASCINO.Location = new System.Drawing.Point(7, 16);
            this.rbMASCINO.Name = "rbMASCINO";
            this.rbMASCINO.Size = new System.Drawing.Size(85, 17);
            this.rbMASCINO.TabIndex = 0;
            this.rbMASCINO.TabStop = true;
            this.rbMASCINO.Text = "Masculino";
            this.rbMASCINO.UseVisualStyleBackColor = true;
            // 
            // rbFEMENINO
            // 
            this.rbFEMENINO.AutoSize = true;
            this.rbFEMENINO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFEMENINO.Location = new System.Drawing.Point(92, 16);
            this.rbFEMENINO.Name = "rbFEMENINO";
            this.rbFEMENINO.Size = new System.Drawing.Size(71, 17);
            this.rbFEMENINO.TabIndex = 1;
            this.rbFEMENINO.TabStop = true;
            this.rbFEMENINO.Text = "Femenino";
            this.rbFEMENINO.UseVisualStyleBackColor = true;
            // 
            // ckRESTRICAO
            // 
            this.ckRESTRICAO.AutoSize = true;
            this.ckRESTRICAO.Location = new System.Drawing.Point(549, 254);
            this.ckRESTRICAO.Name = "ckRESTRICAO";
            this.ckRESTRICAO.Size = new System.Drawing.Size(71, 17);
            this.ckRESTRICAO.TabIndex = 14;
            this.ckRESTRICAO.Text = "Restrição";
            this.ckRESTRICAO.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btFECHAR);
            this.panel2.Controls.Add(this.btEXCLUIR);
            this.panel2.Controls.Add(this.btGRAVAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 291);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(650, 41);
            this.panel2.TabIndex = 15;
            this.panel2.TabStop = true;
            // 
            // btGRAVAR
            // 
            this.btGRAVAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btGRAVAR.Image = ((System.Drawing.Image)(resources.GetObject("btGRAVAR.Image")));
            this.btGRAVAR.Location = new System.Drawing.Point(6, 6);
            this.btGRAVAR.Name = "btGRAVAR";
            this.btGRAVAR.Size = new System.Drawing.Size(75, 29);
            this.btGRAVAR.TabIndex = 0;
            this.btGRAVAR.Text = "&Gravar";
            this.btGRAVAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btGRAVAR.UseVisualStyleBackColor = true;
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEXCLUIR.Image = ((System.Drawing.Image)(resources.GetObject("btEXCLUIR.Image")));
            this.btEXCLUIR.Location = new System.Drawing.Point(81, 6);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(75, 29);
            this.btEXCLUIR.TabIndex = 1;
            this.btEXCLUIR.Text = "&Excluir";
            this.btEXCLUIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEXCLUIR.UseVisualStyleBackColor = true;
            // 
            // btFECHAR
            // 
            this.btFECHAR.Dock = System.Windows.Forms.DockStyle.Right;
            this.btFECHAR.Image = ((System.Drawing.Image)(resources.GetObject("btFECHAR.Image")));
            this.btFECHAR.Location = new System.Drawing.Point(569, 6);
            this.btFECHAR.Name = "btFECHAR";
            this.btFECHAR.Size = new System.Drawing.Size(75, 29);
            this.btFECHAR.TabIndex = 2;
            this.btFECHAR.Text = "&Fechar";
            this.btFECHAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btFECHAR.UseVisualStyleBackColor = true;
            this.btFECHAR.Click += new System.EventHandler(this.btFECHAR_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clietes";
            this.tabControl1.ResumeLayout(false);
            this.txtNOME.ResumeLayout(false);
            this.txtNOME.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage txtNOME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCOD_CLIENTE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDATA_NASC;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtENDERECO;
        private System.Windows.Forms.MaskedTextBox txtFONE2;
        private System.Windows.Forms.MaskedTextBox txtFONE1;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtBAIRRO;
        private System.Windows.Forms.ComboBox cbESTADO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btFECHAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btGRAVAR;
        private System.Windows.Forms.CheckBox ckRESTRICAO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFEMENINO;
        private System.Windows.Forms.RadioButton rbMASCINO;
    }
}