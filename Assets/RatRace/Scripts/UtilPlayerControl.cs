using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilPlayerControl : MonoBehaviour, ITriggerable
{
    public PlayerMain player;
    public bool isToFreezePlayer = true;
    void ITriggerable.OnTriggered()
    {
        if (isToFreezePlayer)
        {
            player.StopPlayerControl();
        }
        else 
        {
            player.ResumePlayerControl();
        }
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
