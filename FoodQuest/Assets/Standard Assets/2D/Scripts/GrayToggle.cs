using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class GrayToggle : MonoBehaviour {

	public void GrayToColor(){
		foreach (Image ff in GetComponentsInChildren<Image>())
		{
			if(ff.gameObject.tag.Equals("gray")){
				ff.enabled = false;
			}
			else if(ff.gameObject.tag.Equals("colored")){
				ff.enabled = true;
			}
		}
	}
}
