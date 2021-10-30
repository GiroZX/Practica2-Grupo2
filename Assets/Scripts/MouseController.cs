using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseController : MonoBehaviour
{

    public MouseModel model;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (model.EventSystem.current.currentSelectedGameObject == null)
        {
            if (model.lastSelected.gameObject.activeSelf && model.lastSelected.GetComponent<Button>() != null && model.lastSelected.GetComponent<Button>().interactable)
            {
                EventSystem.current.SetSelectedGameObject(model.lastSelected);
            }
        }
        else
        {
            model.lastSelected = EventSystem.current.currentSelectedGameObject;
        }
    }
}
