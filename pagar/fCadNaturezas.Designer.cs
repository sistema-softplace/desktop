﻿/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 20/07/2008
 * Hora: 21:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
{
	partial class fCadNaturezas
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
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.chkAtivas = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(310, 97);
			this.btnCancela.TabIndex = 6;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(200, 97);
			this.btnConfirma.TabIndex = 5;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.MaxLength = 6;
			this.edtCodigo.Size = new System.Drawing.Size(48, 20);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.chkAtivo);
			this.pnlEdicao.Location = new System.Drawing.Point(10, 224);
			this.pnlEdicao.Size = new System.Drawing.Size(420, 138);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkAtivo, 0);
			// 
			// btnAltera
			// 
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(320, 39);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// chkAtivo
			// 
			this.chkAtivo.Checked = true;
			this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAtivo.Location = new System.Drawing.Point(115, 66);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(104, 24);
			this.chkAtivo.TabIndex = 4;
			this.chkAtivo.Text = "Ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// chkAtivas
			// 
			this.chkAtivas.Checked = true;
			this.chkAtivas.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAtivas.Location = new System.Drawing.Point(12, 200);
			this.chkAtivas.Name = "chkAtivas";
			this.chkAtivas.Size = new System.Drawing.Size(165, 24);
			this.chkAtivas.TabIndex = 12;
			this.chkAtivas.Text = "Mostrar somente ativas";
			this.chkAtivas.UseVisualStyleBackColor = true;
			this.chkAtivas.CheckedChanged += new System.EventHandler(this.ChkAtivasCheckedChanged);
			// 
			// fCadNaturezas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 371);
			this.Controls.Add(this.chkAtivas);
			this.Name = "fCadNaturezas";
			this.Text = "Sistema SOFT - Naturezas de Pagamento";
			this.Load += new System.EventHandler(this.FCadNaturezasLoad);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.chkAtivas, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.CheckBox chkAtivas;
	}
}
