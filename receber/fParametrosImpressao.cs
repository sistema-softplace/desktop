/*
 * Seleciona par�metros para impress�o do faturamento
 * Autor: Ricardo Costa Xavier
 * Hist�rico:
 * 28/03/10 - vers�o inicial
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace receber
{
	public partial class fParametrosImpressao : Form
	{
		public bool result;
		public string titulo;
		public short quartil1;
		public short quartil2;
		public short quartil3;
		public bool relatorio;
		
		public fParametrosImpressao()
		{
			InitializeComponent();
			edtTitulo.Text = "Relat�rio de Faturamento";
			result = false;						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			titulo = edtTitulo.Text;			
			short.TryParse(edtAtraso1.Text, out quartil1);
			short.TryParse(edtAtraso2.Text, out quartil2);
			short.TryParse(edtAtraso3.Text, out quartil3);
			relatorio = rbtRelatorio.Checked;
			Close();			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}				
	}
}
