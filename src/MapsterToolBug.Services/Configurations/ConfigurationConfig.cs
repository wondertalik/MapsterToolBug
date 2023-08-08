using Mapster;
using CompanyContract = MapsterToolBug.Services.Contracts.Configurations.Company;
using UserContract = MapsterToolBug.Services.Contracts.Configurations.User;
using UserCore = MapsterToolBug.Domain.Core.Configurations.Entities.User;

namespace MapsterToolBug.Services.Configurations;


public class ConfigurationConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(UserContract user, CompanyContract company), UserCore>();
    }
}