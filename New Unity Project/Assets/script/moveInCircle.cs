using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveInCircle : MonoBehaviour
{

        private float RotateSpeed = 5f;
        private float Radius = 0.81f;

        private Vector2 _centre;
        private float _angle;

        private void Start()
        {
            _centre = transform.position;
        }

        private void Update()
        {

            if (Input.GetKey(KeyCode.RightArrow)) { 
            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            transform.position = _centre + offset;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _angle -= RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            transform.position = _centre + offset;
        }
    }



    }
