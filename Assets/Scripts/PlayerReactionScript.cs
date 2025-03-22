using UnityEngine;
using UnityEngine.Audio;

public class PlayerReactionScript : MonoBehaviour
{
    public GameObject player;
    public float detectionRange = 5f; 
    public AudioClip soundClip;
    private AudioSource audioSource;
    private Animator animator;
    public string animationTrigger = "PlayAnimation";

    private bool alreadyPlayed= false;


    void Update()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= detectionRange)
        {
            if (alreadyPlayed == false)
            {
                animator.SetTrigger(animationTrigger);
                audioSource.PlayOneShot(soundClip);
                Debug.Log("Son de réaction joué !");
                alreadyPlayed = true;

            }
        }
        else
        {
            alreadyPlayed= false;
        }

    }
}