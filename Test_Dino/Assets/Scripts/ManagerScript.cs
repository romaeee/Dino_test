using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public static int score = 0;
    public static Vector3 targetPosition;


    void Start()
    {
        Time.timeScale = 0;
        score = 0;
    }

    void Update()
    {
        if (score == 3)
        {
            WaypointMover.level = 1;
        }
        else if (score == 6)
        {
            WaypointMover.level = 2;
        }
        else if (score == 9)
        {
            WaypointMover.level = 3;
        }
        else if (score == 12)
        {
            WaypointMover.level = 4;
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }
}
