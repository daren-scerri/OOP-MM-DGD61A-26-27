using UnityEngine;

public class BallDrag : MonoBehaviour
{
    private Vector3 mousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        Debug.Log("Dragging");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f,0f,10f);
        this.gameObject.transform.position = mousePos;
    }
}
