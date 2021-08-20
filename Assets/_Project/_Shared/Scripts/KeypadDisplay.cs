using TMPro;
using UnityEngine;

namespace Com.InfallibleCode._Shared
{
    public class KeypadDisplay : MonoBehaviour
    {
        [SerializeField] private TMP_Text label;
        [SerializeField] private BaseKeypad keypad;

        private void Update()
        {
            label.text = $"{keypad.CurrentInput:00000000}";
        }
    }
}