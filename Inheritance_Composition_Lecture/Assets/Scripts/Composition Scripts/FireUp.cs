using UnityEngine;

public class FireUp : MonoBehaviour
{
    [SerializeField] float YForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Fire(Rigidbody2D rb)
    {
        Vector2 myforce = new Vector2(0, YForce);
        rb.AddForce(myforce);
    }
}
