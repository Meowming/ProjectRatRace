using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerConveyor : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 direction = Vector3.forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        var player = other.GetComponentInParent<PlayerMain>();
        var controller = player.GetCharacaterController();
        controller.Move(speed * direction);
    }
}
