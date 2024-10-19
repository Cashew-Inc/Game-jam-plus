using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFall : MonoBehaviour
{
    public float fallSpeed = 2f; // Velocidade da queda

    void Update()
    {
        // Mover o item para baixo a cada frame
        transform.position += new Vector3(0, -fallSpeed * Time.deltaTime, 0);
    }
}
