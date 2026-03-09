using Microsoft.EntityFrameworkCore;
using SIGO.Data.Interfaces;
using SIGO.Objects.Models;
using SIGO.Services.Interfaces;

namespace SIGO.Data.Repositories
{
    public class OficinaRepository : GenericRepository<Oficina>, IOficinaRepository
    {
        private readonly AppDbContext _context;

        public OficinaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Oficina>> GetByName(string nomeOficina)
        {
            return await _context.Oficinas
                .Where(m => m.Nome.Contains(nomeOficina))
                .ToListAsync();
        }
    }
}

