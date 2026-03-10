using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Services.Entities
{
    public class PedidoService : GenericService<Pedido, PedidoDTO>, IPedidoService
    {
        public PedidoService(IPedidoRepository pedidoRepository, IMapper mapper)
            : base(pedidoRepository, mapper)
        {
        }
    }
}
