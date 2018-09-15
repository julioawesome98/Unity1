using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour 
{
    public Color color;
    public GameObject infoPanel;
    public GameObject audio;
    private bool isPlayerInside = false;
    public float rotationSpeed = 3f;

    private void Start()
    {
        infoPanel.SetActive(false);
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        if(Input.GetKeyDown(KeyCode.I) && isPlayerInside)
        {
            gameObject.GetComponent<Renderer>().material.color = color;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            audio.SetActive(true);
            infoPanel.SetActive(true);
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio.SetActive(false);
            infoPanel.SetActive(false);
            isPlayerInside = false;
        }
    }
}
