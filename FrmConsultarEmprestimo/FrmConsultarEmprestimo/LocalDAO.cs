using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class LocalDAO
	{
		
			private SqlConnection Connection { get; }

			public LocalDAO(SqlConnection connection)
			{
				Connection = connection;
			}

			public List<EmprestimoModel> GetLocais()
			{
				List<EmprestimoModel> locais = new List<EmprestimoModel>();
				using (SqlCommand command = Connection.CreateCommand())
				{
					StringBuilder sql = new StringBuilder();
					sql.AppendLine("SELECT descricaoLocal FROM MvtBIBLocal ORDER BY codLocal");
					command.CommandText = sql.ToString();
					using (SqlDataReader dr = command.ExecuteReader())
					{
						while (dr.Read())
						{
							locais.Add(PopulateDrLocal(dr));
						}
					}
				}
				return locais;
			}

			public EmprestimoModel PopulateDrLocal(SqlDataReader dr)
			{
				string descricaoLocal = "";

				if (DBNull.Value != dr["descricaoLocal"])
				{
					descricaoLocal = dr["descricaoLocal"] + "";
				}

				return new EmprestimoModel()
				{
					NomeLocal = descricaoLocal
				};
			}
		}
	}
