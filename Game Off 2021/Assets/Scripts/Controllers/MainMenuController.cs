using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void Play()
    {

        GameManager.instance.Load("Game");

    }
}
