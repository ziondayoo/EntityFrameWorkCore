using EntityFrameWorkCore.Data;

namespace EntityFrameWorkCore.ConsoleApp
{
    class Program
    {
        private static readonly FootballLeagueDbContext context = new FootballLeagueDbContext();
        static void Main(string[] args)
        {
            context.Leagues.Add(new Domain.League { Name = "Red Stripe Premiere League" });
            context.SaveChangesAsync();
        }
    }
}