using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("level loaded requested for "+name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log("Game Quited");
		Application.Quit();
	}
	
}
