using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace healthRef
{

public class HealthSystem : MonoBehaviour
{

    //public Image heartUI;
    public Sprite deadHeartSprite;
    public Sprite aliveHeartSprite;
    public Image[] hearts;
    public int lifelines;
    public int heartContainer;    
    private bool isAlive = true;
        // Start is called before the first frame update
        public isAliveHealth playerHealth ; 
        

        // Update is called once per frame
        void Update()
          {

            if (lifelines > heartContainer )
            {
                lifelines = heartContainer;
            }

            for (int i = 0; i < hearts.Length; i++)
            {
                if (i< lifelines)
                {
                    hearts[i].sprite = aliveHeartSprite;
                }
                else
                {
                    hearts[i].sprite = deadHeartSprite; 
                }
                if (i< heartContainer )
                {
                    hearts[i].enabled = true;

                }
                else
                {
                    hearts[i].enabled = false;
                }




            }


        if (isAlive == false )
        {
                // dead script 
            playerHealth.retryMenu.SetActive(true); 
            Destroy(gameObject); 
            
            print("planet died"); 
        }
        
    }

    public  void  DamageSystem(int dmg)
    {
        lifelines -= dmg;
        //Destroy(hearts[lifelines].gameObject);
            
        
        if (lifelines < 1)
        {
            isAlive = false; 

        }
    }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            DamageSystem(1);   
        }
    }

}