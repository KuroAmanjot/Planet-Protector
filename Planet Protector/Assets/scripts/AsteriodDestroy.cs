using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodDestroy : MonoBehaviour
{
     
     
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
            Score.scoreTotal += 5;
            AudioManager.soundsInstance.PlaySFX(2);
        }
        if (collision.gameObject.tag == " player")
        {
            Destroy(gameObject);
            GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effectExplode, 1f);
            AudioManager.soundsInstance.PlaySFX(2);
        }

        if (collision.gameObject.tag == "planet")
        {

            Destroy(gameObject);
            GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(effectExplode, 1f);
            AudioManager.soundsInstance.PlaySFX(2);

        }

    }
}
