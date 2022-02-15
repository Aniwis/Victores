using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Victor 
{
    public float x;
    public float y;

    public Victor(float xC, float yC)
    {
        x = xC;
        y = yC;

    }
        public Victor Suma(Victor other)
        {
         var result = new Victor(x + other.x, y + other.y);
            
            return result;
        }

        public Victor Resta(Victor other)
        {
         var result = new Victor(x - other.x, y - other.y);
            
            return result;


        }
        public Victor Multi(float num)
        {
            Victor result = new Victor(x * num, y * num);
            return result;
        }

        public float Magni()
        {
            float result = Mathf.Sqrt((x * x) + (y * y));
            return result;
        }

        public Victor normalice()
        {
            float magnitud = Mathf.Sqrt((x * x) + (y * y));
            Victor result = new Victor(x / magnitud, y / magnitud);
            return result;
        }

        public Victor lerp(Victor victor, float scale)
        {
            return new Victor((x * (1 - scale) + (victor.x * scale)), (y * (1 - scale) + (victor.y * scale)));
        }
        public void Draw(Victor origin = null)
        {
            if (origin == null)
            {
                Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y));
                return;
            }
            Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x + origin.x, y + origin.y));
        }

    public static Victor operator +(Victor a, Victor b)
    {
        return new Victor(a.x + b.x, a.y + b.y);
    }
    public static Victor operator -(Victor a, Victor b)
    {
        return new Victor(a.x - b.x, a.y - b.y);
    }
    public static Victor operator *(Victor a, float scalar)
    {
        return new Victor(a.x *scalar, a.y *scalar);
    }
    public static Victor operator /(Victor a, float scalar)
    {
        return new Victor(a.x / scalar, a.y / scalar);
    }
}

 