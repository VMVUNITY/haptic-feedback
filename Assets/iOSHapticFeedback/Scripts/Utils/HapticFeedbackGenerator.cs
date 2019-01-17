#if UNITY_IOS
using System.Runtime.InteropServices;
using UnityEngine.iOS;

namespace iOSHaptic {
    public static class HapticFeedbackGenerator {
        [DllImport("__Internal")]
        private static extern void HeavyFeedback();

        [DllImport("__Internal")]
        private static extern void MediumFeedback();

        [DllImport("__Internal")]
        private static extern void LightFeedback();


        public static void DoFeedback(HapticFeedback feedback) {
            if (Device.generation < DeviceGeneration.iPhone7) {
                return;
            }

            switch (feedback) {
                case HapticFeedback.Light:
                    LightFeedback();
                    break;
                case HapticFeedback.Medium:
                    MediumFeedback();
                    break;
                case HapticFeedback.Heavy:
                    HeavyFeedback();
                    break;
            }
        }
    }
}
#endif