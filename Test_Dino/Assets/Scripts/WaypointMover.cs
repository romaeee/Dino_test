using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class WaypointMover : MonoBehaviour
{
    public Transform[] waypoints;
    public static int level = 0;
    public static bool playing = true;
    public Vector3 velocity;

    private NavMeshAgent agent;
    private Animator playerAnimator;
    private int waypointIndex;
    private Vector3 target;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerAnimator = GetComponent<Animator>();
        level = 0;
        UpdateDistanetion();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            UpdateDistanetion();
        }
    }

    void UpdateDistanetion()
    {
        if (waypointIndex == 0 && level == 0 || waypointIndex == 1 && level == 0)
        {
            IterateWaypointIndex();
        }

        else if (waypointIndex == 2 && level == 0)
        {
            playerAnimator.SetBool("isRun", false);
            playing = false;
        }

        else if (waypointIndex == 2 && level == 1)
        {
            playing = true;
            IterateWaypointIndex();
        }

        else if (waypointIndex == 3 && level == 1)
        {
            playerAnimator.SetBool("isRun", false);
            playing = false;
        }

        else if (waypointIndex == 3 && level == 2)
        {
            playing = true;
            IterateWaypointIndex();
        }

        else if (waypointIndex == 4 && level == 2)
        {
            playerAnimator.SetBool("isRun", false);
            playing = false;
        }

        else if (waypointIndex == 4 && level == 3)
        {
            playing = true;
            IterateWaypointIndex();
        }

        else if (waypointIndex == 5 && level == 3)
        {
            playerAnimator.SetBool("isRun", false);
            playing = false;
        }

        else if (waypointIndex == 5 && level == 4)
        {
            playing = true;
            IterateWaypointIndex();
        }

        else if (waypointIndex == 6 && level == 4)
        {
            playing = true;
            ManagerScript.score = 0;
            level = 0;
            SceneManager.LoadScene("SampleScene");
        }


        if (playing)
        {
            target = waypoints[waypointIndex].position;
            agent.SetDestination(target);
            playerAnimator.SetBool("isRun", true);
        }
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
    }

    public void NextLevel()
    {
        level++;
    }
}