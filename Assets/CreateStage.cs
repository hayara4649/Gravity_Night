﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStage : MonoBehaviour
{
    Vector3 vector;
    public GameObject stage;
    // Start is called before the first frame update
    void Start()
    {
        vector=this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Create(){
        Instantiate(stage, vector, Quaternion.identity);
    }
}
