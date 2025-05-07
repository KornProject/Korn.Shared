using Korn.Shared.Internal;
using Newtonsoft.Json;
using System;

namespace Korn.Shared
{
    public static class KornShared
    {
        static KornShared() => BaseKornException.BindLogger(Logger);

        public const string
            Net8TargetVersion = KornSharedInternal.Net8TargetVersion,
            Net472TargetVersion = KornSharedInternal.Net472TargetVersion,
            CurrentTargetVersion = KornSharedInternal.CurrentTargetVersion;

        public const string RootDirectory = KornSharedInternal.RootDirectory;
        public static readonly string[] TargetVersions = KornSharedInternal.TargetVersions;
        public static readonly Random Random = new Random();
        public static readonly KornLogger Logger = new KornLogger(Korn.Interface.KornDirectory.LogFile);
        public static readonly JsonSerializerSettings JsonSettings = KornSharedInternal.JsonSettings;
    }
}