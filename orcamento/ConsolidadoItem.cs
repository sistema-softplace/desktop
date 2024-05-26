using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections.Generic;
using classes;

namespace orcamento {
	public class ConsolidadoItem {
			
		private class Item {
			public string codigo;
			public string subCodigo;
			public string descricao;
			public int qtde;
			public double valor;
		}
		
		private Document doc;
		private PdfWriter writer;
		private Dictionary<string, Item> map;
		private Dictionary<string, Item> sortedMap;
		
		public ConsolidadoItem() {
		}
		
		private void GeraCabecalho1(int count) {
			Table table = new Table(3);
			table.TableFitsPage = true;
			table.WidthPercentage = 100;
			table.BorderWidth = 1;			
			table.Padding = 1;
			Cell cell;
			Chunk chunk;
			
			// coluna1 - logo
			Image img;
			float largura=1000F;
			float altura=1000F;
			try
			{
				img = Image.GetInstance("imagens\\logo_rel.jpg");
				float w=img.Width;
				float h=img.Height;
				while ((w > largura) || (h > altura))
				{
					w *= 0.9F;
					h *= 0.9F;
				}
				img.ScaleAbsolute(w, h);
				chunk = new Chunk(img, 0, 0);
			}
			catch
			{
				chunk = new Chunk("");
			}
			cell = new Cell(chunk);
			cell.Rowspan = 2;
			table.AddCell(cell);
			
			Paragraph par = new Paragraph();
			par.Add(new Chunk("Número de orçamentos: ", FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			cell = new Cell(par);
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			table.AddCell(cell);
			
			par = new Paragraph();
			par.Add(new Chunk(count.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			cell = new Cell(par);
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			table.AddCell(cell);
							
			par = new Paragraph();
			par.Add(new Chunk("Valor total: ", FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			cell = new Cell(par);
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			table.AddCell(cell);
			
			double total = 0;
			foreach (string key in map.Keys) {
				Item item = map[key];
				total += item.valor;
			}
							
			par = new Paragraph();
			par.Add(new Chunk("R$: " + total.ToString("#,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			cell = new Cell(par);
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			table.AddCell(cell);			
			doc.Add(table);
			
			doc.Add(new Paragraph(""));
		}
		
		public Cell Celula2(string texto, int colspan) {
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.GrayFill = (colspan == 1) ? 0.6f : 0.8f;
			cell.BorderWidthTop = 2;
			cell.BorderWidthRight = 4;
			cell.BorderColor = Color.WHITE;
			cell.Leading = 10;
			return cell;
		}
		
				
		public Cell CelulaItem(string texto, int colspan) {
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.BorderWidthTop = 2;
			cell.BorderWidthRight = 4;
			cell.BorderColor = Color.WHITE;
			cell.Leading = 10;
			return cell;
		}
		
		private void GeraCabecalho2() {
			Table table = new Table(7);
			table.TableFitsPage = true;
			table.BorderWidth = 0;
			table.Padding = 1;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(Celula2("Quantidade", 1));
			table.AddCell(Celula2("Código", 1));
			table.AddCell(Celula2("Sub-código", 1));
			table.AddCell(Celula2("Descrição", 3));
			table.AddCell(Celula2("Valor", 1));
			doc.Add(table);
		}
		
		private void GeraItem(Item item) {
			Table table = new Table(7);
			table.TableFitsPage = true;
			table.BorderWidth = 0;
			table.Padding = 1;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(CelulaItem(item.qtde.ToString(), 1));
			table.AddCell(CelulaItem(item.codigo, 1));
			table.AddCell(CelulaItem(item.subCodigo, 1));
			table.AddCell(CelulaItem(item.descricao, 3));
			Cell celula = CelulaItem(item.valor.ToString("#,###,##0.00"), 1);
			celula.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(celula);
			doc.Add(table);
		}
		
		public bool Gera(DataGridView grid) {
			try {
				int orcamentosSelecionados = CarregaItens(grid);
				FileStream fs = new FileStream("consolidado_item.pdf", FileMode.Create);
				doc = new Document(PageSize.LETTER.Rotate());
				writer = PdfWriter.GetInstance(doc, fs);
				doc.Open();
				GeraCabecalho1(orcamentosSelecionados);
			
				GeraCabecalho2();
				
				sortedMap = new Dictionary<string, Item>();
				int qtdMin = 999999;
				while (true) {
					int maior = -1;
					bool achou = false;
					foreach (string key in map.Keys) {
						Item item = map[key];
						if (item.qtde < qtdMin) {
							achou = true;
							if (item.qtde > maior) {
								maior = item.qtde;
							}
						}
					}
					qtdMin = maior;
					if (!achou) {
						break;
					}
					foreach (string key in map.Keys) {
						Item item = map[key];
						if (item.qtde == maior) {
							sortedMap.Add(key, item);
						}
					}
				}
				map = sortedMap;
				
				
				foreach (string key in map.Keys) {
					Item item = map[key];
				}

				
				foreach (string key in map.Keys) {
					Item item = map[key];
					GeraItem(item);
				}
			
				doc.Close();
				return true;
			}
			catch (Exception e) {
				return false;
			}
		}
		
		private int CarregaItens(DataGridView grid) {
			int orcamentosSelecionados = 0;
			map = new Dictionary<string, Item>();
			
			FbCommand cmd =  new FbCommand("select cod_produto, " +
			                     "       sub_codigo, " + 			                     
			                     "       qtd_item, " +
			                     "       vlr_preco, " +
			                     "       des_produto " +
			                     "from ITENS  " +
			                     "where cod_fornecedor=@cod_fornecedor " +
			                     "  and dat_orcamento=@dat_orcamento " +
			                     "  and cod_orcamento=@cod_orcamento ",
			                     Globais.bd);
			cmd.Parameters.Add("@cod_fornecedor", FbDbType.Char, 20);
			cmd.Parameters.Add("@dat_orcamento", FbDbType.Date);
			cmd.Parameters.Add("@cod_orcamento", FbDbType.SmallInt);
			cmd.Prepare();
			
			foreach (DataGridViewRow row in grid.Rows) {
				if (! ((bool) row.Cells["S"].Value)) {
					continue;
				}
				
				orcamentosSelecionados++;
				cmd.Parameters["@cod_fornecedor"].Value = row.Cells["Fornecedor"].Value;
				cmd.Parameters["@dat_orcamento"].Value = row.Cells["Data"].Value;
				cmd.Parameters["@cod_orcamento"].Value = row.Cells["Cod"].Value;
							
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				while (reader.Read()) {
					string codProduto = reader.GetString(0).Trim();
					string subCodigo = reader.GetString(1).Trim();
					int qtde = reader.GetInt16(2);
					double valor = reader.GetDouble(3);
					string descricao = reader.GetString(4).Trim();
					string key = codProduto + "#"  + subCodigo;
					Item item = null;
					if (map.ContainsKey(key)) {
						item = map[key];
					}
					if (item == null) {
						item = new Item();
						item.codigo = codProduto;
						item.subCodigo = subCodigo;
						item.descricao = descricao;
						map.Add(key, item);
						item.qtde = qtde;
						item.valor = valor * qtde;
					} else {
						item.qtde += qtde;
						item.valor += (valor * qtde);
						map[key] = item;
					}
				}
				reader.Close();
			}
			return orcamentosSelecionados;
		}
	}
}
