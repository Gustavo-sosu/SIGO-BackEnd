using AutoMapper;
using SIGO.Data.Interfaces;
using SIGO.Objects.Dtos.Entities;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Services.Entities
{
    public class ClienteService : GenericService<Cliente, ClienteDTO>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        private readonly ITelefoneRepository _telefoneRepository;

        public ClienteService(IClienteRepository clienteRepository, ITelefoneRepository telefoneRepository, IMapper mapper)
            : base(clienteRepository, mapper)
        {
            _clienteRepository = clienteRepository;
            _telefoneRepository = telefoneRepository;
            _mapper = mapper;
        }
        public override async Task<IEnumerable<ClienteDTO>> GetAll()
        {
            var entities = await _clienteRepository.Get();
            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
        }

        public async Task<ClienteDTO?> GetByIdWithDetails(int id)
        {
            var entity = await _clienteRepository.GetByIdWithDetails(id);
            return _mapper.Map<ClienteDTO?>(entity);
        }

        public async Task<IEnumerable<ClienteDTO>> GetByNameWithDetails(string nome)
        {
            var entities = await _clienteRepository.GetByNameWithDetails(nome);
            return _mapper.Map<IEnumerable<ClienteDTO>>(entities);
        }

        public async Task<ClienteDTO?> GetById(int id)
        {
            var entity = await _clienteRepository.GetById(id);
            return _mapper.Map<ClienteDTO?>(entity);
        }

        public async Task<ClienteDTO> Create(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            cliente = await _clienteRepository.Add(cliente);
            return _mapper.Map<ClienteDTO>(cliente);
        }

        public override async Task Update(ClienteDTO clienteDTO, int id)
        {
            var existingCliente = await _clienteRepository.GetById(id);
            if (existingCliente == null)
            {
                throw new KeyNotFoundException($"Cliente com id {id} não encontrado.");
            }

            clienteDTO.Id = id;

            // Atualiza dados do cliente
            var clienteEntity = _mapper.Map<Cliente>(clienteDTO);
            await _clienteRepository.Update(clienteEntity);

            // Sincroniza telefones (atualiza existentes e adiciona novos)
            if (clienteDTO.Telefones != null)
            {
                foreach (var telefoneDto in clienteDTO.Telefones)
                {
                    telefoneDto.ClienteId = id;
                    var telefoneEntity = _mapper.Map<Telefone>(telefoneDto);

                    if (telefoneEntity.Id > 0)
                    {
                        await _telefoneRepository.Update(telefoneEntity);
                    }
                    else
                    {
                        await _telefoneRepository.Add(telefoneEntity);
                    }
                }
            }
        }
    }
}
