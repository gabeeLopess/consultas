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
	public partial class FrmSelecionarItem : Form
	{

		public string codItem { get; set; }
		public string nomeItem { get; set; }

		public FrmSelecionarItem()
		{
			InitializeComponent();
		}
		public void carregaTextBox()
		{
			nomeItem = txtNomeItem.Text;
			codItem = txtCodigoItem.Text;
			this.Close();
		}


		private void InitializeTable()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				ItemDAO dao = new ItemDAO(connection);
				List<EmprestimoModel> itens = dao.GetItens();
				foreach (EmprestimoModel item in itens)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colNomeItem.Index].Value = item.NomeItem;
					row.Cells[colCodItem.Index].Value = item.CodItem;
				}
			}
		}
		private void txtNomeItem_TextChanged(object sender, EventArgs e)
		{
			string filtro = txtNomeItem.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{
				string nomeAutor = row.Cells[colNomeItem.Index].Value.ToString().Trim();
				bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
				row.Visible = exibir;
			}
		}

		private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FrmSelecionarItem_Load(object sender, EventArgs e)
		{
			InitializeTable();
		}

		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				txtCodigoItem.Text = gridLayout.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
				txtNomeItem.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
				
			}
			carregaTextBox();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			string filtro = txtCodigoItem.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{
				string codItem = row.Cells[colCodItem.Index].Value.ToString().Trim();
				bool exibir = codItem.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
				row.Visible = exibir;
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
