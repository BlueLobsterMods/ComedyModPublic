using MelonLoader;
using ComedyModPublic;

// MelonLoader-specific properties.
[assembly: MelonInfo(typeof(ComedyModPublicCore), "ComedyModPublic", "0.4", "Blue Lobster Software")]
[assembly: MelonGame("Lighthouse Games Studio", "Comedy Night")]
[assembly: MelonColor(255, 255, 0, 0)]

namespace ComedyModPublic
{
    public class ComedyModPublicCore : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Logging.Initialize(LoggerInstance);
            Logging.Log("Initialized.");

            Performance.SetMaxFPS(60);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            Logging.LogSceneLoad(sceneName, buildIndex);
            Performance.OptimizeScene(sceneName);
        }
    }
}
