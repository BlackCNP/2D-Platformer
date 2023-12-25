using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WayFolow : MonoBehaviour
{
   
    [SerializeField] private GameObject[] waypoints;
    private int WaypontInd = 0; //поточний поінт
    [SerializeField] private float speed = 2f;
    // Update is called once per frame
   private void Update()
    {
        if (Vector2.Distance(waypoints[WaypontInd].transform.position, transform.position) < .1f)
        {
            WaypontInd++;
            if(WaypontInd >= waypoints.Length)
            {
                WaypontInd = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[WaypontInd].transform.position, Time.deltaTime * speed);
    }
}
