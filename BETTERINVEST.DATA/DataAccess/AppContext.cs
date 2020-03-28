using Microsoft.EntityFrameworkCore;

namespace BETTERINVEST.DATA.DataAccess
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
