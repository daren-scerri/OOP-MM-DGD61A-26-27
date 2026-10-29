using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]


public class GreenBall : Ball

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        impulseVector = new Vector2(5f, 0f);
        base.Start();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
