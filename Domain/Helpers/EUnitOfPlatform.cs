using System.ComponentModel;

namespace api_rest.Domain.Helpers
{
    public enum EUnitOfPlatform : byte
    {
        [Description("Riot")]
        Riot = 1,

        [Description("Epic Games")]
        EpicGames = 2,

        [Description("Steam")]
        Steam = 3,

        [Description("AllPlatforms")]
        AllPlatforms = 4
    }

}
