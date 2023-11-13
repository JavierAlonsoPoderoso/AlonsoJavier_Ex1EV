using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Menuui : MonoBehaviour
{
    public TMP_Text intentosText;
    public TMP_Text puntosText;
    public Transform bola;

    private int intentos = 0;
    private int puntos = 0;

    void Start()
    {
        ActualizarUI();
    }

    void ActualizarUI()
    {
        intentosText.text = "Intentos: " + intentos.ToString();
        puntosText.text = "Puntos: " + puntos.ToString();
    }

    public void IncrementarIntentos()
    {
        intentos++;
        ActualizarUI();
    }

    public void IncrementarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI();
    }

    
    void Update()
    {
        // Detectar si la pelota está en el suelo
        if (gameObject.CompareTag("grande"))
        {
            IncrementarPuntos(1);
        }
        else if (gameObject.CompareTag("medio"))
        {
            IncrementarPuntos(2);
        }
        else if (gameObject.CompareTag("pequeño"))
        {
            IncrementarPuntos(3);
        }
    }
}
