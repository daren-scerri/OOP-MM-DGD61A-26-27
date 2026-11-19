using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CannonController : MonoBehaviour
{
    [SerializeField] float maxCannonAngle = 60f;
    [SerializeField] float slerp_speed=2;

    [SerializeField] GameObject bullet1Prefab;
    [SerializeField] GameObject bullet2Prefab;

    [SerializeField] ObjectPooling cannonBallPool, missilePool;

    [SerializeField] Transform cannonTip;

    [SerializeField] float bullet1_firingRate = 1f; 
    [SerializeField] float bullet2_firingRate = 1f;

    Quaternion minAngle, maxAngle;

    Coroutine fireCoroutine1, fireCoroutine2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minAngle = Quaternion.Euler(0f,0f,-maxCannonAngle);
        maxAngle = Quaternion.Euler(0f,0f,+maxCannonAngle);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();
        Fire();
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


    IEnumerator FireContinuously(ObjectPooling bulletPool, float _firingRate)
    {
        while (true)
        {
        GameObject newBullet1 = bulletPool.GetPoolObject();
        //GameObject newBullet1 = Instantiate(bulletprefab,cannonTip.position,Quaternion.identity);
        newBullet1.transform.position = cannonTip.position;
        newBullet1.transform.rotation = cannonTip.rotation;
        newBullet1.SetActive(true);
        yield return new WaitForSeconds(_firingRate);
        }
    }


    private void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fireCoroutine1 = StartCoroutine(FireContinuously(cannonBallPool, bullet1_firingRate));
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (fireCoroutine1 != null) StopCoroutine(fireCoroutine1);
            fireCoroutine1 = null;
        }

         if (Input.GetMouseButtonDown(1))
        {
            fireCoroutine2 = StartCoroutine(FireContinuously(missilePool, bullet2_firingRate));
        }

          if (Input.GetMouseButtonUp(1))
        {
            if (fireCoroutine2 != null) StopCoroutine(fireCoroutine2);
            fireCoroutine2 = null;
        }


    }



}
