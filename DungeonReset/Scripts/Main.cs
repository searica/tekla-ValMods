﻿using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Jotunn.Utils;

namespace DungeonReset
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInDependency(Jotunn.Main.ModGuid, BepInDependency.DependencyFlags.HardDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    public class Main : BaseUnityPlugin
    {
        #region[Declarations]
        public const string
            NAME = "DungeonReset",
            AUTHOR = "Tekla",
            GUID = AUTHOR + "_" + NAME,
            VERSION = "5.4.1603";

        internal readonly Harmony Harmony;
        internal readonly Assembly Assembly;
        internal readonly string Folder;
        #endregion

        internal static Main Instance;
        internal static ManualLogSource Log;

        public Main()
        {
            Log = new ManualLogSource(NAME);
            Harmony = new Harmony(GUID);
            Assembly = Assembly.GetExecutingAssembly();
            Folder = Path.GetDirectoryName(Assembly.Location);
            Instance = this;
        }

        public void Awake()
        {
            Configs.Awake(this);
            Commands.Awake();

            if (!Configs.Enable.Value)
                return;
            if (Configs.LoggerEnable.Value)
                BepInEx.Logging.Logger.Sources.Add(Log);

            Harmony.PatchAll(Assembly);
        }
    }
}