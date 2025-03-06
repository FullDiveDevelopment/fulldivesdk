namespace FullDiveSDK
{
    public class Velocity
    {
        public int GetCurrentSpeed { get; set; }
        public int GetMinSpeed { get; set; }
        public int GetMaxSpeed { get; set; }

        public Velocity ()
        {
            GetCurrentSpeed = 0;
            GetMinSpeed = 0;
            GetMaxSpeed = 0;
        }
    }
}
