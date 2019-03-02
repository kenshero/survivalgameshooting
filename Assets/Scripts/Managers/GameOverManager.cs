using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public NewPlayerHealth playerHealth;


    Animator anim;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
        }
    }
}
