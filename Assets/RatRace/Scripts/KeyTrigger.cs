using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour
{
    public KeyCode key;
    public GameObject target;
    public bool isOnce = true;
    public bool hasTriggered = false;
    public float delay = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            StartCoroutine(EventOnTriggered());
        }
    }

    IEnumerator EventOnTriggered()
    {
        yield return new WaitForSeconds(delay);

            target.GetComponent<ITriggerable>().OnTriggered();
            hasTriggered = true;
    }
}
