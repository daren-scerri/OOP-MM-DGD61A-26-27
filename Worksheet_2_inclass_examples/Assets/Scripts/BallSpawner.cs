using System.Xml.Schema;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    public float padding;

    private float XMin, XMax, YMin, YMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera myCamera = Camera.main;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        Debug.Log("XMin: " + XMin.ToString());
        XMax = myCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        Debug.Log("XMax: " + XMax.ToString());
        YMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        Debug.Log("YMin: " + YMin.ToString());
        YMax = myCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Debug.Log("YMax: " + YMax.ToString());

        Instantiate(myCirclePrefab, new Vector3(XMin + padding, YMin + padding, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMin + padding, YMax - padding, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax - padding, YMin + padding, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax - padding, YMax - padding, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
