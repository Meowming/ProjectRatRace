using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncDoor : MonoBehaviour
{
    public Transform rotateAxis = null;
    public float rotateTargetDegree = 90f;
    public float rotateDuration = 2f;
    public bool isOnce = true;
    public bool hasTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rotateAxis == null)
        {
            Debug.LogWarning("FuncDoor: No Axis Assigned!");
            return;
        }
        else
        {
            if (isOnce && hasTriggered)
            {
                return;
            }
            StartCoroutine(DoorRotate());
            hasTriggered = true;
        }
    }

    IEnumerator DoorRotate()
    {
        float rotateTimer = rotateDuration;
        float rotateDelta = 0f;
        while (rotateTimer >= 0f)
        {
            //rotateDelta = Mathf.SmoothDampAngle(transform.eulerAngles.y, transform.eulerAngles.y + rotateTargetDegree,ref rotateDelta, rotateDuration);
            transform.RotateAround(rotateAxis.position, Vector3.up, rotateTargetDegree * Time.deltaTime);
            rotateTimer -= Time.deltaTime;
            print(rotateDelta);
            yield return null;
        }
    }
}
