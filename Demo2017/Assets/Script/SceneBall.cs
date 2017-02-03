using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneBall : MonoBehaviour {

	public Text txtScore;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	int score = 0 ;
	public void DoPushButton(){
		score++;
		txtScore.text = "Score :" + score.ToString ();
	}
	public void DoChangeScene(){
		SceneManager.LoadScene (1);

    }
}
