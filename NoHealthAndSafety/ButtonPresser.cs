using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace NoHealthAndSafety
{
    class ButtonPresser : MonoBehaviour
    {
        private static IEnumerator ClickIt()
        {
            yield return new WaitForSeconds(.2f);
            foreach (var button in Resources.FindObjectsOfTypeAll<Button>().Where(x => x.name == "Continue"))
            {
                button.onClick.Invoke();
            }
        }

        void Start()
        {
            StartCoroutine(ClickIt());
        }
    }
}
