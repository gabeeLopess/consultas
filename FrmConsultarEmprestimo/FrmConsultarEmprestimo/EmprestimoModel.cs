using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConsultarEmprestimo
{
	public class EmprestimoModel
	{
		public string CodItem { get; set; }

		public string NomeItem { get; set; }

		public string NomeEditora { get; set; }

		public string TipoItem { get; set; }

		public string NomeLocal { get; set; }

		public string CodLocal { get; set; }

		public string NomeAutor { get; set; }

		public string CodAutor { get; set; }

		public string NomeLeitor { get; set; }

		public string NomeSecao { get; set; }

		public string StatusItem { get; set; }

		public string DataReserva { get; set; }

		public string DataRetorno { get; set; }

	}
}
