using UnityEngine;

public class PlayerReactionScript : MonoBehaviour
{
    public GameObject JoueurCible = null;
    //public sound

    public float distanceMin = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Jouer l'animation d'idle
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, JoueurCible.transform.position) > distanceMin) // Verifie que la distance minimale est respectée
        {
            Debug.Log("Son enclenché");
        }
        else
        {
            // jouer l'animation d'idle
        }

    }
}