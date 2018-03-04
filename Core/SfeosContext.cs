using Microsoft.EntityFrameworkCore;
using Sfeos.Game.Core.Models;

namespace Sfeos.Game.Core
{
	public class SfeosContext : DbContext
    {
		public DbSet<Captain> Captains { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(LocalConfig.ConnectionString);
		}
	}
}
