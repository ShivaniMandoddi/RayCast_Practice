using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawingEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    float time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time;
        if(time>6f)
        {
            Vector3 position = new Vector3(Random.Range(-45f, 45f), Random.Range(0.5f, 6f), Random.Range(-45f, 45f));
            Instantiate(enemyPrefab, position, Quaternion.identity);
            time = 0f;
        }
    }
}
