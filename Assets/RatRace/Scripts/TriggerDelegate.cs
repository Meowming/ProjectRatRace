using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDelegate : MonoBehaviour, ITriggerable
{
    public Dictionary<ITriggerable, float> triggerList = new Dictionary<ITriggerable, float>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EventTrigger(ITriggerable target,float delay)
    {
        yield return new WaitForSeconds(delay);
        target.OnTriggered();
        yield return null;
    }

    void ITriggerable.OnTriggered()
    {
        foreach (var trigger in triggerList)
        {
            StartCoroutine(EventTrigger(trigger.Key, trigger.Value));
        }
    }
}
