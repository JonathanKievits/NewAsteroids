using UnityEngine;
using System.Collections;

public class BoatSpawner : MonoBehaviour { 

    public GameObject Enemy;

    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(13f);
        }
    }
}

