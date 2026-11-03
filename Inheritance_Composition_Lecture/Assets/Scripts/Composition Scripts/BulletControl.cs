using UnityEngine;

//[RequireComponent (typeof(FireUp))]
public class BulletControl : MonoBehaviour
{
   

    Rigidbody2D rb;
    FireUp gunfire;
    Projectile myprojectile;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        gunfire = GetComponent<FireUp>();
        myprojectile = GetComponent<Projectile>();
       // gunfire.YForce = 200f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (gunfire != null) gunfire.Fire(rb);
            if (myprojectile != null) myprojectile.FireProjectile(rb);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
