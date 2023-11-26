using ResticManager.Testing.Data;
using Microsoft.EntityFrameworkCore;

namespace ResticManager.Testing.Components.Pages
{
    public partial class Home
    {
        private ResticContext? _context;
        public List<ResticRepository>? ResticRepositories { get; set; }
        public int RepositoryCount { get; set; }
        public string? DatabaseProvider {  get; set; }
        public int SnapshotCount { get; set; }
        
        
        protected override async Task OnInitializedAsync()
        {
            await ShowRepositories();
        }

        public async Task ShowRepositories()
        {
            _context ??= await ResticContextFactory.CreateDbContextAsync();
            RepositoryCount = await _context.Repositories.CountAsync();
            DatabaseProvider = _context.Database.ProviderName;
            SnapshotCount = _context.ResticSnapshots.Count();

            if (_context is not null)
            {
                ResticRepositories = await _context.Repositories.ToListAsync();
            }

            if (_context is not null) await _context.DisposeAsync();
        }
    }
}
