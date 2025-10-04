using BepInEx.Unity.IL2CPP.UnityEngine;
using Il2CppSystem;
using System;
using UnityEngine;


namespace MegabonkMultiplayer
{
    public class MultiplayerMenu : MonoBehaviour
    {
        private bool showMenu = false;
        private string ipAddress = "127.0.0.1";

        public void Awake()
        {
            this.gameObject.hideFlags = HideFlags.HideAndDontSave;
            MegabonkMultiplayerBootstrap.Log.LogInfo("Awake called");
        }

        public void Start()
        { 
            MegabonkMultiplayerBootstrap.Log.LogInfo("Start called");
        }

        public void Update()
        {
            if (Input.GetKeyInt(BepInEx.Unity.IL2CPP.UnityEngine.KeyCode.H))
            {
                Debug.Log("H Pressed");
            }

            if (Input.GetKeyInt(BepInEx.Unity.IL2CPP.UnityEngine.KeyCode.M))
            {
                Debug.Log("M Pressed");
                showMenu = !showMenu;
            }

        }
    }
}
