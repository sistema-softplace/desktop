/*
 * Criado por SharpDevelop.
 * Usu�rio: Ricardo
 * Data: 08/09/2008
 * Hora: 22:00
 * 
 * Para alterar este modelo use Ferramentas | Op��es | Codifica��o | Editar Cabe�alhos Padr�o.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace classes
{
	/// <summary>
	/// Description of fEntradaItem.
	/// </summary>
	public partial class fEntradaItem : Form
	{
		public fEntradaItem()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
