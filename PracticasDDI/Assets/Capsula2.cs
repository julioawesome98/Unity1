﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula2 : MonoBehaviour
{

    // Use this for initialization
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Capsula1")
        {
            Destroy(col.gameObject);
        }
    }
}
