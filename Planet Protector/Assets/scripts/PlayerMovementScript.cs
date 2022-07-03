using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private CapsuleCollider2D capCollider;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float turnSpeed;
    
    private float moveHorizontal;
    private float moveVertical;
    [SerializeField]private float bulletSpeed;
    public Transform bulletPoint;
    public GameObject bulletPrefab ;

    public GameObject muzzleFlash ;
    Vector2 mousePos;
    public Camera cam; 
    // Start is called before the first frame update

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        capCollider = GetComponent<CapsuleCollider2D>();
    }
    void Start()
    {


        //rb2D = GetComponent<Rigidbody2D>();
       // movementSpeed = 3f;
       // jumpForce = 30f;
        


    }

    // Update is called once per frame
    void Update()
    {

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 
        moveHorizontal = Input.GetAxisRaw("Horizontal"); 
        moveVertical = Input.GetAxisRaw("Vertical");
        if (Input.GetMouseButtonDown(0))
        {
            GameObject muzzle = Instantiate(muzzleFlash, bulletPoint.position , Quaternion.identity);
            shoot();
            AudioManager.soundsInstance.PlaySFX(1); 
            rb2D.AddRelativeForce(new Vector2(0f, -1f), ForceMode2D.Impulse);
            Destroy(muzzle , .5f ); 


        }
    }

    void FixedUpdate()
    {

        Vector2 lookDirection = mousePos - rb2D.position;

        float angle = Mathf.Atan2(lookDirection.y , lookDirection.x ) * Mathf.Rad2Deg - 90f  ; 

        if (moveVertical > 0.1f)
        {
            rb2D.AddRelativeForce(new Vector2(0f, moveVertical * movementSpeed), ForceMode2D.Impulse);
        }
        /*if (moveHorizontal < 0.1f || moveHorizontal > 0.1f  )
        {
            transform.Rotate(Vector3.forward*moveHorizontal*turnSpeed); 
        }*/
        rb2D.rotation = angle; 
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab , bulletPoint.position , bulletPoint.rotation );
        Rigidbody2D rbBullet = bullet.GetComponent<Rigidbody2D>();
        rbBullet.AddForce(bulletPoint.up*bulletSpeed , ForceMode2D.Impulse);

    }

}
