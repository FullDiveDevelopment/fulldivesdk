using FullDiveSDK.Player;
using System.Net.Http;
using System.Net.Http.Json;

namespace FullDiveSDK
{
    public class MainClass
    {
        public void Main()
        {
            Console.WriteLine("SDK Initializing");
            

        }


        public static HttpClient Server(string IPAddress, int Port)
        {
            // Work in Progress

            return new HttpClient();
        }

        public class New(string WorldName, bool isOnline) {
            
            public JsonContent JsonContent = JsonContent.Create(new
            {
                WorldName = WorldName,
                isOnline = isOnline,
            });
        }


        public class PlayerVelocity : Velocity
        {
            public Velocity? Velocity { get; set; }
        }
        public static string? GetWorld { get; set; }
        public static string GetVersion(int Version)
        {
            return GetVersion(Version);
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
