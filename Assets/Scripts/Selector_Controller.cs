using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector_Controller : MonoBehaviour
{
    //  By Anthony_Abarca
    public Selector_Model model;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Button_Selected();
    }

    void Button_Selected()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            model.audiosource.PlayOneShot(model.button_change, 1);
        }

        if ((Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space)))
        {
            model.audiosource.PlayOneShot(model.selected_sfx2, 1);
        }

    }
}
