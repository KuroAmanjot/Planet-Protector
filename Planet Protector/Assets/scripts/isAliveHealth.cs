using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isAliveHealth : MonoBehaviour
{
    public GameObject explosion; 
    public bool isAlive = true ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isAlive == false )
        {


        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        isAlive = false;
        GameObject effectExplode = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(effectExplode, 1f);

    }
}
