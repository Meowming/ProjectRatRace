using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(CharacterController))]
public class PlayerMain : MonoBehaviour, IHurtable
{
    int hitpoint = 100;
    bool isDead = false;
    Animator animator;
    public CharacterController characterController;
    public AudioClip deadSound;
    public Camera playerMainCam;
    public PlayableDirector deathTimeline;
    void IHurtable.OnHurt(int damage)
    {
        hitpoint -= damage;
        if (hitpoint <= 0)
        {
            if (!isDead)
            {
                Death();
            }
        }
    }

    void Death()
    {
        isDead = true;
        print("dead");
        StopPlayerControl();

        transform.rotation *= Quaternion.Euler(0f, 0f, 90f);
        AudioSource.PlayClipAtPoint(deadSound, transform.position);
    }

    public void StopPlayerControl()
    {
        characterController.enabled = false;
        
        StarterAssets.ThirdPersonController tpController;
        TryGetComponent(out tpController);
        tpController.enabled = false;

        TryGetComponent(out animator);
        animator.enabled = false;

        if (deathTimeline != null)
        {
            deathTimeline.Play();
        }
    }

    public void ResumePlayerControl()
    {
        characterController.enabled = true;
        
        StarterAssets.ThirdPersonController tpController;
        TryGetComponent(out tpController);
        tpController.enabled = true;

        TryGetComponent(out animator);
        animator.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public CharacterController GetCharacaterController()
    {
        return characterController;
    }

}
