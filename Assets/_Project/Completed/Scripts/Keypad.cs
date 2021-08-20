using Com.InfallibleCode._Shared;

namespace Com.InfallibleCode.Completed
{
    public class Keypad : BaseKeypad
    {
        public delegate void UnlockHandler();
        public event UnlockHandler Unlocked;
        
        public override void Enter()
        {
            if (CurrentInput == Code)
            {
                Unlocked?.Invoke();
            }
        }
    }
}