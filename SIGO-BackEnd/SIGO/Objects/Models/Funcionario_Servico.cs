using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("funcionario_servico")]
    public class Funcionario_Servico
    {
        [Column("idFuncionario")]
        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        [Column("idServico")]
        public int IdServico { get; set; }
        public Servico Servico { get; set; }

        [Column("tempodec")]
        public string TempoDec { get; set; }

        public Funcionario_Servico() { }

        public Funcionario_Servico(int idFuncionario, int idServico, string tempoDec)
        {
            IdFuncionario = idFuncionario;
            IdServico = idServico;
            TempoDec = tempoDec;
        }
    }
}
