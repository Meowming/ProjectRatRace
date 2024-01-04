using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour, ITriggerable
{
    public Transform targetTransform;
    public GameObject targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //targetObject.transform.position = targetTransform.position;
    }
    void ITriggerable.OnTriggered()
    {
        //targetObject.GetComponent<CharacterController>().center = targetTransform.position;
        //targetObject.transform.position = targetTransform.position;
        StartCoroutine(FuckUnity());
    }

    IEnumerator FuckUnity()
    {
        targetObject.GetComponent<CharacterController>().enabled = false;
        targetObject.transform.position = targetTransform.position;
        yield return null;
        targetObject.GetComponent<CharacterController>().enabled = true;
    }
}
