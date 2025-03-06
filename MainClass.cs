namespace FullDiveSDK
{
    public class MainClass
    {
        public class PlayerVelocity : Velocity
        {
            Velocity Velocity { get; set; }

            public static readonly PlayerVelocity Instance = new PlayerVelocity();
        }
        public static string? GetWorld { get; set; }
        public static string? WindowHeight { get; set; }
        public static string? WindowWidth { get; set; }
        public static object? Player { get; set; }
        public static string GetVersion(int Version)
        {
            return GetVersion(Version);
        }
        public static string GetApplication(string AppName, int AppHeight, int AppWidth)
        {
            return GetApplication(AppName, AppHeight, AppWidth);
        }
        public static int GetObjectXYZ(int X, int Y, int Z)
        {
            return GetObjectXYZ(X, Y, Z);
        }
        public static int GetObjectXYZ(double X, double Y, double Z)
        {
            return GetObjectXYZ(X, Y, Z);
        }
        public static int GetObjectRotation(int X, int Y, int Z)
        {
            return GetObjectRotation(X, Y, Z);
        }
        public static int GetObjectRotation(double X, double Y, double Z)
        {
            return GetObjectRotation(X, Y, Z);
        }
        public static int GetObjectScale(int X, int Y, int Z)
        {
            return GetObjectScale(X, Y, Z);
        }

        public static int GetObjectScale(double X, double Y, double Z)
        {
            return GetObjectScale(X, Y, Z);
        }
        public static int SetObjectScale(int X, int Y, int Z)
        {
            return SetObjectScale(X, Y, Z);
        }
    }
}
