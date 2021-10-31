using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public PlayerModel model;

    private void Update()
    {
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            ButtonSelect();
        }
    }
    void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            model.position += new Vector3(0, 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            model.position += new Vector3(0, -2, 0);
        }
    }
    void ButtonSelect()
    {
        if (model.position == new Vector3(-8, 3.3f, 0))
        {
            SceneManager.LoadScene("CharacterSelect");
        }
        else
        {
            Debug.Log("Boton presionado, pero aqui no hay nada!");
        }
    }
}
