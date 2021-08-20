namespace Com.InfallibleCode._Shared
{
    public class ClearKey : Key
    {
        public override void Interact()
        {
            Keypad.Clear();
        }
    }
}