﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSalir : MonoBehaviour
{
    public void SalirJuego()
    {
        Application.Quit();
        Debug.Log("Se ha cerrado el juego");
    }
}