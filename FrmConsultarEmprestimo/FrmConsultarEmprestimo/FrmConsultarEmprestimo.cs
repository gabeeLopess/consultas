using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultarEmprestimo
{
	public partial class FrmConsultarEmprestimo : Form
	{
		public string codigoItemAcervo { get; set; }

		public FrmConsultarEmprestimo()
		{
			InitializeComponent();
		}

		private void FrmConsultarEmprestimo_Load(object sender, EventArgs e)
		{

		}

		private void Limpar()
		{
			txtItem	.Text = String.Empty;
			txtAutor.Text = String.Empty;
			txtLocal.Text = String.Empty;
			txtLeitor.Text = String.Empty;
			txtSecao.Text = String.Empty;
			cmbTipoItem.SelectedIndex = -1;
			dtpDataFim.Text = String.Empty;
			cmbSituacao.SelectedIndex = -1;
			gridLayout.Rows.Clear();
		}

		public void SelecionarLocal()
		{
			FrmSelecionarLocal frmSelecionarLocal = new FrmSelecionarLocal();
			frmSelecionarLocal.ShowDialog();
			txtLocal.Text = frmSelecionarLocal.nomeLocal;
		}
		public void SelecionarSecao()
		{
			FrmSelecionarSecao frmSelecionarSecao = new FrmSelecionarSecao();
			frmSelecionarSecao.ShowDialog();
			txtSecao.Text = frmSelecionarSecao.nomeSecao;
		}

		public void SelecionarAutores()
		{
			FrmSelecionarAutor frmSelecionarAutor= new FrmSelecionarAutor();
			frmSelecionarAutor.ShowDialog();
			txtAutor.Text = frmSelecionarAutor.nomeAutor;
		}

		public void SelecionarLeitores()
		{
			FrmSelecionarLeitor frmSelecionarLeitor = new FrmSelecionarLeitor();
			frmSelecionarLeitor.ShowDialog();
			txtLeitor.Text = frmSelecionarLeitor.nomeLeitor;
		}

		public void SelecionarItens()
		{
			try
			{
				FrmSelecionarItem frmSelecionarItem = new FrmSelecionarItem();
				frmSelecionarItem.ShowDialog();


				txtItem.Text = frmSelecionarItem.nomeItem;
				txtCodigoItem.Text = frmSelecionarItem.codItem;

				using (SqlConnection connection = DaoConnection.GetConexao())
				{
					ItemDAO dao = new ItemDAO(connection);

					codigoItemAcervo = txtCodigoItem.Text;  // Adicione esta linha para atribuir o valor correto

					txtAutor.Text = dao.GetNomeAutor(new EmprestimoModel()
					{
						CodItem = codigoItemAcervo
					});

					txtLocal.Text = dao.GetNomeLocal(new EmprestimoModel()
					{
						CodItem = codigoItemAcervo
					});

					txtSecao.Text = dao.GetNomeSecao(new EmprestimoModel()
					{
						CodItem = codigoItemAcervo
					});

					cmbTipoItem.Text = dao.GetTipoItem(new EmprestimoModel()
					{
						CodItem = codigoItemAcervo
					});
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Limpar();
		}


		public void Inicializacao(DataGridView dataGridView)
		{
			dataGridView.Rows.Clear();

			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				EmprestimoDAO dao = new EmprestimoDAO(connection);
				List<EmprestimoModel> emprestimos = dao.BuscarEmprestimos(new EmprestimoModel()
				{
					CodItem = txtCodigoItem.Text,
					NomeItem = txtItem.Text,
					NomeLeitor = txtLeitor.Text,
					StatusItem = cmbSituacao.Text,
					NomeAutor = txtAutor.Text,
					NomeLocal = txtLocal.Text,
					NomeSecao = txtSecao.Text,
					TipoItem = cmbTipoItem.Text,
					DataReserva = dtpDataInicio.Value.Date.ToString(),
					DataRetorno = dtpDataFim.Value.Date.ToString()
				});

				foreach (EmprestimoModel emprestimo in emprestimos)
				{
					DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
					row.Cells[colItem.Index].Value = emprestimo.NomeItem;
					row.Cells[colAutor.Index].Value = emprestimo.NomeAutor;
					row.Cells[colSituacao.Index].Value = emprestimo.StatusItem;
					row.Cells[colDataReserva.Index].Value = emprestimo.DataReserva.Substring(0, 10);
					row.Cells[colDataRetorno.Index].Value = emprestimo.DataRetorno.Substring(0, 10);
					row.Cells[colLeitor.Index].Value = emprestimo.NomeLeitor;
					row.Cells[colLocal.Index].Value = emprestimo.NomeLocal;
					row.Cells[colSecao.Index].Value = emprestimo.NomeSecao;
					row.Cells[colTipoItem.Index].Value = emprestimo.TipoItem;
				}
			}
		}
		

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			Inicializacao(gridLayout);
		}


		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				
				txtItem.Text = gridLayout.Rows[e.RowIndex].Cells[colItem.Index].Value + "";
				txtAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colAutor.Index].Value + "";
				txtLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colLocal.Index].Value + "";
				txtLeitor.Text = gridLayout.Rows[e.RowIndex].Cells[colLeitor.Index].Value + "";
				txtSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
				cmbTipoItem.Text = gridLayout.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
				dtpDataInicio.Text = gridLayout.Rows[e.RowIndex].Cells[colDataReserva.Index].Value + "";
				dtpDataFim.Text = gridLayout.Rows[e.RowIndex].Cells[colDataRetorno.Index].Value + "";
				cmbSituacao.Text = gridLayout.Rows[e.RowIndex].Cells[colSituacao.Index].Value + "";
			}
		}


		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			SelecionarItens();
		}

		private void btnSelecionarLocal_Click(object sender, EventArgs e)
		{
			SelecionarLocal();
		}

		private void btnSelecionarAutor_Click(object sender, EventArgs e)
		{
			SelecionarAutores();
		}

		private void btnSelecionarLeitor_Click(object sender, EventArgs e)
		{
			SelecionarLeitores();
		}

		private void btnSelecionarSecao_Click(object sender, EventArgs e)
		{
			SelecionarSecao();
		}
	}
}
