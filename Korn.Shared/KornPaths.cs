using Korn.Shared.Internal;
using System.IO;

namespace Korn.Shared
{
    public static class KornPaths
    {
        public static readonly string
            RootDirectory = KornSharedInternal.RootDirectory,
                DataDirectory = Path.Combine(RootDirectory, "Data"),
                    SharedLogFile = Path.Combine(DataDirectory, "log.txt"),
                    PluginsListFile = Path.Combine(DataDirectory, "plugins.txt");
    }
}