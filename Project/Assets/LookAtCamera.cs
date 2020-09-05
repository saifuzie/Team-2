﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    public Transform camera;
    private Transform healthBar;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.localPosition + camera.forward);
        
    }
}
