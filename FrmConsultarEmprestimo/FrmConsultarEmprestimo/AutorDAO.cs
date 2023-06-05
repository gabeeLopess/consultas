using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class AutorDAO
	{
		private SqlConnection Connection { get; }

		public AutorDAO(SqlConnection connection)
		{
			Connection = connection;
		}

		public List<EmprestimoModel> GetAutores()
		{
			List<EmprestimoModel> autores = new List<EmprestimoModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT nome FROM MvtBIBAutor ORDER BY codAutor");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						autores.Add(PopulateDrAutor(dr));
					}
				}
			}
			return autores;
		}

		public EmprestimoModel PopulateDrAutor(SqlDataReader dr)
		{
			string nomeAutor = "";

			if (DBNull.Value != dr["nome"])
			{
				nomeAutor = dr["nome"] + "";
			}

			return new EmprestimoModel()
			{
				NomeAutor = nomeAutor
			};
		}
	}
}
