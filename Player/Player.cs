using FullDiveSDK;
using FullDiveSDK.Player;


namespace Player
{
    internal class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public PlayerState State { get; set; }
        public bool isPlaying { get; set; }
        public bool isWalking { get; set; }
        public bool isMoving { get; set; }
        public bool isRunning { get; set; }
    }
}
