/*
 * Projeto  : SoftPlace
 * Sistema  : Contas a Pagar
 * Programa : fSobre - Tela Sobre
 * Autor    : Ricardo Costa Xavier
 * Data     : 20/07/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;

namespace pagar
{
	public partial class fSobre : tSobre
	{
		public fSobre()
		{
			InitializeComponent();
			lblSistema.Text = "M�dulo Contas a Pagar";
			lblVersao.Text = "Vers�o 1.4.0 (24/10/11)";
		}
	}
}
