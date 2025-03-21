using UnityEngine;
using UnityEngine.Audio;

public class PlayerReactionScript : MonoBehaviour
{
    public GameObject player;
    public float detectionRange = 5f; 
    public AudioClip soundClip;
    private AudioSource audioSource;

    private bool alreadyPlayed= false;


    void Update()
    {
        audioSource = GetComponent<AudioSource>();
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance <= detectionRange)
        {
            if (alreadyPlayed == false)
            {
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