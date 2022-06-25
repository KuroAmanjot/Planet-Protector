using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodDestroy : MonoBehaviour
{

    public isAliveHealth health;  
    public GameObject explosion ;
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            GameObject effectExplode = Instantiate(explosion , transform.position, Quaternion.identity);
            Destroy(effectExplode, 1f ); 

        }
        if (collision.gameObject.tag == " player")
        {
            Destroy(gameObject);
            GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effectExplode, 1f);
        }

        if (collision.gameObject.tag == "planet")
        {

            Destroy(gameObject);
            GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effectExplode, 1f);

        }

    }
}
