﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonActivation : MonoBehaviour
{
   public void StartGameMenu()
    {
        SceneManager.LoadScene(1);
    }
}