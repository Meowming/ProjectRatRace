using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncMaterialSwap : MonoBehaviour, ITriggerable
{
    public Material original;
    public Material target;
    public float transitionTime = 10f;

    void ITriggerable.OnTriggered()
    {
        StartCoroutine(MaterialTransition());
    }

    IEnumerator MaterialTransition()
    {
        float timeElapse = 0f;
        while(timeElapse<=transitionTime)
        {
            timeElapse += Time.deltaTime;
            RenderSettings.skybox.Lerp(original, target, timeElapse / transitionTime);
            yield return null;
        }
        RenderSettings.skybox = target;
    }

    private void OnDisable()
    {
        RenderSettings.skybox = original;
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
