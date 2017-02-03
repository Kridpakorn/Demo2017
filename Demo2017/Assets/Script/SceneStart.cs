using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneStart : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
    public void DoChangeScene()
    {
        SceneManager.LoadScene(0);

    }
}
