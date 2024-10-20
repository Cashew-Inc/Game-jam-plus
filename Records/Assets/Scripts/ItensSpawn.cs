using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] ItensPrefabs;
    [SerializeField] float secondSpawn;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    [SerializeField] float initialSpawnTime = 1f; // Tempo inicial de spawn
    [SerializeField] float spawnIncreaseRate = 0.1f; // Quanto o intervalo aumenta a cada spawn
    [SerializeField] float maxSpawnTime = 5f;
    

    [SerializeField] float initialItemSpeed = 1f; // Velocidade inicial dos itens
    [SerializeField] float speedIncreaseRate = 0.1f; // Quanto a velocidade aumenta a cada spawn
    [SerializeField] float maxItemSpeed = 5f;

    private float currentSpawnTime;
    private float currentItemSpeed;

    void Start()
    {
        currentSpawnTime = initialSpawnTime; // Define o tempo de spawn inicial
        currentItemSpeed = initialItemSpeed;// Define o tempo de spawn inicial
        StartCoroutine(ItemSpawn());
    }


    IEnumerator ItemSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ItensPrefabs[Random.Range(0, ItensPrefabs.Length)],
            position, Quaternion.identity);

            Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.velocity = new Vector2(0, -currentItemSpeed); // Aplica a velocidade negativa para descer
            }
            yield return new WaitForSeconds(secondSpawn);
            currentSpawnTime = Mathf.Min(currentSpawnTime + spawnIncreaseRate, maxSpawnTime);
            currentItemSpeed = Mathf.Min(currentItemSpeed + speedIncreaseRate, maxItemSpeed);
        }
    }
}
