using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHurt : MonoBehaviour
{
    public int damage = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var hurtable = other.GetComponent<IHurtable>(); 
        if (hurtable == null)
        {
            hurtable = other.GetComponentInParent<IHurtable>();
        }
        hurtable.OnHurt(damage);
    }
}
