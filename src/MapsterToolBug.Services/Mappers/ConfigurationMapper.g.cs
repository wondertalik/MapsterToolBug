using System;
using MapsterToolBug.Domain.Core.Configurations.Entities;
using MapsterToolBug.Services.Configurations;
using MapsterToolBug.Services.Contracts.Configurations;

using User2 = MapsterToolBug.Services.Contracts.Configurations.User;

/// TODO: this mapper is wrong
namespace MapsterToolBug.Services.Configurations
{
    public partial class ConfigurationMapper : IConfigurationMapper
    {
        public User Map(ValueTuple<User2, Company> p1)
        {
            return new User() {};
        }
    }
}