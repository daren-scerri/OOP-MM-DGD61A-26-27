using UnityEngine;

public class Missile : DefaultBullet  //DefaultBullet is the parent class from which Missile is inheriting
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        hitpoints = 10;
        rb.linearDamping = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
