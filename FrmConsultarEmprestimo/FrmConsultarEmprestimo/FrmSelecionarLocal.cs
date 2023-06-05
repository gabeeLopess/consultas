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
	public partial class FrmSelecionarLocal : Form
	{
		public string nomeLocal { get; private set; }

		public FrmSelecionarLocal()
		{
			InitializeComponent();
		}

		public void Fechar()
		{
			nomeLocal = txtLocal.Text;

			this.Close();
		}
		private void InitializeTable()
		{
			gridLayout.Rows.Clear();
			using (SqlConnection connection = DaoConnection.GetConexao())
			{
				LocalDAO dao = new LocalDAO(connection);
				List<EmprestimoModel> locais = dao.GetLocais();
				foreach (EmprestimoModel local in locais)
				{
					DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
					row.Cells[colNomeLocal.Index].Value = local.NomeLocal;
				}
			}
		}
		private void txtLocal_TextChanged(object sender, EventArgs e)
		{
			string filtro = txtLocal.Text.Trim();

			foreach (DataGridViewRow row in gridLayout.Rows)
			{
				string local = row.Cells[colNomeLocal.Index].Value.ToString().Trim();
				bool exibir = local.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
				row.Visible = exibir;
			}
		}

		private void lblNomeLocal_Click(object sender, EventArgs e)
		{
			
		}
		private void gridLayout_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FrmSelecionarLocal_Load(object sender, EventArgs e)
		{
			InitializeTable();
		}

		private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1 && e.ColumnIndex > -1)
			{
				txtLocal.Text = gridLayout.Rows[e.RowIndex].Cells[colNomeLocal.Index].Value + "";
				Fechar();
			}
		}
	}
}
