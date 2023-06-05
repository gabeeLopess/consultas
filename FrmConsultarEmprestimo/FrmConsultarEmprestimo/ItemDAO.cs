using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class ItemDAO
	{
		private SqlConnection Connection { get; }

		public ItemDAO(SqlConnection connection)
		{
			Connection = connection;
		}

		public string GetNomeAutor(EmprestimoModel consultaEmprestimo)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT nomeAutor FROM mvtBiibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		public string GetNomeLocal(EmprestimoModel consultaEmprestimo)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT nomeLocal FROM mvtBiibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		public string GetNomeSecao(EmprestimoModel consultaEmprestimo)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT secao FROM mvtBiibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		public string GetTipoItem(EmprestimoModel consultaEmprestimo)
		{
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine($"SELECT tipoItem FROM mvtBiibItemAcervo WHERE codItem = @codItem");
				command.CommandText = sql.ToString();
				command.Parameters.AddWithValue("@codItem", consultaEmprestimo.CodItem);
				string result = Convert.ToString(command.ExecuteScalar());

				if (result != null)
				{
					return result.ToString();
				}
			}
			return string.Empty;
		}

		public List<EmprestimoModel> GetItens()
		{
			List<EmprestimoModel> itens = new List<EmprestimoModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT codItem, nomeItem FROM MvTbiibReservaa ORDER BY codItem");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						itens.Add(PopulateDrItem(dr));
					}
				}
			}
			return itens;
		}

		public EmprestimoModel PopulateDrItem(SqlDataReader dr)
		{
			string nome = "";
			string codItem = "";

			if (DBNull.Value != dr["nomeItem"])
			{
				nome = dr["nomeItem"] + "";
			}
			if (DBNull.Value != dr["codItem"])
			{
				codItem = dr["codItem"] + "";
			}

			return new EmprestimoModel()
			{
				NomeItem = nome,
				CodItem = codItem
			};
		}
	}
}

