using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class EmprestimoDAO
	{
		private SqlConnection Connection { get; }

		public EmprestimoDAO(SqlConnection connection)
		{
			Connection = connection;
		}

		public List<EmprestimoModel> BuscarEmprestimos(EmprestimoModel consulta)
		{
			List<EmprestimoModel> buscas = new List<EmprestimoModel>();

			using (SqlCommand command = Connection.CreateCommand())
			{
				StringBuilder sql = new StringBuilder();
				sql.AppendLine("SELECT DISTINCT i.nome, i.nomeAutor, i.nomeEditora, i.stts, i.secao, i.tipoItem, i.nomeLocal, r.nomeLeitor, r.dataReserva, r.prazoREservs");
				sql.AppendLine("FROM MvTbiibReservaa r INNER JOIN mvtBiibItemAcervo i ON r.codItem = i.codItem");
				sql.AppendLine("WHERE 1 = 1");
				if (!string.IsNullOrEmpty(consulta.NomeItem))
				{
					sql.AppendLine($"AND i.nome LIKE '%' + @NomeItem + '%'");
					command.Parameters.AddWithValue("@NomeItem", consulta.NomeItem);
				}
				if (!string.IsNullOrEmpty(consulta.StatusItem))
				{
					sql.AppendLine($"AND i.stts LIKE '%' + @stts + '%'");
					command.Parameters.AddWithValue("@stts", consulta.StatusItem);
				}
				if (!string.IsNullOrEmpty(consulta.NomeAutor))
				{
					sql.AppendLine($"AND i.nomeAutor LIKE '%' + @nomeAutor + '%'");
					command.Parameters.AddWithValue("@nomeAutor", consulta.NomeAutor);
				}
				if (!string.IsNullOrEmpty(consulta.NomeLeitor))
				{
					sql.AppendLine($"AND r.nomeLeitor LIKE '%' + @nomeLeitor + '%'");
					command.Parameters.AddWithValue("@nomeLeitor", consulta.NomeLeitor);
				}
				if (!string.IsNullOrEmpty(consulta.NomeLocal))
				{
					sql.AppendLine($"AND i.nomeLocal LIKE '%' + @nomeLocal + '%'");
					command.Parameters.AddWithValue("@nomeLocal", consulta.NomeLocal);
				}
				if (!string.IsNullOrEmpty(consulta.NomeSecao))
				{
					sql.AppendLine($"AND i.secao LIKE '%' + @secao + '%'");
					command.Parameters.AddWithValue("@secao", consulta.NomeSecao);
				}
				if (!string.IsNullOrEmpty(consulta.TipoItem))
				{
					sql.AppendLine($"AND i.tipoItem LIKE '%' + @tipoItem + '%'");
					command.Parameters.AddWithValue("@tipoItem", consulta.TipoItem);
				}
				if (!string.IsNullOrEmpty(consulta.DataReserva) && !string.IsNullOrEmpty(consulta.DataRetorno))
				{
					sql.AppendLine($"AND r.prazoREservs >= @DataInicio AND r.prazoREservs <= @DataFim");
					command.Parameters.AddWithValue("@DataInicio", consulta.DataReserva);
					command.Parameters.AddWithValue("@DataFim", consulta.DataRetorno);
				}

				command.CommandText = sql.ToString();

				using (SqlDataReader dr = command.ExecuteReader())
				{
					while (dr.Read())
					{
						buscas.Add(PopulateDrBusca(dr));
					}
				}
			}
			return buscas;
		}

		private EmprestimoModel PopulateDrBusca(SqlDataReader dr)
		{
			EmprestimoModel model = new EmprestimoModel();

			if (DBNull.Value != dr["nome"])
			{
				model.NomeItem = dr["nome"].ToString();
			}
			if (DBNull.Value != dr["nomeAutor"])
			{
				model.NomeAutor = dr["nomeAutor"].ToString();
			}
			if (DBNull.Value != dr["nomeEditora"])
			{
				model.NomeEditora = dr["nomeEditora"].ToString();
			}
			if (DBNull.Value != dr["stts"])
			{
				model.StatusItem = dr["stts"].ToString();
			}
			if (DBNull.Value != dr["dataReserva"])
			{
				model.DataReserva = dr["dataReserva"].ToString();
			}
			if (DBNull.Value != dr["prazoREservs"])
			{
				model.DataRetorno = dr["prazoREservs"].ToString();
			}
			if (DBNull.Value != dr["nomeLeitor"])
			{
				model.NomeLeitor = dr["nomeLeitor"].ToString();
			}
			if (DBNull.Value != dr["nomeLocal"])
			{
				model.NomeLocal = dr["nomeLocal"].ToString();
			}
			if (DBNull.Value != dr["secao"])
			{
				model.NomeSecao = dr["secao"].ToString();
			}
			if (DBNull.Value != dr["tipoItem"])
			{
				model.TipoItem = dr["tipoItem"].ToString();
			}

			return model;
		}
	}
}
