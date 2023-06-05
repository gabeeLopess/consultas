using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConsultarEmprestimo
{
	public partial class FrmSelecionarAutor : Form
	{
		public string CodAutor { get; private set; }
		public string nomeAutor { get; private set; }

		public FrmSelecionarAutor()
		{
			InitializeComponent();

		}

		private void CarregarAutoresgrid()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				AutorDAO dao = new AutorDAO(connection);
				List<EmprestimoModel> autores = dao.GetAutores();
				foreach (EmprestimoModel autor in autores)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colNomeAutor.Index].Value = autor.NomeAutor;
				}
			}
		}


		private void txtNomeAutor_TextChanged(object sender, EventArgs e)
		{
			string filtro = txtNomeAutor.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{

				string nomeLeitor = row.Cells[colNomeAutor.Index].Value.ToString().Trim();
				bool exibir = nomeLeitor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
				row.Visible = exibir;
			}
		}

		private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void FrmSelecionarAutor_Load(object sender, EventArgs e)
		{
			CarregarAutoresgrid();
		}

		public void carregaTextBox()
		{

			nomeAutor = txtNomeAutor.Text;
			
			this.Close();
		}

		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				txtNomeAutor.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeAutor.Index].Value + "";
			}
				carregaTextBox();
			
		}

	}
}
