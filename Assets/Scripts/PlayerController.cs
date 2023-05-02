using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
 {
          Vector3 movement = new Vector3 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
     
          transform.position += movement * Time.deltaTime * speed;

          if (Input.GetKeyDown(KeyCode.Space))
          {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
          }
 }

 
}

