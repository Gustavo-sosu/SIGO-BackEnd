using SIGO.Objects.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Dtos.Entities
{
    public class Funcionario_ServicoDTO
    {
        public int IdFuncionario { get; set; }

        public int IdServico { get; set; }

        public string TempoDec { get; set; }

    }
}
