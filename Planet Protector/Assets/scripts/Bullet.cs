using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject explosionSprite;  
     void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Metriod")
        {
            Destroy(gameObject);
            GameObject explosionEffect = Instantiate(explosionSprite, transform.position , Quaternion.identity  );
            Destroy(explosionEffect  , 1f );
        }
        if (collision.gameObject.tag == "planet")
        {
            Destroy(gameObject);
            GameObject explosionEffect = Instantiate(explosionSprite, transform.position, Quaternion.identity);
            Destroy(explosionEffect, 1f);

        }

        
       
    }
    private void Update()
    {

        Destroy(gameObject, 3f); 
    
    }

    
}
