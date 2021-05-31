using IPA;
using UnityEngine;
using UnityEngine.SceneManagement;
using IPALogger = IPA.Logging.Logger;

namespace NoHealthAndSafety
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public static string PluginName => "NoHealthAndSafety";

        [Init]
        public void Init(IPALogger logger)
        {
            Logger.LOG = logger;
        }

        [OnStart]
        public void OnApplicationStart()
        {
            SceneManager.activeSceneChanged += OnActiveSceneChanged;
        }

        [OnExit]
        public void OnApplicationQuit()
        {
            SceneManager.activeSceneChanged -= OnActiveSceneChanged;
        }

        private static void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {
            if (nextScene.name == "HealthWarning")
            {
                new GameObject("ButtonPresser").AddComponent<ButtonPresser>();
            }
        }
    }
}
