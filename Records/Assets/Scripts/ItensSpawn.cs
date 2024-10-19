using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItensSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] ItensPrefabs;
    [SerializeField] float secondSpawn;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
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
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
