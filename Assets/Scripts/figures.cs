﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class figures : MonoBehaviour
{

    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
