using UnityEngine;

public class RedBall : Ball
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        impulseVector = new Vector2(0f, 5f);
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
