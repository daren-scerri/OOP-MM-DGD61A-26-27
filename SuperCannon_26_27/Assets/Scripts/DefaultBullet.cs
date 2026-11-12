using UnityEngine;

public class DefaultBullet : MonoBehaviour
{

    protected Rigidbody2D rb;
    [SerializeField] float speed;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        rb.linearVelocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
