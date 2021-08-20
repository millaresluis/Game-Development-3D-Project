using UnityEngine;

namespace Com.InfallibleCode._Shared
{
    public abstract class Key : MonoBehaviour, IInteractable
    {
        [SerializeField] protected BaseKeypad Keypad;
        
        public abstract void Interact();
    }
}