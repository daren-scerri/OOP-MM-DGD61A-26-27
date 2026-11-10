using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CannonController : MonoBehaviour
{
    [SerializeField] float maxCannonAngle = 60f;
    [SerializeField] float slerp_speed=2;

    Quaternion minAngle, maxAngle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minAngle = Quaternion.Euler(0f,0f,-maxCannonAngle);
        maxAngle = Quaternion.Euler(0f,0f,+maxCannonAngle);
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
        Vector3 relativePos = this.transform.position - mousePos;
        Quaternion newrotation = Quaternion.LookRotation(relativePos, Vector3.forward);
        //Debug.Log(newrotation);
        newrotation.x =0;
        newrotation.y =0;
        newrotation.z = Mathf.Clamp(newrotation.z, minAngle.z, maxAngle.z);
        newrotation.w = Mathf.Clamp(newrotation.w, minAngle.w, maxAngle.w);
        // this.transform.rotation = newrotation;  //NO SLERP
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * slerp_speed);

    }



}
