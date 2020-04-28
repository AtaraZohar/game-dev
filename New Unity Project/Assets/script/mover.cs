using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class mover : MonoBehaviour
{
    [Tooltip ("the speed of the object per second")] [SerializeField] float speed;
    [Tooltip("where the point will first be in the x axia")] [SerializeField] float centerX;
    [Tooltip("where the point will first be in the y axia")] [SerializeField] float centerY;
    [Tooltip("where the point will first be in the y axia")] [SerializeField] float range;
    bool flag = true;
    bool first = true;
    float a = 0.01f;
    //float s = 0.13f;
    bool second = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting");
        Transform t = GetComponent<Transform>();
        t.position = new Vector3(centerX, centerY, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= centerX && transform.position.x <= ((range/2) + centerX) && first) //the first time
        {
            speed += a;
        }

        if (transform.position.x >= ((range / 2) + centerX) && transform.position.x <= (range + centerX) && first) //the first time
        {
            speed -= a;
            first = false;
        }

        if (transform.position.x <= (range + centerX) && transform.position.x >= centerX && !first)
        {
            if (second){
                speed += a;
            }
            else
            {
                speed -= a;
            }
        }

        if (transform.position.x >= (centerX*-1) && transform.position.x <= centerX && !first)
        {
            if (second)
            {
                speed -= a;
            }
            else
            {
                speed += a;
            }

        }

        if (transform.position.x <= (centerX * -1) && !first)
        {
            second = false;
        }

        if (transform.position.x >= (range + centerX) && !first)
        {
            second = true;
        }

        if (transform.position.x < (range + centerX) && flag )
        {
            transform.position = new Vector3(
                transform.position.x + (speed * Time.deltaTime),
                transform.position.y,
                transform.position.z);
        }

        else if (transform.position.x >= (range + centerX) && flag)
        {
            flag = false;
            transform.position = new Vector3(
                transform.position.x - (speed * Time.deltaTime),
                transform.position.y,
                transform.position.z);
        }

        else if (transform.position.x > ((range + centerX)*-1) && !flag)
        {
            flag = false;
            transform.position = new Vector3(
                transform.position.x - (speed * Time.deltaTime),
                transform.position.y ,
                transform.position.z);
        }

        else if (transform.position.x <= ((range + centerX) * -1) && !flag)
        {
            flag = true;
            transform.position = new Vector3(
                transform.position.x + (speed * Time.deltaTime),
                transform.position.y ,
                transform.position.z);
        }
        Debug.Log("updating");

    }
}
