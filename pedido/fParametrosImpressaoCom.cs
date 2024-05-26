/*
 * Seleciona par�metros para impress�o do pedido
 * Autor: Ricardo Costa Xavier
 * Hist�rico:
 * 09/09/09 - vers�o inicial
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pedido
{
	public partial class fParametrosImpressaoCom : Form
	{
		public bool result;
		public bool por_vendedor;
		public bool por_consultor;
		public bool por_filial;
		public bool somente_pago;
		public bool somente_pagar;
		public bool justificativas;
		public string titulo;
		
		public fParametrosImpressaoCom(DataGridView dgvSelecao)
		{
			InitializeComponent();
			edtTitulo.Text = "Relat�rio de Comiss�o";
			result = false;						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			por_vendedor = rbtVendedor.Checked;
			por_consultor = rbtConsultor.Checked;
			por_filial = rbtFilial.Checked;		
			somente_pago = chkPago.Checked;
			somente_pagar = chkPagar.Checked;
			justificativas = chkJustificativas.Checked;
			titulo = edtTitulo.Text;
			Close();			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
				
	}
}
