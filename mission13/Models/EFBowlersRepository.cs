using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission13.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlersDbContext _context { get; set; }

        public EFBowlersRepository(BowlersDbContext context)
        {
            _context = context;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;
    }
}
