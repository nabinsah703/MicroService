using System;
using PlateformService.Model;

namespace PlateformService.DataLayer;

public interface IPlatformRepo
{
bool SaveChanges();
IEnumerable<Platform> GetAll();
Platform GetPlatformByID(int? id);
void CreatePlatform(Platform platform);
}
