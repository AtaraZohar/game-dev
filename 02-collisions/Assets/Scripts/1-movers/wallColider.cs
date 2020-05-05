using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallColider : MonoBehaviour
{

    [Tooltip("The number of seconds that the shield remains active")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Debug.Log("blaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            // Vector3 movementVector = new Vector3(0, 0, 0) * 0 * Time.deltaTime; 
            // transform.position = movementVector;

        }
    }
}


