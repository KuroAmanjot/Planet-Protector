using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAliveHealth : MonoBehaviour
{
    public GameObject explosion; 
    public bool isAlive = true ;

    public GameObject retryMenu; 


    
    
    void Update()
    {

        /*if (isAlive == false)
        {

            retryMenu.SetActive(true); 

        }*/
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        retryMenu.SetActive(true);
        Destroy(gameObject);
        isAlive = false;
        GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(effectExplode, 1f);

    }
}
