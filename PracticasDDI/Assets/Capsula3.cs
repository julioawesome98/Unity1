using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula3 : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject efecto;

    // Use this for initialization
    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Instantiate(efecto,objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
        }
    }
}
