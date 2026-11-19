using UnityEngine;

public class Missile : DefaultBullet
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void OnEnable()
    {
        rb.gravityScale = 0f;
        base.OnEnable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
