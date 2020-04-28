using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickMoverWhite : MonoBehaviour
{
    [Tooltip("the speed of the object per second")] [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {

        Transform t = GetComponent<Transform>();
        t.position = new Vector3(-4.89f, 3.29f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(
            transform.position.x + (speed * Time.deltaTime),
            transform.position.y,
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(
            transform.position.x - (speed * Time.deltaTime),
            transform.position.y,
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y + (speed * Time.deltaTime),
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(
            transform.position.x,
            transform.position.y - (speed * Time.deltaTime),
            transform.position.z);
        }


    }
}
