using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    public GameObject bullet;


    void Update()
    {
        if (!WaypointMover.playing)
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float midPoint = (transform.position - Camera.main.transform.position).magnitude * 180f;

            transform.LookAt(mouseRay.origin + mouseRay.direction * midPoint);

            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, transform.position, transform.rotation);
            }
        }
    }
}
