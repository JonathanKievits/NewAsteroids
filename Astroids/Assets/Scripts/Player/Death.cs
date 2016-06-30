using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Death : MonoBehaviour {
    
    private int life;
    public ParticleSystem particles1;

    void Start()
    {
        life = 5;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyShip"))
        {
            life-=1;
            if (life == 0)
            {
                particles1.Play();
                Destroy(gameObject, 1.5f);
                //Inplaats van Dit ---> SceneManager.LoadScene(0);
                // Show DeathScreen(Game hoeft niet gefreezed) en twee opties, Retry en return to main menu
            }
        }
    }
}
