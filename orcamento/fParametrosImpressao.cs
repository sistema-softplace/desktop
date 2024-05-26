/*
 * Seleciona parâmetros para impressão do orçamento
 * Usuário: Ricardo
 * Data: 19/10/2008
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace orcamento
{
	public partial class fParametrosImpressao : Form
	{
		public bool result;
		public bool foto;
		public bool resumida;
		public bool detalhada;
		public bool endereco_filial;
		public bool mostrar_valores;
		public bool consolidado;
		public bool consolidado_item;
		public bool total_prod_serv;
		public bool mostrar_medidas;
		public bool listagem;
		public bool bFornecedor;
		public bool bData;
		public bool bCod;
		public bool bVendedor;
		public bool bCliente;
		public bool bConsultor;
		public bool bSituacao;
		public bool bValor;
		public bool bSinal;
		public bool bOrdenarCaracteristica;
		public bool introducao;
		public bool informacoes_fornecimento;
		public bool termo_garantia;
		public bool condicoes_montagem;
		public bool termo_aprovacao;		
		public bool consolidadoPorItem;
		
		public fParametrosImpressao()
		{
			InitializeComponent();
			result = false;
			chkFornecedor.Enabled = !rbtOrcamento.Checked;
			chkData.Enabled = !rbtOrcamento.Checked;
			chkCodigo.Enabled = !rbtOrcamento.Checked;
			chkVendedor.Enabled = !rbtOrcamento.Checked;
			chkCliente.Enabled = !rbtOrcamento.Checked;
			chkConsultor.Enabled = !rbtOrcamento.Checked;
			chkSituacao.Enabled = !rbtOrcamento.Checked;
			chkValor.Enabled = !rbtOrcamento.Checked;
			chkSinal.Enabled = !rbtOrcamento.Checked;
			chkOrdenaCaracteristica.Enabled = !rbtOrcamento.Checked;
			chkIntroducao.Enabled = rbtOrcamento.Checked;
			chkInformacoesFornecimento.Enabled = rbtOrcamento.Checked;
			chkTermoGarantia.Enabled = rbtOrcamento.Checked;
			chkCondicoesMontagem.Enabled = rbtOrcamento.Checked;
			chkTermoAprovacao.Enabled = rbtOrcamento.Checked;			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			foto = chkFoto.Checked;
			resumida = chkResumida.Checked;
			detalhada = chkDetalhada.Checked;
			endereco_filial = chkEnderecoFilial.Checked;
			mostrar_valores = chkValores.Checked;
			consolidado = chkConsolidado.Checked;
			consolidado_item = chkConsolidadoItem.Checked;
			total_prod_serv = chkTotalProdServ.Checked;
			mostrar_medidas = chkMostrarMedidas.Checked;
			listagem = rbtListagem.Checked;
			bFornecedor = chkFornecedor.Checked;
			bData = chkData.Checked;
			bCod = chkCodigo.Checked;
			bVendedor = chkVendedor.Checked;
			bCliente = chkCliente.Checked;
			bConsultor = chkConsultor.Checked;
			bSituacao = chkSituacao.Checked;
			bValor = chkValor.Checked;
			bSinal = chkSinal.Checked;
			bOrdenarCaracteristica = chkOrdenaCaracteristica.Checked;
			introducao = chkIntroducao.Checked;
			informacoes_fornecimento = chkInformacoesFornecimento.Checked;
			termo_garantia = chkTermoGarantia.Checked;
			condicoes_montagem = chkCondicoesMontagem.Checked;
			termo_aprovacao = chkTermoAprovacao.Checked;			
			consolidadoPorItem = rbtConsolidadoItem.Checked;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void HabilitaDesabilita(bool orcamento, bool listagem)
		{
			chkIntroducao.Enabled = orcamento;
			chkInformacoesFornecimento.Enabled = orcamento;
			chkTermoGarantia.Enabled = orcamento;
			chkCondicoesMontagem.Enabled = orcamento;
			chkTermoAprovacao.Enabled = orcamento;
			chkFoto.Enabled = orcamento;
			chkResumida.Enabled = orcamento;
			chkDetalhada.Enabled = orcamento;
			chkEnderecoFilial.Enabled = orcamento;
			chkValores.Enabled = orcamento;
			chkConsolidado.Enabled = orcamento;
			chkTotalProdServ.Enabled = orcamento;
			chkMostrarMedidas.Enabled = orcamento;
			chkConsolidadoItem.Enabled = orcamento;

			chkFornecedor.Enabled = listagem;
			chkData.Enabled = listagem;
			chkCodigo.Enabled = listagem;
			chkVendedor.Enabled = listagem;
			chkCliente.Enabled = listagem;
			chkConsultor.Enabled = listagem;
			chkSituacao.Enabled = listagem;
			chkValor.Enabled = listagem;
			chkSinal.Enabled = listagem;
			chkOrdenaCaracteristica.Enabled = listagem;
		}
		
		void RbtOrcamentoClick(object sender, EventArgs e)
		{
			if (rbtOrcamento.Checked) {
				rbtListagem.Checked = false;
				rbtConsolidadoItem.Checked = false;
			}
			HabilitaDesabilita(rbtOrcamento.Checked, rbtListagem.Checked);
		}
		
		void RbtListagemClick(object sender, EventArgs e)
		{
			if (rbtListagem.Checked) {
				rbtOrcamento.Checked = false;
				rbtConsolidadoItem.Checked = false;
			}
			HabilitaDesabilita(rbtOrcamento.Checked, rbtListagem.Checked);
		}

		void RbtConsolidadoItemClick(object sender, EventArgs e)
		{
			if (rbtConsolidadoItem.Checked) {
				rbtListagem.Checked = false;
				rbtOrcamento.Checked = false;
			}	
			HabilitaDesabilita(rbtOrcamento.Checked, rbtListagem.Checked);
		}		
	}
}
