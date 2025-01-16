using UnityEngine;

namespace ComedyModPublic
{
    public class Performance
    {
        private static bool framerateValid(int framerate)
        {
            return framerate >= 1;
        }

        public static void SetMaxFPS(int desiredFramerate)
        {
            if (framerateValid(desiredFramerate))
            {
                // Disable vertical synchronization if it is enabled.
                if (QualitySettings.vSyncCount == 1)
                {
                    QualitySettings.vSyncCount = 0;
                    Logging.Log("Disabled vSync.");
                }

                Application.targetFrameRate = desiredFramerate;
                Logging.Log($"Successfully set maximum framerate to {desiredFramerate}.");
            }
            else
            {
                Logging.Warn($"{desiredFramerate} is not an acceptable framerate.");
            }
        }

        private static void searchAndDestroy(string objectToDestroy)
        {
            if (objectToDestroy != null)
            {
                UnityEngine.Object.Destroy(GameObject.Find(objectToDestroy));
                Logging.Log($"Successfully destroyed GameObject {objectToDestroy}.");
            }
            else
            {
                Logging.Warn($"Attempted to destroy {objectToDestroy}, a GameObject that is null.");
            }
        }

        public static void OptimizeScene(string sceneName)
        {
            switch(sceneName)
            {
                case "2. GameScene":
                    searchAndDestroy("Barman");
                    searchAndDestroy("Beer Glass");
                    searchAndDestroy("BeerTap");
                    searchAndDestroy("TipJar_Game");
                    searchAndDestroy("Lux Cube Volume");
                    searchAndDestroy("Smoke");
                    break;
            }
        }
    }
}
