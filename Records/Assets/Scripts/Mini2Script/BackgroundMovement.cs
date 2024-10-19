using UnityEngine;

public class TilemapMovement : MonoBehaviour
{
    public Transform player; // Refer�ncia ao jogador
    public float speed = 5f; // Velocidade do movimento do Tilemap

    void Update()
    {
        // Movimentar o Tilemap para cima com base na posi��o do jogador
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

        // Atualizar a posi��o do Tilemap
        transform.position = newPosition;
    }
}