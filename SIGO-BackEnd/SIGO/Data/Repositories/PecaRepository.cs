using SIGO.Data.Interfaces;
using SIGO.Objects.Models;

namespace SIGO.Data.Repositories
{
    public class PecaRepository : GenericRepository<Peca>, IPecaRepository
    {
        private readonly AppDbContext _context;

        public PecaRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
