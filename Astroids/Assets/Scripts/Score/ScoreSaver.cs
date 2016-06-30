using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreSaver : MonoBehaviour {

    [SerializeField] private Text _text;
    [SerializeField] private Text _htext;
    public int score = 0;
    public float highScore = 0;


    void Start () {
        highScore = PlayerPrefs.GetFloat("High Score");
        score = 0;
    }
	
	void Update () {
        _text.text = "Score: " + score.ToString();
        _htext.text = "Highscore: " + highScore.ToString();
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("High Score", highScore);
        }
    }
}
