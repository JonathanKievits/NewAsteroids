using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public Text hScoreText;
    public Text scoreText;
    private ScoreSaver test;
    public float _speed;

    void Start()
    {
        Destroy(gameObject, 2f);
        test = GameObject.FindObjectOfType<ScoreSaver>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        
        //scoreText.GetComponent<ScoreSaver>() = "Score: " + score.ToString();
        //hScoreText.text = "Highscore: " + highScore.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyShip"))
        {
            hitpoints();
            Destroy(gameObject);
        }
    }

    void hitpoints()
    {
        test.score += 10;
    }

    public void SetSpeed(float value)
    {
        _speed = value;
    }
}
