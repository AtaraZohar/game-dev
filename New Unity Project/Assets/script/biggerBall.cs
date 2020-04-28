using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;


public class biggerBall : MonoBehaviour
{
    Vector3 temp; 
    bool flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;

        if (temp.x <= 5 && flag)
        {
            
            temp.x += Time.deltaTime;
            temp.y += Time.deltaTime;
        }

        if (temp.x >= 5)
        {
         //   UnityEngine.Debug.Log("1111");
            flag = false;
        }

         if ((temp.x >= 5 || temp.x >= 1) && !flag)
        {
           // UnityEngine.Debug.Log("updating");
           
            temp.x -= Time.deltaTime;
            temp.y -= Time.deltaTime;
        }

        if (temp.x <= 1)
        {
            flag = true;
        }
        transform.localScale = temp;
    }
}
