using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Services.Entities
{
    public class OficinaService : GenericService<Oficina, OficinaDTO>, IOficinaService
    {
        private readonly IOficinaRepository _oficinaRepository;
        private readonly IMapper _mapper;

        public OficinaService(IOficinaRepository oficinaRepository, IMapper mapper)
            : base(oficinaRepository, mapper)
        {
            _oficinaRepository = oficinaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OficinaDTO>> GetByName(string nomeOficina)
        {
            var oficinas = await _oficinaRepository.GetByName(nomeOficina);
            return _mapper.Map<IEnumerable<OficinaDTO>>(oficinas);
        }
    }
}
