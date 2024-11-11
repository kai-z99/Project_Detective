using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldClock : MonoBehaviour, InteractableObject
{
    public GameObject polaroid;
    public GameObject inventoryMenu;
    public Dialogue dialogue;
    public void Interact()
    {
        Debug.Log("My name is " + transform.name);
        Instantiate(polaroid, new Vector2(0, 0), Quaternion.identity, inventoryMenu.transform);

        // Start the dialogue
        if (dialogue != null)
        {
            dialogue.gameObject.SetActive(true); // Make sure the dialogue GameObject is active
            dialogue.StartDialogue(); // Start the dialogue sequence
        }
    }
}
