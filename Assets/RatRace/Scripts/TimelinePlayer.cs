using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class TimelinePlayer : MonoBehaviour,ITriggerable
{
    public PlayableDirector director;
    public PlayerMain player;

    void ITriggerable.OnTriggered()
    {
        this.gameObject.SetActive(true);
        player.StopPlayerControl();
        director.Play();
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
