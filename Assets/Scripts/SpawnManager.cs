using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
        //InvokeRepeating(nameof (RandomSpawn), 0, 5f);
        //StartCoroutine(Goodbuy());
        //StartCoroutine(Hello());
    }

    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(3);
        }
    }

    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawnPoint = spawnPoints[index];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }
    
    IEnumerator Goodbuy()
    {
        while (true)
        {
            Debug.Log("Bye " + Time.frameCount + " " + Time.time);
            //yield return new WaitForSeconds(1);
            yield return null;

            if (Time.time > 5)
            {
                yield break;
            }
            yield return Hello();
        }
    }

    IEnumerator Hello()
    {
        Debug.Log("Hello " + Time.frameCount);
        Debug.Log("Hello " + Time.frameCount);
        Debug.Log("Hello " + Time.frameCount);
        yield return null;
    }
}
