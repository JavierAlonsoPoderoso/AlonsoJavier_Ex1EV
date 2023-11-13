using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 5f; // Ajusta la velocidad seg�n tus necesidades
    public Transform bola; // Referencia al objeto de la pelota
    public float factorDeFuerza = 5f; // Ajusta el factor de fuerza seg�n tus necesidades

    void Update()
    {
        // Obtener la entrada vertical del joystick izquierdo
        float inputVertical = Input.GetAxis("izquierdo");

        // Mover la barra en funci�n de la entrada vertical
        transform.Translate(Vector3.right * inputVertical * velocidad * Time.deltaTime);

        // Obtener la posici�n vertical de la barra
        float posicionVerticalBarra = transform.position.y;

        // Calcular la fuerza en funci�n de la posici�n de la barra
        float fuerza = posicionVerticalBarra * factorDeFuerza;

        // Aplicar el empuj�n cuando se presiona el bot�n "A" del mando
        if (Input.GetButtonDown("empujar"))
        {
            // Aplicar una fuerza en la direcci�n hacia adelante de la pelota
            bola.GetComponent<Rigidbody>().AddForce(bola.transform.forward * fuerza, ForceMode.Impulse);
        }
    }
}
