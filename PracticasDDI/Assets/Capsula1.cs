using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula1 : MonoBehaviour {

	// Use this for initialization
    void OnCollisionEnter (Collision col)
    {
    if(col.gameObject.name == "Capsula")
        {
            Destroy(col.gameObject);
        }
    }
}
