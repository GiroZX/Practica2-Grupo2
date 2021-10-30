using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FIX_MOUSE : MonoBehaviour
{

    GameObject lastSelected;

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (lastSelected.gameObject.activeSelf && lastSelected.GetComponent<Button>() != null && lastSelected.GetComponent<Button>().interactable)
            {
                EventSystem.current.SetSelectedGameObject(lastSelected);
            }
        }
        else
        {
            lastSelected = EventSystem.current.currentSelectedGameObject;
        }
    }
    
}
