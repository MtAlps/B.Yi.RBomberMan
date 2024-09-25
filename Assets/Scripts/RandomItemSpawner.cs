using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] spawnableItems;

    private void Start()
    {
        StartCoroutine(PowerupSpawn());

    }

    IEnumerator PowerupSpawn()
    {
        while (true) { 
            if(spawnableItems.Length > 0)
            {
                int randIndex = Random.Range(0, spawnableItems.Length);
                Instantiate(spawnableItems[randIndex], transform.position, Quaternion.identity);
                yield return new WaitForSeconds(10.0f);
            }           
        }
    }
}
