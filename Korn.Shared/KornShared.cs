using Korn.Shared.Internal;
using Newtonsoft.Json;
using System;

namespace Korn.Shared
{
    public static class KornShared
    {
        public const string RootDirectory = KornSharedInternal.RootDirectory;
        public static readonly Random Random = new Random();
        public static readonly KornLogger Logger = new KornLogger(Korn.Interface.SharedData.LogFile);
        public static readonly JsonSerializerSettings JsonSettings = KornSharedInternal.JsonSettings;

        static KornShared()
        {
            BaseKornException.BindLogger(Logger);
        }
    }
}