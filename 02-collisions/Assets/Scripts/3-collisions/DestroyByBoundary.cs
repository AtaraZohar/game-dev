using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
     
    bool seen = false;

        void Update()
    {
        if (GetComponent<Renderer>().isVisible)
            seen = true;

        if (seen && !GetComponent<Renderer>().isVisible)
            Destroy(gameObject);
    }
    
}
