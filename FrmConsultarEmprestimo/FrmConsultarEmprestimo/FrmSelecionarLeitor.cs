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
	public partial class FrmSelecionarLeitor : Form
	{
		public string nomeLeitor { get; set; }

		public FrmSelecionarLeitor()
		{
			InitializeComponent();
		}
		public void carregaTextBox()
		{
			nomeLeitor = txtLeitor.Text;
			this.Close();
		}

		
		private void FrmSelecionarLeitor_Load(object sender, EventArgs e)
		{
			InitializeTable();
		}

		private void InitializeTable()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				LeitorDAO dao = new LeitorDAO(connection);
				List<EmprestimoModel> leitores = dao.GetLeitores();
				foreach (EmprestimoModel leitor in leitores)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colLeitor.Index].Value = leitor.NomeLeitor;
				}
			}
		}

		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				txtLeitor.Text = gridLayout.Rows[e.RowIndex].Cells[colLeitor.Index].Value + "";
			}
			carregaTextBox();
		}

		private void txtLeitor_TextChanged(object sender, EventArgs e)
		{
			string filtro = txtLeitor.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{
				string nomeAutor = row.Cells[colLeitor.Index].Value.ToString().Trim();
				bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
				row.Visible = exibir;
			}
		}

		private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}

}
