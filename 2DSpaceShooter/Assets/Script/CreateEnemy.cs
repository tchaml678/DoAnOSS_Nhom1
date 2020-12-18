using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefabs;
    [SerializeField] float delayTime = 10f;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Create();
    }

    void Create()
    {
        
        var enemyPos = transform.position;
        enemyPos.y += 0.5f;
        counter += Time.deltaTime*Random.Range(0.1f,0.5f);
        if (counter >= delayTime)
        {
            Instantiate(enemyPrefabs, enemyPos, transform.rotation);
            counter = 0;
        }
    }
}

