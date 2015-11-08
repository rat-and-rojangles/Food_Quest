using UnityEngine;
using System.Collections;

public class FadeToBlack : MonoBehaviour {

	public Texture2D fadeTexture;
	float fadeSpeed = 0.2f;
	int drawDepth = -1000;
	
	private float alpha = 1.0f; 
	private int fadeDir = -1; //negative fade in, positive fade out

	public bool fullyFaded = false;
	
	public void OnGUI(){
		
		alpha += fadeDir * fadeSpeed * Time.deltaTime;  
		//alpha = Mathf.Lerp (0, 1, fadeSpeed * Time.deltaTime);
		alpha = Mathf.Clamp01(alpha);   
		
		//GUI.color.a = alpha;

		Color thisColor = GUI.color;
		thisColor.a = alpha;
		GUI.color = thisColor;
		
		GUI.depth = drawDepth;
		
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
	}

	void LateUpdate(){
		Debug.Log (alpha);
		if (alpha >= 1) {
			fullyFaded = true;
		}
	}

	public void FadeOut(){
		
		alpha += fadeSpeed * Time.deltaTime;  
		alpha = Mathf.Clamp01(alpha);   
		
		//GUI.color.a = alpha;
		
		Color thisColor = GUI.color;
		thisColor.a = alpha;
		GUI.color = thisColor;
		
		GUI.depth = drawDepth;
		
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
	}
}
