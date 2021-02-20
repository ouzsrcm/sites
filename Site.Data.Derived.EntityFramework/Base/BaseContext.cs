using Microsoft.EntityFrameworkCore;

namespace Site.Data.Derived.EntityFramework.Base
{
    public class BaseContext : DbContext
    {

        public BaseContext()
        {

        }

        public BaseContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}