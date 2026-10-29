using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabBall;
    [SerializeField] GameObject prefabGreenBall;
    [SerializeField] GameObject prefabRedBall;

    [SerializeField] int timerDuration = 1 ;

    Timer myTimer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Instantiate(prefabBall);
        
      //  Timer myTimer = new Timer();   this approach is not recommended in Unity
    myTimer = this.gameObject.AddComponent<Timer>();
    myTimer.Duration = timerDuration;
    myTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        if (myTimer.Finished == true)
        {
            myTimer.Run();
            int balltype = Random.Range(0, 2);
            if (balltype == 0)
            {
                Instantiate(prefabGreenBall);
            }
            else if (balltype == 1) {
                Instantiate(prefabRedBall);
            }
        }

}

}
