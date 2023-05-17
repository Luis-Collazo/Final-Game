using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject topobstacle;
    public GameObject bottomobstacle;
    public GameObject topobstacle2;
    public GameObject bottomobstacle2;
    public GameObject topobstacle3;
    public GameObject bottomobstacle3;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    private Vector3 spawnPos1 = new Vector3(16,17,-4);
    private Vector3 spawnPos2 = new Vector3(16,-7,-4);
    private Vector3 spawnPos3 = new Vector3(13,11,-5);
    private Vector3 spawnPos4 = new Vector3(13,6,-5);
    private Vector3 spawnPos5 = new Vector3(13,1,-5);
    private Vector3 spawnPos6 = new Vector3(31,22,-4);
    private Vector3 spawnPos7 = new Vector3(31,-3,-4);
    private Vector3 spawnPos8 = new Vector3(44,14,-4);
    private Vector3 spawnPos9 = new Vector3(44,-10,-4);
    private float startDelay = 2;
    private float repeatRate = 3;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
       InvokeRepeating("SpawnEnemy", startDelay, repeatRate);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        Instantiate(topobstacle, spawnPos1, topobstacle.transform.rotation);
        Instantiate(bottomobstacle, spawnPos2, bottomobstacle.transform.rotation);
        Instantiate(topobstacle2, spawnPos6, topobstacle.transform.rotation);
        Instantiate(bottomobstacle2, spawnPos7, bottomobstacle.transform.rotation);
        Instantiate(topobstacle3, spawnPos8, topobstacle.transform.rotation);
        Instantiate(bottomobstacle3, spawnPos9, bottomobstacle.transform.rotation);
    }

    void SpawnEnemy ()
    {
        Instantiate(enemy1, spawnPos3, enemy1.transform.rotation);
        Instantiate(enemy2, spawnPos4, enemy2.transform.rotation);
        Instantiate(enemy3, spawnPos5, enemy3.transform.rotation);
    }


}
