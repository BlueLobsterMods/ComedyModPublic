using UnityEngine;

namespace ComedyModPublic
{
    public class Performance
    {
        private static bool FramerateValid(int Framerate)
        {
            return Framerate >= 1;
        }

        public static void SetMaxFPS(int DesiredFramerate)
        {
            if (FramerateValid(DesiredFramerate))
            {
                // Disable vertical synchronization if it is enabled.
                if (QualitySettings.vSyncCount == 1)
                {
                    QualitySettings.vSyncCount = 0;
                    Logging.Log("Disabled vSync.");
                }

                Application.targetFrameRate = DesiredFramerate;
                Logging.Log($"Successfully set maximum framerate to {DesiredFramerate}.");
            }
            else
            {
                Logging.Warn($"{DesiredFramerate} is not an acceptable framerate.");
            }
        }
    }
}
