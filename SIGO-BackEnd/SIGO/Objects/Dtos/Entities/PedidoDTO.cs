namespace SIGO.Objects.Dtos.Entities
{
    public class PedidoDTO
    {
        public int Id { get; set; }

        public int idCliente { get; set; }

        public int idFuncionario { get; set; }

        public int idOficina { get; set; }

        public int idVeiculo { get; set; }

        public float ValorTotal { get; set; }

        public float DescontoReais { get; set; }

        public float DescontoPorcentagem { get; set; }

        public float DescontoTotalReais { get; set; }

        public float DescontoServicoPorcentagem { get; set; }

        public float DescontoServicoReais { get; set; }

        public float DescontoPecaPorcentagem { get; set; }

        public float descontoPecaReais { get; set; }

        public string Observacao { get; set; }

        public DateOnly DataInicio { get; set; }

        public DateOnly DataFim { get; set; }

        public List<Pedido_PecaDTO> Pedido_Pecas { get; set; } = new();
        public List<Pedido_ServicoDTO> Pedido_Servicos { get; set; } = new();
    }
}
