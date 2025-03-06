namespace FullDiveSDK
{
    public class Chemistry
    {
        public int GetTemperature { get; set; }
        public int GetPressure { get; set; }
        public int GetVolume { get; set; }
        public Chemistry()
        {
            GetTemperature = 0;
            GetPressure = 0;
            GetVolume = 0;
        }
    }
}
