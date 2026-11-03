using UnityEngine;

public class DefaultBullet : MonoBehaviour
{
    [SerializeField] float xforce, yforce;
    protected Rigidbody2D rb;
    [SerializeField] protected int hitpoints;

    protected virtual void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        Vector2 myforce = new Vector2(xforce, yforce);
        rb.AddForce(myforce);
    }

    // Update is called once per frame
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
