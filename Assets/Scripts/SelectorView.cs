using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorView : MonoBehaviour
{
    public SelectorModel model;
    private void Update()
    {
        ButtonSelector();
    }
    public void ButtonSelector()
    {
        switch (model.counter)
        {
            case 0:
                model.Arquero.color = Color.red;
                model.Mago.color = Color.black;
                model.Caballero.color = Color.black;
                model.Sacerdote.color = Color.black;
                break;
            case 1:
                model.Arquero.color = Color.black;
                model.Mago.color = Color.red;
                model.Caballero.color = Color.black;
                model.Sacerdote.color = Color.black;
                break;

            case 2:
                model.Arquero.color = Color.black;
                model.Mago.color = Color.black;
                model.Caballero.color = Color.red;
                model.Sacerdote.color = Color.black;
                break;

            case 3:
                model.Arquero.color = Color.black;
                model.Mago.color = Color.black;
                model.Caballero.color = Color.black;
                model.Sacerdote.color = Color.red;
                break;

            default:
                break;
        }
    }
}
