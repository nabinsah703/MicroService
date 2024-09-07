using System;
using PlateformService.Model;

namespace PlateformService.DataLayer;

public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext _context;

    public PlatformRepo(AppDbContext context)
    {
        _context = context;
    }

    public void CreatePlatform(Platform platform)
    {
        if (platform == null)
        {
            throw new ArgumentNullException(nameof(platform));
        }
        _context.platforms.Add(platform);
    }

    public IEnumerable<Platform> GetAll()
    {
        return _context.platforms.ToList();
    }

    public Platform GetPlatformByID(int? id)
    {
        return _context.platforms.FirstOrDefault(p => p.ID == id)!;
    }

    public bool SaveChanges()
    {
        return (_context.SaveChanges() >= 0);
    }
}
