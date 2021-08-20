using Com.InfallibleCode._Shared;
using UnityEngine;

namespace Com.InfallibleCode.Completed
{
    public class KeypadDoor : Door
    {
        [SerializeField] private Keypad keypad;
        
        private void Start()
        {
            keypad.Unlocked += Open;
        }

        private void OnDestroy()
        {
            keypad.Unlocked -= Open;
        }
    }
}