using BepInEx;
using LCSoundTool;
using UnityEngine;

namespace Normal_Airhorn
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            AudioClip newSound;
            newSound = SoundTool.GetAudioClip("Meowpixel-Normal Airhorn", "airhorn.mp3");

            SoundTool.ReplaceAudioClip("AirHorn1", newSound);

        }
    }
}
