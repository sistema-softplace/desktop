﻿/*
 * Usuário: Ricardo
 * Data: 09/04/2008
 * Hora: 0:33
 * 
 */
namespace basico
{
	partial class frmCadFuncionarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.edtCEP = new System.Windows.Forms.TextBox();
			this.lblCEP = new System.Windows.Forms.Label();
			this.cbxEstados = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.edtCidade = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.edtBairro = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.edtComplemento = new System.Windows.Forms.TextBox();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.edtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.edtLogradouro = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.edtFone2 = new System.Windows.Forms.TextBox();
			this.edtFone1 = new System.Windows.Forms.TextBox();
			this.lblFone = new System.Windows.Forms.Label();
			this.edtFone3 = new System.Windows.Forms.TextBox();
			this.lblCargo = new System.Windows.Forms.Label();
			this.cbxCargos = new System.Windows.Forms.ComboBox();
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.ckbAtivo = new System.Windows.Forms.CheckBox();
			this.lblCelular = new System.Windows.Forms.Label();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.edtCPF = new System.Windows.Forms.TextBox();
			this.lblCNPJ = new System.Windows.Forms.Label();
			this.edtIdentidade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ckbRestricao = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(588, 250);
			this.btnCancela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(478, 250);
			this.btnConfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(95, 40);
			this.edtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescricao.Size = new System.Drawing.Size(80, 20);
			this.lblDescricao.Text = "*Nome";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbRestricao);
			this.pnlEdicao.Controls.Add(this.edtIdentidade);
			this.pnlEdicao.Controls.Add(this.label2);
			this.pnlEdicao.Controls.Add(this.edtCPF);
			this.pnlEdicao.Controls.Add(this.lblCNPJ);
			this.pnlEdicao.Controls.Add(this.dtpNascimento);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.lblCelular);
			this.pnlEdicao.Controls.Add(this.ckbAtivo);
			this.pnlEdicao.Controls.Add(this.edtEmail);
			this.pnlEdicao.Controls.Add(this.lblEmail);
			this.pnlEdicao.Controls.Add(this.cbxCargos);
			this.pnlEdicao.Controls.Add(this.lblCargo);
			this.pnlEdicao.Controls.Add(this.edtFone3);
			this.pnlEdicao.Controls.Add(this.edtFone2);
			this.pnlEdicao.Controls.Add(this.edtFone1);
			this.pnlEdicao.Controls.Add(this.lblFone);
			this.pnlEdicao.Controls.Add(this.edtCEP);
			this.pnlEdicao.Controls.Add(this.lblCEP);
			this.pnlEdicao.Controls.Add(this.cbxEstados);
			this.pnlEdicao.Controls.Add(this.lblEstado);
			this.pnlEdicao.Controls.Add(this.edtCidade);
			this.pnlEdicao.Controls.Add(this.lblCidade);
			this.pnlEdicao.Controls.Add(this.edtBairro);
			this.pnlEdicao.Controls.Add(this.lblBairro);
			this.pnlEdicao.Controls.Add(this.edtComplemento);
			this.pnlEdicao.Controls.Add(this.lblComplemento);
			this.pnlEdicao.Controls.Add(this.edtNumero);
			this.pnlEdicao.Controls.Add(this.lblNumero);
			this.pnlEdicao.Controls.Add(this.edtLogradouro);
			this.pnlEdicao.Controls.Add(this.lblLogradouro);
			this.pnlEdicao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlEdicao.Size = new System.Drawing.Size(700, 293);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblLogradouro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtLogradouro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblNumero, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtNumero, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblComplemento, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtComplemento, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblBairro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtBairro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCidade, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCidade, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEstado, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxEstados, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCEP, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCEP, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblFone, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone3, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCargo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxCargos, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtivo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCelular, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpNascimento, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCNPJ, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCPF, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtIdentidade, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbRestricao, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(600, 130);
			this.btnFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(600, 100);
			this.btnAltera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(600, 70);
			this.btnExclui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(600, 40);
			this.btnInclui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// edtCEP
			// 
			this.edtCEP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCEP.Location = new System.Drawing.Point(610, 130);
			this.edtCEP.MaxLength = 10;
			this.edtCEP.Name = "edtCEP";
			this.edtCEP.Size = new System.Drawing.Size(76, 20);
			this.edtCEP.TabIndex = 10;
			this.edtCEP.Enter += new System.EventHandler(this.EdtCEPEnter);
			this.edtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCEP.Leave += new System.EventHandler(this.EdtCEPLeave);
			// 
			// lblCEP
			// 
			this.lblCEP.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCEP.Location = new System.Drawing.Point(580, 130);
			this.lblCEP.Name = "lblCEP";
			this.lblCEP.Size = new System.Drawing.Size(30, 20);
			this.lblCEP.TabIndex = 54;
			this.lblCEP.Text = "CEP";
			this.lblCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxEstados
			// 
			this.cbxEstados.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxEstados.FormattingEnabled = true;
			this.cbxEstados.Location = new System.Drawing.Point(515, 130);
			this.cbxEstados.Name = "cbxEstados";
			this.cbxEstados.Size = new System.Drawing.Size(50, 22);
			this.cbxEstados.TabIndex = 9;
			// 
			// lblEstado
			// 
			this.lblEstado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEstado.Location = new System.Drawing.Point(460, 130);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(50, 20);
			this.lblEstado.TabIndex = 53;
			this.lblEstado.Text = "Estado";
			this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCidade
			// 
			this.edtCidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCidade.Location = new System.Drawing.Point(95, 130);
			this.edtCidade.MaxLength = 50;
			this.edtCidade.Name = "edtCidade";
			this.edtCidade.Size = new System.Drawing.Size(356, 20);
			this.edtCidade.TabIndex = 8;
			// 
			// lblCidade
			// 
			this.lblCidade.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCidade.Location = new System.Drawing.Point(10, 130);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(80, 20);
			this.lblCidade.TabIndex = 52;
			this.lblCidade.Text = "Cidade";
			this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtBairro
			// 
			this.edtBairro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBairro.Location = new System.Drawing.Point(330, 100);
			this.edtBairro.MaxLength = 50;
			this.edtBairro.Name = "edtBairro";
			this.edtBairro.Size = new System.Drawing.Size(356, 20);
			this.edtBairro.TabIndex = 7;
			// 
			// lblBairro
			// 
			this.lblBairro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBairro.Location = new System.Drawing.Point(260, 100);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(60, 20);
			this.lblBairro.TabIndex = 51;
			this.lblBairro.Text = "Bairro";
			this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtComplemento
			// 
			this.edtComplemento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComplemento.Location = new System.Drawing.Point(95, 100);
			this.edtComplemento.MaxLength = 20;
			this.edtComplemento.Name = "edtComplemento";
			this.edtComplemento.Size = new System.Drawing.Size(146, 20);
			this.edtComplemento.TabIndex = 6;
			// 
			// lblComplemento
			// 
			this.lblComplemento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblComplemento.Location = new System.Drawing.Point(10, 100);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(80, 20);
			this.lblComplemento.TabIndex = 50;
			this.lblComplemento.Text = "Complemento";
			this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNumero
			// 
			this.edtNumero.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNumero.Location = new System.Drawing.Point(515, 70);
			this.edtNumero.MaxLength = 6;
			this.edtNumero.Name = "edtNumero";
			this.edtNumero.Size = new System.Drawing.Size(48, 20);
			this.edtNumero.TabIndex = 5;
			// 
			// lblNumero
			// 
			this.lblNumero.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNumero.Location = new System.Drawing.Point(460, 70);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(50, 20);
			this.lblNumero.TabIndex = 49;
			this.lblNumero.Text = "Número";
			this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtLogradouro
			// 
			this.edtLogradouro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLogradouro.Location = new System.Drawing.Point(95, 70);
			this.edtLogradouro.MaxLength = 50;
			this.edtLogradouro.Name = "edtLogradouro";
			this.edtLogradouro.Size = new System.Drawing.Size(356, 20);
			this.edtLogradouro.TabIndex = 4;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLogradouro.Location = new System.Drawing.Point(10, 70);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(80, 20);
			this.lblLogradouro.TabIndex = 48;
			this.lblLogradouro.Text = "Logradouro";
			this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone2
			// 
			this.edtFone2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone2.Location = new System.Drawing.Point(201, 160);
			this.edtFone2.MaxLength = 13;
			this.edtFone2.Name = "edtFone2";
			this.edtFone2.Size = new System.Drawing.Size(97, 20);
			this.edtFone2.TabIndex = 12;
			this.edtFone2.Enter += new System.EventHandler(this.EdtFone2Enter);
			this.edtFone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone2.Leave += new System.EventHandler(this.EdtFone2Leave);
			// 
			// edtFone1
			// 
			this.edtFone1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone1.Location = new System.Drawing.Point(95, 160);
			this.edtFone1.MaxLength = 13;
			this.edtFone1.Name = "edtFone1";
			this.edtFone1.Size = new System.Drawing.Size(97, 20);
			this.edtFone1.TabIndex = 11;
			this.edtFone1.Enter += new System.EventHandler(this.EdtFone1Enter);
			this.edtFone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone1.Leave += new System.EventHandler(this.EdtFone1Leave);
			// 
			// lblFone
			// 
			this.lblFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFone.Location = new System.Drawing.Point(10, 160);
			this.lblFone.Name = "lblFone";
			this.lblFone.Size = new System.Drawing.Size(80, 20);
			this.lblFone.TabIndex = 57;
			this.lblFone.Text = "Fone";
			this.lblFone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone3
			// 
			this.edtFone3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone3.Location = new System.Drawing.Point(347, 160);
			this.edtFone3.MaxLength = 13;
			this.edtFone3.Name = "edtFone3";
			this.edtFone3.Size = new System.Drawing.Size(104, 20);
			this.edtFone3.TabIndex = 13;
			this.edtFone3.Enter += new System.EventHandler(this.EdtFone3Enter);
			this.edtFone3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone3.Leave += new System.EventHandler(this.EdtFone3Leave);
			// 
			// lblCargo
			// 
			this.lblCargo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCargo.Location = new System.Drawing.Point(460, 160);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(50, 20);
			this.lblCargo.TabIndex = 59;
			this.lblCargo.Text = "Cargo";
			this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCargos
			// 
			this.cbxCargos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCargos.FormattingEnabled = true;
			this.cbxCargos.Location = new System.Drawing.Point(515, 160);
			this.cbxCargos.Name = "cbxCargos";
			this.cbxCargos.Size = new System.Drawing.Size(120, 22);
			this.cbxCargos.TabIndex = 14;
			// 
			// edtEmail
			// 
			this.edtEmail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmail.Location = new System.Drawing.Point(95, 190);
			this.edtEmail.MaxLength = 50;
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(356, 20);
			this.edtEmail.TabIndex = 15;
			// 
			// lblEmail
			// 
			this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmail.Location = new System.Drawing.Point(10, 190);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 20);
			this.lblEmail.TabIndex = 62;
			this.lblEmail.Text = "email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbAtivo
			// 
			this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtivo.Location = new System.Drawing.Point(515, 190);
			this.ckbAtivo.Name = "ckbAtivo";
			this.ckbAtivo.Size = new System.Drawing.Size(128, 24);
			this.ckbAtivo.TabIndex = 16;
			this.ckbAtivo.Text = "Ativo";
			this.ckbAtivo.UseVisualStyleBackColor = true;
			// 
			// lblCelular
			// 
			this.lblCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCelular.Location = new System.Drawing.Point(298, 160);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(40, 20);
			this.lblCelular.TabIndex = 63;
			this.lblCelular.Text = "Celular";
			this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Checked = false;
			this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
			this.dtpNascimento.Enabled = false;
			this.dtpNascimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimento.Location = new System.Drawing.Point(95, 220);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.ShowCheckBox = true;
			this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
			this.dtpNascimento.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(10, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 129;
			this.label1.Text = "Nascimento";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCPF
			// 
			this.edtCPF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCPF.Location = new System.Drawing.Point(294, 250);
			this.edtCPF.MaxLength = 14;
			this.edtCPF.Name = "edtCPF";
			this.edtCPF.Size = new System.Drawing.Size(132, 20);
			this.edtCPF.TabIndex = 19;
			this.edtCPF.Enter += new System.EventHandler(this.EdtCPFEnter);
			this.edtCPF.Leave += new System.EventHandler(this.EdtCPFLeave);
			// 
			// lblCNPJ
			// 
			this.lblCNPJ.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNPJ.Location = new System.Drawing.Point(239, 250);
			this.lblCNPJ.Name = "lblCNPJ";
			this.lblCNPJ.Size = new System.Drawing.Size(50, 20);
			this.lblCNPJ.TabIndex = 131;
			this.lblCNPJ.Text = "CPF";
			this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtIdentidade
			// 
			this.edtIdentidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtIdentidade.Location = new System.Drawing.Point(95, 250);
			this.edtIdentidade.MaxLength = 14;
			this.edtIdentidade.Name = "edtIdentidade";
			this.edtIdentidade.Size = new System.Drawing.Size(132, 20);
			this.edtIdentidade.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(10, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 133;
			this.label2.Text = "Identidade";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbRestricao
			// 
			this.ckbRestricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbRestricao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbRestricao.Location = new System.Drawing.Point(515, 220);
			this.ckbRestricao.Name = "ckbRestricao";
			this.ckbRestricao.Size = new System.Drawing.Size(128, 24);
			this.ckbRestricao.TabIndex = 134;
			this.ckbRestricao.Text = "Restrição entrada";
			this.ckbRestricao.UseVisualStyleBackColor = true;
			// 
			// frmCadFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 502);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmCadFuncionarios";
			this.Text = "Cadastros Básicos - Funcionários";
			this.Load += new System.EventHandler(this.FrmCadFuncionariosLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox edtIdentidade;
		private System.Windows.Forms.TextBox edtCPF;
		private System.Windows.Forms.Label lblCNPJ;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.ComboBox cbxCargos;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox edtEmail;
		private System.Windows.Forms.CheckBox ckbAtivo;
		private System.Windows.Forms.TextBox edtFone3;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Label lblFone;
		private System.Windows.Forms.TextBox edtFone1;
		private System.Windows.Forms.TextBox edtFone2;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.TextBox edtLogradouro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox edtNumero;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox edtComplemento;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox edtBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox edtCidade;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ComboBox cbxEstados;
		private System.Windows.Forms.Label lblCEP;
		private System.Windows.Forms.TextBox edtCEP;
		private System.Windows.Forms.CheckBox ckbRestricao;
	}
}
