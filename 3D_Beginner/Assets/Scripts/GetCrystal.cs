﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCrystal : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
