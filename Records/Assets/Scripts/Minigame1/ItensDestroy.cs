using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensDestroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidiu com o que deseja, por exemplo, "Player" ou "Ground"
        if (collision.gameObject.tag == "player")
        {
            PlayerMini1 player = collision.gameObject.GetComponent<PlayerMini1>();
            if (player != null)
            {
                player.IncrementItemCount();
            }
            // Destroi o item após a colisão
            Destroy(gameObject);
        } else if (collision.gameObject.CompareTag("ground"))
        {
            // Encontra o script PlayerLives no GameObject do jogador
            GameObject player = GameObject.FindWithTag("player");
            if (player != null)
            {
                Player1Lives playerLives = player.GetComponent<Player1Lives>();
                if (playerLives != null)
                {
                    playerLives.DecreaseLife(); // Chama o método para diminuir a vida
                }
            }

            Destroy(gameObject); // Destroi o item após a colisão
        }
    }

}
