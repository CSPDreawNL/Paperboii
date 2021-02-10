using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraMath
{
    static public ExtraMath current;

    public ExtraMath()
    {
        current = this;
    }

    public Vector3 ClampedVector3Lerp(Vector3 a, Vector3 b, float time)
    {
        Vector3 result = new Vector3();

        result.x = ClampedFloatLerp(a.x, b.x, time);
        result.y = ClampedFloatLerp(a.y, b.y, time);
        result.z = ClampedFloatLerp(a.z, b.z, time);

        return result;
    }

    // Calculators
    public float ClampedFloatLerp(float a, float b, float time)
    {
        if (time != 0)
        {
            float difference = b - a;
            float distance = Mathf.Abs(difference);
            return Mathf.Clamp(difference * Time.deltaTime / time, -distance, distance);
        }
        else
        {
            return b - a;
        }
    }
}
