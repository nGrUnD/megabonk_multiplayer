using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace MegabonkMultiplayer
{
    [BepInPlugin("com.yourname.megabonk.multiplayer", "Megabonk Multiplayer", "1.0.0")]
    public class MegabonkMultiplayerBootstrap : BasePlugin
    {
        internal static new ManualLogSource Log;

        private static GameObject MultiplayerMenuObject;

        public override void Load()
        {
            Log = base.Log;

            Log.LogInfo("Megabonk Multiplayer Mod loaded!");
            ClassInjector.RegisterTypeInIl2Cpp<MultiplayerMenu>();

            MultiplayerMenuObject = new GameObject("MegabonkMultiplayer");
            MultiplayerMenuObject.AddComponent<MultiplayerMenu>();
            GameObject.DontDestroyOnLoad(MultiplayerMenuObject);
        }

        public override bool Unload()
        {
            if (MultiplayerMenuObject != null)
            {
                Object.Destroy(MultiplayerMenuObject);
                MultiplayerMenuObject = null;
            }

            Log.LogInfo("Plugin Megabonk Multiplayer unloaded!");
            return true;
        }

    }
}
