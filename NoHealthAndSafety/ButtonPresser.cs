using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace NoHealthAndSafety
{
    class ButtonPresser : MonoBehaviour
    {
        private static IEnumerator ClickIt()
        {
            yield return new WaitForSeconds(.3f);
            foreach (var button in Resources.FindObjectsOfTypeAll<Button>())
            {
                if (button.name == "Continue")
                {
                    button.onClick.Invoke();
                }
            }
        }

        void Start()
        {
            StartCoroutine(ClickIt());
        }
    }
}
