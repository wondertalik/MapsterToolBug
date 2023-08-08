using Mapster;
using CompanyContract = MapsterToolBug.Services.Contracts.Configurations.Company;
using CompanyCore = MapsterToolBug.Domain.Core.Configurations.Entities.Company;

using UserContract = MapsterToolBug.Services.Contracts.Configurations.User;
using UserCore = MapsterToolBug.Domain.Core.Configurations.Entities.User;

namespace MapsterToolBug.Services.Configurations;

[Mapper]
public interface IConfigurationMapper
{
    UserCore Map((UserContract user, CompanyContract company) item);
}