using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    Text textpoints;

    private void OnTriggerEnter2D(Collider2D other) {

        textpoints = GameObject.Find("Canvas/Text").GetComponent<Text>();
   

        if (other.tag == triggeringTag && enabled) {
            Destroy(this.gameObject);
            //Destroy(other.gameObject);
            textpoints.text = "game over :(";
        }
    }
}
