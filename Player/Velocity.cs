using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullDiveSDK.Player
{
    public class Velocity()
    {
        public int SetMinSpeed;
        public int GetMinSpeed;
        public int SetMaxSpeed;
        public int GetMaxSpeed;
        public int SetCurrentSpeed;
        public int GetCurrentSpeed;
    }
    public static class GetVelocity
    {
        public static Velocity Get()
        {
            return new Velocity();
        }
    }
}
