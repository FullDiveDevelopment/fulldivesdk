using FullDiveSDK;
using FullDiveSDK.Player;


namespace FullDiveSDK.Player
{
    public class Player
    {
        public static int PlayerId { get; set; }
        public static string? Name { get; set; }
        public static string? Description { get; set; }
        public static int Level { get; set; }
        public static PlayerState? State { get; set; }
        public static bool IsPlaying { get; set; }
        public static bool IsWalking { get; set; }
        public static bool IsMoving { get; set; }
        public static bool IsRunning { get; set; }
        public static bool IsJumping { get; set; } 
        public static bool IsFlying { get; set; }
        public static bool IsFalling { get; set; }
        public static bool IsSwimming { get; set; }
        public static bool IsCrouching { get; set; }
        public static bool IsSitting { get; set; }
        public static bool IsLying { get; set; }
        public static bool IsDead { get; set; }
        public static bool IsAlive { get; set; }
        public static bool IsInCombat { get; set; }
        public static bool IsInVehicle { get; set; }
        public static bool IsInWater { get; set; }
        public static bool IsInAir { get; set; }
        public static bool IsInSpace { get; set; }
        public static bool IsInVehicleSeat { get; set; }
        public static bool IsOnline { get; set; }
    }
}
