using UnityEngine;

namespace Com.InfallibleCode._Shared
{
    public class Door : MonoBehaviour
    {
        private static readonly int IsOpen = Animator.StringToHash("IsOpen");
        
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void Open()
        {
            _animator.SetBool(IsOpen, true);
        }
    }
}