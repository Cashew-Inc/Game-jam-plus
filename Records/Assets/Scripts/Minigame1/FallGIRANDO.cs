using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGIRANDO : MonoBehaviour
{
    public float fallSpeed = 5f;   // Velocidade de queda
    public float rotationSpeed = 100f; // Velocidade de rotação

    void Update()
    {

        // Rotacionar o objeto em torno de seu próprio eixo
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
