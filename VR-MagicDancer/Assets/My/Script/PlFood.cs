﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlFood : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.up, target.transform.position-transform.position);
    }
}