using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncPusher : MonoBehaviour, ITriggerable
{
    public bool isMoving = true;
    private bool isReversed = false;
    public Vector3 direction = Vector3.down;
    public float speed = 1f;
    public float duration = 3f;
    void ITriggerable.OnTriggered()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MovePiston());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator MovePiston()
    {
        float timer = duration;
        while (timer >= 0)
        {
            if (isReversed)
            {
                transform.position -= direction * speed * Time.deltaTime;
            }
            else
            {
                transform.position += direction * speed * Time.deltaTime;
            }
            timer -= Time.deltaTime;
            yield return null;
        }
        isReversed = !isReversed;
        StartCoroutine(MovePiston());
    }
}
