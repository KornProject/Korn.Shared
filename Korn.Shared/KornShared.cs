using System;

namespace Korn.Shared
{
    public static class KornShared
    {
        public static readonly Random Random = new Random();
        public static readonly KornLogger Logger = new KornLogger(KornPaths.SharedLogFile);

        static KornShared()
        {
            BaseKornException.BindLogger(Logger);
        }
    }
}