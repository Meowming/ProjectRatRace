using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncPlatform : MonoBehaviour,ITriggerable
{
    public Vector3 movingDirection = Vector3.up;
    public float speed = 5f;
    public float duration = 2f;
    public AudioClip EndingSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ITriggerable.OnTriggered()
    {
        StartCoroutine(MovePlatform());
    }

    IEnumerator MovePlatform()
    {
        float timer = duration;
        while(timer>=0)
        {
            transform.position += movingDirection * speed * Time.deltaTime;
            timer -= Time.deltaTime;
            yield return null;
        }
        if (EndingSound != null)
        {
            AudioSource.PlayClipAtPoint(EndingSound, transform.position);
        }
    }
}
