using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultarEmprestimo
{
	public partial class FrmSelecionarSecao : Form
	{
		public string nomeSecao { get; private set; }

		public void carregaTextBox()
		{
			nomeSecao = txtSecao.Text;
			this.Close();
		}
		public FrmSelecionarSecao()
		{
			InitializeComponent();
		}

		private void InitializeTable()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				SecaoDAO dao = new SecaoDAO(connection);
				List<EmprestimoModel> secoes = dao.GetSecoes();
				foreach (EmprestimoModel secao in secoes)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colSecao.Index].Value = secao.NomeSecao;
				}
			}
		}


		private void FrmSelecionarSecao_Load(object sender, EventArgs e)
		{
			InitializeTable();
		}



		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				txtSecao.Text = gridLayout.Rows[e.RowIndex].Cells[colSecao.Index].Value + "";
			}
			carregaTextBox();
		}

		private void txtSecao_TextChanged(object sender, EventArgs e)
		{
			string filtro = txtSecao.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{
				string nomeAutor = row.Cells[colSecao.Index].Value.ToString().Trim();


				bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;


				row.Visible = exibir;
			}
	}

		private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
