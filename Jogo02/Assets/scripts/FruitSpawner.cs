using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject [] fruitsPrefab;
    [SerializeField] private Transform[] spwanPoints;
    [SerializeField] private float minDelay,maxDelay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn(){
        while(true){
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0,spwanPoints.Length);
            Transform spawnPoint = spwanPoints[spawnIndex];
            GameObject fruitPrefab = Instantiate(fruitsPrefab[Random.Range(0, fruitsPrefab.Length)], spawnPoint.position, spawnPoint.rotation);
            Destroy(fruitPrefab, 5f);

        }
    }
   
}
