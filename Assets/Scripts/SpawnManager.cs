using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject topobstacle;
    public GameObject bottomobstacle;
    private Vector3 spawnPos1 = new Vector3(16,17,-4);
    private Vector3 spawnPos2 = new Vector3(16,-7,-4);
    private float startDelay = 2;
    private float repeatRate = 3;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        Instantiate(topobstacle, spawnPos1, topobstacle.transform.rotation);
        Instantiate(bottomobstacle, spawnPos2, bottomobstacle.transform.rotation);
    }


}
