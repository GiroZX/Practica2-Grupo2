using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerModel model;
    public PlayerController controller;

    private void FixedUpdate()
    {
        transform.position = model.position;
    }
}