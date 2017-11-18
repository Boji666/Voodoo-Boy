using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public Texture2D normalTexture;
	public Texture2D rollOverTexture;
	public bool QuitButton = false;
	public string levelLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	void OnMouseEnter(){
		GetComponent<GUITexture>().texture = rollOverTexture;
	}
	
	void OnMouseExit(){
        GetComponent<GUITexture>().texture = normalTexture;
	}
	
	void OnMouseUp(){
		

		
		if(QuitButton){

			Application.Quit();
			//Debug.Log("This part works!");
			
		}else{
		
			//Debug.Log("Try to chargue the level!");
						SceneManager.LoadScene(levelLoad);
			//Debug.Log("Level Chargued!");
		}
		

	}
}
