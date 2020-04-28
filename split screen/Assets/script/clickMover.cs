using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMover : MonoBehaviour
{
    [Tooltip("the speed of the object per second")] [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

        Transform t = GetComponent<Transform>();
        t.position = new Vector3(-3.78f, 3.3f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(
            transform.position.x + (speed * Time.deltaTime),
            transform.position.y,
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(
            transform.position.x - (speed * Time.deltaTime),
            transform.position.y,
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y + (speed * Time.deltaTime),
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(
            transform.position.x ,
            transform.position.y - (speed * Time.deltaTime),
            transform.position.z);
        }


    }
}
