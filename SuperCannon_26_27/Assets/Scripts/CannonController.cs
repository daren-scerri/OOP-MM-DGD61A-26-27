using UnityEngine;

public class CannonController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PointAtMouse();
    }

    private void PointAtMouse()
    {
        Camera myCamera = Camera.main;
        Vector3 mousePos = myCamera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f,0f,10f);
        Vector3 relativePos = mousePos - this.transform.position;
        Quaternion newrotation = Quaternion.LookRotation(relativePos);
        this.transform.rotation = newrotation;

    }



}
