using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A ball
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]


public class Ball : MonoBehaviour
{
    protected Vector2 impulseVector = new Vector2(-5, 0);

	/// <summary>
	/// Use this for initialization
	/// </summary>
	virtual protected void Start()
	{
        GetComponent<Rigidbody2D>().AddForce(
            impulseVector, ForceMode2D.Impulse);
        PrintMessage();
	}
	
    /// <summary>
    /// Prints a message
    /// </summary>
    virtual protected void PrintMessage()
    {
        print("I'm a white ball");
    }

    virtual protected void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }


}
