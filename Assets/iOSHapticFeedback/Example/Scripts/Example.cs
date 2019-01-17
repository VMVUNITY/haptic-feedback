using UnityEngine;

namespace iOSHaptic.Example {
    public class Example : MonoBehaviour {
        public void HapticFeedbackHandler(int feedback) {
            if (feedback > 2) {
                return;
            }

#if UNITY_IOS
            HapticFeedbackGenerator.DoFeedback((HapticFeedback) feedback);
#endif
        }
    }
}