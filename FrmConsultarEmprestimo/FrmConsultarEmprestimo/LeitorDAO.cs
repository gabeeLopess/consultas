using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class LeitorDAO
	{
		private SqlConnection Connection { get; }
		public LeitorDAO(SqlConnection connection)
		{
			Connection = connection;
		}

		public List<EmprestimoModel> GetLeitores()
		{
			List<EmprestimoModel> leitores = new List<EmprestimoModel>();
			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT leitor FROM mvtBibLeitor ORDER BY codLeitor");
				command.CommandText = sql.ToString();
				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						leitores.Add(PopulateDrLeitor(dr));
					}
				}
			}
			return leitores;
		}

		public EmprestimoModel PopulateDrLeitor(SqlDataReader dr)
		{
			string nomeLeitor = "";

			if (DBNull.Value != dr["leitor"])
			{
				nomeLeitor = dr["leitor"] + "";
			}

			return new EmprestimoModel()
			{
				NomeLeitor = nomeLeitor
			};
		}
	}
}

