/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadPendencias - Cadastro de Pendencias de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 31/07/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace pagar
{
	public partial class fCadPendencias : tCadastroSimples
	{
		private cPendencias pendencias;
		private string col_sorted;
		private SortOrder ord_sorted;						
		public bool result;
		public string codigo;
		
		void AlteraComponentes()
		{
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}				
		
		public fCadPendencias(bool duplo)
		{
			InitializeComponent();
			AlteraComponentes();				
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;									
			if (duplo)
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			chkAtivo.Checked = true;
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			chkAtivo.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			chkAtivo.Checked = dgvCadastro.Rows[i].Cells["Ativo"].Value.ToString().Equals("S");
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string codigo = edtCodigo.Text.Trim();
			if (acao == 'I') 
			{
				acao = 'i';
				return;
			}
			if (acao == 'A') 
			{
				acao = 'a';
				return;
			}
			string ativo = chkAtivo.Checked ? "S" : "N";
			if (acao == 'i')
				result = pendencias.Inclui(codigo, edtDescricao.Text, ativo, ref msg);
			else
				result = pendencias.Altera(codigo, edtDescricao.Text, ativo, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclus�o da pend�ncia", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na altera��o da pend�ncia", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(dgvCadastro, chkAtivas.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);			
		}
		
		void FCadPendenciasLoad(object sender, EventArgs e)
		{
			pendencias = new cPendencias();
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(dgvCadastro, chkAtivas.Checked);				
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);					
			result = false;
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = pendencias.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclus�o da pend�ncia", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(dgvCadastro, chkAtivas.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			codigo = edtCodigo.Text;
			Close();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}					
		
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;
		}		
		
		private void Sort(string coluna, SortOrder ordem)
		{
			if (coluna.Length > 0)
			{
				foreach (DataGridViewColumn col in dgvCadastro.Columns)				
				{
					if (col.HeaderText.Equals(coluna))
					{
						dgvCadastro.Sort(col, ordem == SortOrder.Ascending ?
			    	             System.ComponentModel.ListSortDirection.Ascending :
			        	         System.ComponentModel.ListSortDirection.Descending);
						break;
					}
				}
			}			
		}
		void ChkAtivasCheckedChanged(object sender, EventArgs e)
		{			
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(dgvCadastro, chkAtivas.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
	
		}		
	}
}
