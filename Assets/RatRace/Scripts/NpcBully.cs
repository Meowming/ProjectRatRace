using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcBully : MonoBehaviour
{
    public List<Transform> waypoints;
    public float epsilonToTarget = 0.1f;
    int nextWaypoint = 0;
    public bool isX = true;
    public bool isNegative = false;
    public float xTime = 2f;
    public float ZTime = 2f;
    public float speed = 30f;
    float tempXTime, tempZTime;
    // Start is called before the first frame update
    void Start()
    {
        tempXTime = xTime;
        tempZTime = ZTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isX)
        {
            if (tempXTime <= 0)
            {
                isX = false;
                tempXTime = xTime;
            }
            int dir = isNegative ? -1 : 1;
            transform.position +=  dir * Vector3.right * speed * Time.deltaTime;
            tempXTime -= Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(dir * Vector3.right, Vector3.up);
        }
        else
        {
            if (tempZTime <= 0)
            {
                isX = true;
                tempZTime = ZTime;
                isNegative = !isNegative;
            }
            int dir = isNegative ? -1 : 1;
            transform.position += dir * Vector3.forward * speed * Time.deltaTime;
            tempZTime -= Time.deltaTime;
            transform.rotation = Quaternion.LookRotation(dir * Vector3.forward,Vector3.up);
        }
        /*
        if (waypoints.Count != 0)
        {
            Vector3 distanceToNextTarget = transform.position - waypoints[nextWaypoint].position;
            if (distanceToNextTarget.magnitude * distanceToNextTarget.magnitude < epsilonToTarget * epsilonToTarget) //Close enough
            { 

            }
        }
        */

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject player = collision.gameObject;
    }
}
