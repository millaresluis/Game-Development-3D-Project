using UnityEngine;

namespace Com.InfallibleCode._Shared
{
    public class NumberKey : Key
    {
        [SerializeField] private int value;
        
        public override void Interact()
        {
            Keypad.Add(value);
        }
    }
}