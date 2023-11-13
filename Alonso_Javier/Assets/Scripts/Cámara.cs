using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cámara : MonoBehaviour
{
    [SerializeField] Transform bolaTransform;
    [SerializeField] float offsetY = 7f;
    [SerializeField] float offsetZ = 14f;

    //public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(bolaTransform.position);
        transform.position = bolaTransform.position + new Vector3(0f, offsetY, -offsetZ);

        Vector3 targetPosition = bolaTransform.position + new Vector3(0f, offsetY, -offsetZ);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

    }
}
