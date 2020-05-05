using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2DSpyShip : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    int score = 2;
    int points = 3;
    [SerializeField] NumberField scoreField;
    Text textpoints;

    private void OnTriggerEnter2D(Collider2D other)
    {

        textpoints = GameObject.Find("Canvas/Text").GetComponent<Text>();
        textpoints.text = points.ToString();

        if (((scoreField.GetNumber() % 20) == 0)&& scoreField.GetNumber()!=0)
           {
                 score++;
                 points++;
                textpoints.text = points.ToString();
          }

        if (other.tag == triggeringTag && enabled && score == 0)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            textpoints.text = "game over :(";
        }
        if (other.tag == triggeringTag && enabled && score > 0)
        {
            score--;
            points--;
            textpoints.text = points.ToString();
        }
    }
}
