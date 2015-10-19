using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControl : MonoBehaviour {
    Text text;
    int score;
    void Awake() {
        text = GameObject.Find("Puntos").GetComponent<Text>();
        score = PlayerPrefs.GetInt("Puntos");
    }
    // Use this for initialization
    void Start () {
        text.text = ""+score;
	}
	
	// Update is called once per frame
	void Update () {
	  
	}

    public void cambiaPuntos(int puntos)
    {
        score = PlayerPrefs.GetInt("Puntos");
        score = score + puntos;
        PlayerPrefs.SetInt("Puntos", score);
        text.text = "" + score;
    }

    public void restart()
    {
        PlayerPrefs.SetInt("Puntos", 0);
        Application.LoadLevel("level2");
    }
}
