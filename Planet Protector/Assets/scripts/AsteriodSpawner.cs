using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    //private int waveNumber = 0;
   // public int enemiesAmount = 0;
   // public GameObject zombie;
    public Camera cam;
    private bool startSpawning = true ;
    public GameObject[] asteriodPrefabs ;

    private float spawnTimer = 2f;
    private float delayTimer = 5f ; 
    // Use this for initialization
    void Start()
    {
        
       // startSpawning = true ;
        cam = Camera.main;
        //enemiesAmount = 0;
        InvokeRepeating("Spawning", spawnTimer ,delayTimer ); 
        
    }

  
    void Update()
    {
        /*float height = cam.orthographicSize + 1f;  // now they spawn just outside
        float width = cam.orthographicSize * cam.aspect + 1;

        if (enemiesAmount == 0)
         {
             waveNumber++;
             for (int i = 0; i < waveNumber; i++)
             {
                 Instantiate(zombie, new Vector3(cam.transform.position.x + Random.Range(-width, width), 3, cam.transform.position.z + height + Random.Range(10, 30)), Quaternion.identity);
                 enemiesAmount++;
             }
         }*/
        
        
       

        
    }

    private void Spawning()
    {
        float height = cam.orthographicSize + 1f;  // now they spawn just outside
        float width = cam.orthographicSize * cam.aspect + 1;
        int index = Random.Range(0, asteriodPrefabs.Length);



        Instantiate(asteriodPrefabs[index], new Vector3(cam.transform.position.x + Random.Range(-width, width), 3, cam.transform.position.z + height + Random.Range(10, 30)), Quaternion.identity);
        if ( !startSpawning )
        {
            CancelInvoke("Spawning"); 
            // 
        }
    }
}
