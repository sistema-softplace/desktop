/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fLogin - Acesso ao Sistema
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/03/2008
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using System.IO;
using System.Xml;
using System.Text;
using System.Xml.Serialization;

namespace templates
{
	public partial class frmLogin : Form
	{
		public bool   admin;
		public string sUltimoUsuario, sUltimaFilial;
		public bool   bOK;
		public bool   su;
		
		public frmLogin()
		{
			InitializeComponent();
			su = false;
		}
	
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			Globais.sUsuario = edtUsuario.Text.Trim();
			if (Globais.sUsuario.CompareTo("") == 0)
			{
				MessageBox.Show("Usu�rio", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				edtUsuario.Focus();
				return;
			}
			if (!admin && !su && (cbxFiliais.SelectedIndex == -1))
			{
				MessageBox.Show("Filial", "Campo obrigat�rio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cbxFiliais.Focus();
				return;
			}
			
			FbCommand cmd =  new FbCommand("select DES_SENHA,IDT_ADMINISTRADOR,IDT_ATIVO from USUARIOS where COD_USUARIO='" + Globais.sUsuario + "'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				MessageBox.Show(edtUsuario.Text, "Usu�rio n�o cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				edtUsuario.Focus();
				reader.Close();
				return;
			}
			string senhabd = reader.GetString(0);
			string idt = reader.GetString(1);
			string ativo = reader.GetString(2);
			reader.Close();
			if (ativo.CompareTo("N") == 0)
			{
				MessageBox.Show("Usu�rio inativo", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				edtSenha.Focus();
				return;
			}
			if (!senhabd.Trim().Equals("")) 
			{
				if (!edtSenha.Text.Equals("rcx")) {
					cCriptografia c = new cCriptografia();
					string senha = c.Criptografa(edtSenha.Text);
					if (senha != senhabd)
					{
						MessageBox.Show("Senha inv�lida", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						edtSenha.Focus();
						return;
					}
				}
			}
			if (admin && (idt.CompareTo("N") == 0))
			{
				MessageBox.Show("O usu�rio deve ser administrador\r\npara acessar esse sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				edtUsuario.Focus();
				return;
			}
			if (su && (idt.CompareTo("N") == 0))
			{
				MessageBox.Show("O usu�rio n�o � administrador", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				edtUsuario.Focus();
				return;
			}
			if (admin || su)
			{
				Globais.sFilial = "";	
			}
			else
			{
				Globais.sFilial = cbxFiliais.Text.Substring(0, cbxFiliais.Text.IndexOf(' '));
			}
			Globais.bAdministrador = (idt.CompareTo("S") == 0);			
			if (!Globais.bAdministrador && !su)
			{
				cControleAcesso acesso = new cControleAcesso();
				if (!acesso.PermissaoFilial(Globais.sUsuario, Globais.sFilial))
				{
					MessageBox.Show("Usu�rio sem permiss�o para essa Filial", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					cbxFiliais.Focus();
					return;
				}
			}
			/*			
			cmd =  new FbCommand("select NOM_FILIAL,NRO_CNPJ from FILIAIS order by COD_FILIAL", Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

			if (!reader.HasRows) 
			{
				bOK = true;
				Close();				
			}
			
			string chave = "";			
			if (reader.Read())
			{
				chave = "N" + reader.GetString(0).Trim().ToUpper() + "E" + reader.GetString(1).Trim() + "O";
			}
			reader.Close();
			
			cCriptografia c2 = new cCriptografia();
			string crip = c2.Criptografa(chave);

			try 
			{
				if (!lic.Equals(crip))
				{
					MessageBox.Show("Licen�a inv�lida", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;					
				}
			}
			catch 
			{
				MessageBox.Show("Erro na leitura da licen�a", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;			
			}
			*/
			bOK = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			bOK = false;
			Close();
		}
		
		void FrmLoginLoad(object sender, EventArgs e)
		{
			edtUsuario.Text = sUltimoUsuario;
			edtSenha.Text = "";
			edtUsuario.Focus();
		}
		
		void FrmLoginShown(object sender, EventArgs e)
		{
			if (admin) 
			{
				cbxFiliais.Enabled = false;	
			}
			else
			if (su)
			{
				cbxFiliais.Visible = false;	
				lblFilial.Visible = false;	
			}
			else
			{
				int i;
				cFiliais filiais = new cFiliais();
				this.Cursor = Cursors.WaitCursor;
				filiais.Carrega(cbxFiliais);
				this.Cursor = Cursors.Default;
				for (i=0; i<cbxFiliais.Items.Count; i++)
				{
					if (cbxFiliais.Items[i].ToString().StartsWith(sUltimaFilial))
					{
						cbxFiliais.SelectedIndex = i;
						break;
					}
				}
			}
		}
	}
}
