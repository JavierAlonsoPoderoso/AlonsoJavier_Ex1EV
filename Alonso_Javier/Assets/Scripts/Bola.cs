using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public float fuerzaInicial = 0.02f;
    public float factorDeFuerza = 0.02f;

    private Rigidbody rb;
    private bool estaEnElSuelo = true;
    public Transform barra;

    [SerializeField] GameObject bola;
    public string nombreEjeVertical = "Vertical";
    private float tiempoEspera = 5f; 
    private float tiempoRestante;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tiempoRestante = tiempoEspera;
    }

    // Update is called once per frame
    void Update()
    {
        if (estaEnElSuelo)
        {
            float posicionVertical = Input.GetAxis("izquierdo");
            float fuerza = posicionVertical * factorDeFuerza;

            // Limitar la fuerza mínima
            fuerza = Mathf.Max(fuerza, fuerzaInicial);

            // Limitar la fuerza máxima (opcional)
            fuerza = Mathf.Min(fuerza, 0.2f);

            // Aplicar el empujón cuando se presiona el botón "A" del mando
            if (Input.GetButton("empujar"))
            {
                empujon(fuerza);
            }
        }
        tiempoRestante -= Time.deltaTime;

        // Verifica si es el momento de reiniciar
        if (tiempoRestante <= 0f)
        {
            // Reinicia el nivel
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            // Reinicia el temporizador
            tiempoRestante = tiempoEspera;
        }
    }

    void empujon(float fuerza)
    {

        rb.AddForce(transform.forward * fuerza, ForceMode.Impulse);

    }


    void OnCollisionEnter(Collision collision)
    {
        // Detectar si la pelota está en el suelo
        if (collision.gameObject.CompareTag("P inicial"))
        {
            estaEnElSuelo = true;
        }
        
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        tiempoRestante = tiempoEspera;
    }

}
