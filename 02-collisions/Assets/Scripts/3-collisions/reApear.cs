using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reApear : MonoBehaviour
{
    float Radius;

    void Start()
    {
        Radius = GetComponent<CircleCollider2D>().radius;
    }
    void OnBecameInvisible()
    {
        // Make the ship wrap
        Vector3 position = transform.position;
        if (position.x - Radius >= Screen.width || position.x + Radius <= Screen.width)
        {
            position.x *= -1;

        }
        if (position.y - Radius >= Screen.height || position.y + Radius <= Screen.height)
        {
            position.y *= -1;
        }
        transform.position = position;
    }
}
