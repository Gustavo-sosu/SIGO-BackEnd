namespace SIGO.Objects.Dtos.Entities
{
    public class Pedido_PecaDTO
    {
        public int IdPedido { get; set; }

        public int IdPeca { get; set; }

        public int Quantidade { get; set; }

        public DateOnly DataInstalacao { get; set; }

        public string Estado { get; set; }

        public string Observacao { get; set; }
    }
}
