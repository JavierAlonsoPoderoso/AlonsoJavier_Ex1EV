using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{
    public float velocidad = 5f; // Ajusta la velocidad según tus necesidades
    public Transform bola; // Referencia al objeto de la pelota
    public float factorDeFuerza = 5f; // Ajusta el factor de fuerza según tus necesidades

    void Update()
    {
        // Obtener la entrada vertical del joystick izquierdo
        float inputVertical = Input.GetAxis("izquierdo");

        // Mover la barra en función de la entrada vertical
        transform.Translate(Vector3.right * inputVertical * velocidad * Time.deltaTime);

        // Obtener la posición vertical de la barra
        float posicionVerticalBarra = transform.position.y;

        // Calcular la fuerza en función de la posición de la barra
        float fuerza = posicionVerticalBarra * factorDeFuerza;

        // Aplicar el empujón cuando se presiona el botón "A" del mando
        if (Input.GetButtonDown("empujar"))
        {
            // Aplicar una fuerza en la dirección hacia adelante de la pelota
            bola.GetComponent<Rigidbody>().AddForce(bola.transform.forward * fuerza, ForceMode.Impulse);
        }
    }
}
