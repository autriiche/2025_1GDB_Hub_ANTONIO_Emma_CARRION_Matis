using UnityEngine;

public class PlayerReactionScript : MonoBehaviour
{
    public GameObject player;
    public float detectionRange = 5f; // Distance � partir de laquelle l'animation est jou�e
    private Animator animator;
    public string animationTrigger = "PlayAnimation"; // Nom du trigger de l'animation

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Aucun GameObject joueur assign� � " + gameObject.name);
        }

        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Aucun Animator trouv� sur " + gameObject.name);
        }
    }

    void Update()
    {
        if (player != null && animator != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);

            if (distance <= detectionRange)
            {
                animator.SetTrigger(animationTrigger);
            }
        }
    }
}