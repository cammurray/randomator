using System.Linq;
using System.Security.Cryptography;
using Randomator.Data;
using Randomator.Models.Data;

namespace Randomator.Factories.Role;

/// <summary>
/// Generate a random role
/// </summary>

internal static class factoryRole
{
    public static RandomRole Generate()
    {
        // Get random role
        DataRoleDepartmentPair RoleDepartmentPair =
            DataRoleDepartments.RoleDepartmentPairs.ElementAt(
                RandomNumberGenerator.GetInt32(0, DataRoleDepartments.RoleDepartmentPairs.Count));

        return new RandomRole()
        {
            Department = RoleDepartmentPair.Department.ElementAt(RandomNumberGenerator.GetInt32(0,RoleDepartmentPair.Department.Length)),
            Name = RoleDepartmentPair.Role
        };

    }
}