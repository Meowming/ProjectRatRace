using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Playables;
using UnityEngine.Playables;

public class FuncTimeline : MonoBehaviour, ITriggerable
{
    public PlayableDirector playDirector;
    void ITriggerable.OnTriggered()
    {
        playDirector.Play();

    }

    // Start is called before the first frame update
    void Start()
    {
    }
}