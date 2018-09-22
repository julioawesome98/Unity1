﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    // Use this for initialization

    //Sprite InventoriSprite
    private bool isPlayerInside = false;

    public GameObject interactivePanel;
    public GameObject infoPanel;


    public void Start()
    {
        infoPanel.SetActive(false);
        interactivePanel.SetActive(false);
    }
    public void Update()
    {

        transform.Rotate(Vector3.up * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.N) && isPlayerInside)
        {
            FindObjectOfType<inventory>().addNewItem();//(invetorySprite)
            Destroy(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.I) && isPlayerInside)
        {
            interactivePanel.SetActive(true);
            isPlayerInside = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
            isPlayerInside = true;
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            infoPanel.SetActive(false);
            isPlayerInside = false;
        }
    }
}