using UnityEngine;

namespace Custom.Math
{
    /// <summary>
    /// Custom math utility functions for game development
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// Clamps a value between min and max
        /// </summary>
        public static float Clamp(float value, float min, float max)
        {
            return Mathf.Clamp(value, min, max);
        }

        /// <summary>
        /// Linear interpolation between two values
        /// </summary>
        public static float Lerp(float a, float b, float t)
        {
            return Mathf.Lerp(a, b, t);
        }

        /// <summary>
        /// Smooth interpolation using smoothstep
        /// </summary>
        public static float SmoothStep(float edge0, float edge1, float x)
        {
            float t = Clamp((x - edge0) / (edge1 - edge0), 0.0f, 1.0f);
            return t * t * (3.0f - 2.0f * t);
        }

        /// <summary>
        /// Remaps a value from one range to another
        /// </summary>
        public static float Remap(float value, float fromMin, float fromMax, float toMin, float toMax)
        {
            return toMin + (value - fromMin) * (toMax - toMin) / (fromMax - fromMin);
        }

        /// <summary>
        /// Checks if a value is approximately equal to another
        /// </summary>
        public static bool Approximately(float a, float b, float tolerance = 0.001f)
        {
            return Mathf.Abs(a - b) < tolerance;
        }

        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        public static float DegreesToRadians(float degrees)
        {
            return degrees * Mathf.Deg2Rad;
        }

        /// <summary>
        /// Converts radians to degrees
        /// </summary>
        public static float RadiansToDegrees(float radians)
        {
            return radians * Mathf.Rad2Deg;
        }
    }
}
