using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilActive : MonoBehaviour, ITriggerable
{
    public bool isSetActive = true;// active = true
    void ITriggerable.OnTriggered()
    {
        this.gameObject.SetActive(isSetActive);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
