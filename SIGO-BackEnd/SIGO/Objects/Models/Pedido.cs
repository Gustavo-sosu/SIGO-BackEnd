using System.ComponentModel.DataAnnotations.Schema;

namespace SIGO.Objects.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_cliente")]
        public int idCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Column("id_funcionario")]
        public int idFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        [Column("id_oficina")]
        public int idOficina { get; set; }
        public Oficina Oficina { get; set; }

        [Column("id_veiculo")]
        public int idVeiculo { get; set; }
        public Veiculo Veiculo { get; set; }

        [Column("valorTotal")]
        public float ValorTotal { get; set; }

        [Column("descontoReais")]
        public float DescontoReais { get; set; }

        [Column("descontoPorcentagem")]
        public float DescontoPorcentagem { get; set; }

        [Column("descontoTotalReais")]
        public float DescontoTotalReais { get; set; }

        [Column("descontoServicoPorcentagem")]
        public float DescontoServicoPorcentagem { get; set; }

        [Column("descontoServicoReais")]
        public float DescontoServicoReais { get; set; }

        [Column("descontoPecaPorcentagem")]
        public float DescontoPecaPorcentagem { get; set; }

        [Column("descontoPecaReais")]
        public float descontoPecaReais { get; set; }

        [Column("observacao")]
        public string Observacao { get; set; }

        [Column("dataInicio")]
        public DateOnly DataInicio { get; set; }

        [Column("dataFim")]
        public DateOnly DataFim { get; set; }

        public ICollection<Pedido_Peca> Pedido_Pecas { get; set; } = new List<Pedido_Peca>();
        public ICollection<Pedido_Servico> Pedido_Servicos { get; set; } = new List<Pedido_Servico>();

        public Pedido()
        {
        }

        public Pedido(int id, int idCliente, Cliente cliente, int idFuncionario, Funcionario funcionario, int idOficina, Oficina oficina, int idVeiculo, Veiculo veiculo, float valorTotal, float descontoReais, float descontoPorcentagem, float descontoTotalReais, float descontoServicoPorcentagem, float descontoServicoReais, float descontoPecaPorcentagem, float descontoPecaReais, string observacao, DateOnly dataInicio, DateOnly dataFim, ICollection<Pedido_Peca> pedido_Pecas, ICollection<Pedido_Servico> pedido_Servicos)
        {
            Id = id;
            this.idCliente = idCliente;
            Cliente = cliente;
            this.idFuncionario = idFuncionario;
            Funcionario = funcionario;
            this.idOficina = idOficina;
            Oficina = oficina;
            this.idVeiculo = idVeiculo;
            Veiculo = veiculo;
            ValorTotal = valorTotal;
            DescontoReais = descontoReais;
            DescontoPorcentagem = descontoPorcentagem;
            DescontoTotalReais = descontoTotalReais;
            DescontoServicoPorcentagem = descontoServicoPorcentagem;
            DescontoServicoReais = descontoServicoReais;
            DescontoPecaPorcentagem = descontoPecaPorcentagem;
            this.descontoPecaReais = descontoPecaReais;
            Observacao = observacao;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Pedido_Pecas = pedido_Pecas;
            Pedido_Servicos = pedido_Servicos;
        }
    }
}
