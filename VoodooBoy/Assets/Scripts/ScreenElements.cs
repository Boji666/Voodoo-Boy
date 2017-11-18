using UnityEngine;
using System.Collections;

public class ScreenElements : MonoBehaviour {

	public Rect lifeBarRect;
	public Rect boostBarRect;
	public Rect weaponBarRect;
	public Rect artifactBarRect;
	public Rect magicBarRect;

	public Texture2D lifeBar;
	public Texture2D boostBar;
	public Texture2D weaponBar;
	public Texture2D artifactBar;
	public Texture2D magicBar;

	//private float barDisplay = 256;
	public float speed;

	void OnGUI () 
	{
		GUI.DrawTexture(lifeBarRect,lifeBar);
		GUI.DrawTexture(boostBarRect,boostBar);

		GUI.DrawTexture(weaponBarRect,weaponBar);
		GUI.DrawTexture(artifactBarRect,artifactBar);
		GUI.DrawTexture(magicBarRect,magicBar);
	
	}

	void Update(){



		if (boostBarRect.width > 0.0f) {
			/*
			float decrease = Time.deltaTime;
			Debug.Log(decrease);
			*/
			boostBarRect.width -= speed;

		}else if (boostBarRect.width <= 0.0f){
				
				speed = 0;
		}

	}
}
