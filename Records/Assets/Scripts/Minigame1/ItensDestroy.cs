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
        }
        else if (collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
        }
    }

}
