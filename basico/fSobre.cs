/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fSobre - Tela Sobre
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;

namespace basico
{
	public partial class frmSobre : tSobre
	{
		public frmSobre()
		{
			InitializeComponent();
			lblSistema.Text = "M�dulo Cadastros B�sicos";
			lblVersao.Text = "Vers�o 1.4.0 (24/10/11)";
		}
	}
}
