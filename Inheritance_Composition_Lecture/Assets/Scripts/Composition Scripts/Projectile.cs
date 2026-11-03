using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] float XForce;
   
    public void FireProjectile(Rigidbody2D rb)
    {
        rb.gravityScale = 1.0f;
        Vector2 myforce = new Vector2(XForce, 0f);
        rb.AddForce(myforce);
    }
}
