using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorController : MonoBehaviour
{
    public SelectorModel model;

    // Start is called before the first frame update
    void Start()
    {
        model.counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ButtonSelect();
    }

    public void ButtonSelect()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            model.counter += 1;
            if (model.counter == 4)
            {
                model.counter = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            model.counter -= 1;
            if (model.counter == -1)
            {
                model.counter = 3;
            }
        }
        switch (model.counter)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Debug.Log("Arquero");
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Debug.Log("Mago");
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Debug.Log("Caballero");
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Debug.Log("Sacerdote");
                }
                break;

            default:
                break;
        }
    }

}
