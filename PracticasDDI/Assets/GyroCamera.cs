using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamera : MonoBehaviour {
    public Gyroscope gyro;
    public bool gyroSupported;
	// Use this for initialization
	void Start () {
        gyroSupported = SystemInfo.supportsGyroscope;
        if (gyroSupported)
        {
        gyro = Input.gyro;
        gyro.enabled = true;
        }
         
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation=gyro.attitude;
	}
}
