using System;
using System.Collections.Generic;
using System.Text;

namespace EX29_09_sasakihodaka
{
    class Box
    {
        public static float GetVolume(float w, float h, float d)
        {
            return w * h * d;
        }
        public static float GetSurface(float w, float h, float d)
        {
            return (w * h + h * d + d * w) * 2;
        }
    }
    
}
