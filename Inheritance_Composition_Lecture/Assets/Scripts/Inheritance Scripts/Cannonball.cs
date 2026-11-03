using UnityEngine;

public class Cannonball : DefaultBullet
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        rb.gravityScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
