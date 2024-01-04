using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncTrigger : MonoBehaviour
{
    public GameObject target;
    public bool isOnce = true;
    public bool hasTriggered = false;
    public float delay = 0f;
    public bool isPlayOnStart = false;
    // Start is called before the first frame update
    void Start()
    {
        if (isPlayOnStart)
        {
            StartCoroutine(EventOnTriggered());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(EventOnTriggered());
    }

    IEnumerator EventOnTriggered()
    {
        yield return new WaitForSeconds(delay);
        if (isOnce && !hasTriggered)
        {
            target.GetComponent<ITriggerable>().OnTriggered();
            hasTriggered = true;
        }
    }
}
