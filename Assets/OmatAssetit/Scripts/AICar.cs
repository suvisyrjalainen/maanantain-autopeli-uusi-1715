using UnityEngine;

public class AICar : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;

    // Update is called once per frame
    void Update()
    {
        Transform target = waypoints[currentWaypointIndex];

       
        transform.Translate(Vector3.forward);

    }
}
