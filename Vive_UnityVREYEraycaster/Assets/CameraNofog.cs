using UnityEngine;
using System.Collections;

public class CameraNofog : MonoBehaviour {


	private bool revertFogState = false;
	// Use this for initialization
	void onPreRender () {

		revertFogState = RenderSettings.fog;
		RenderSettings.fog = enabled;
	
	}
	
	// Update is called once per frame
	void onPostRender () {
		RenderSettings.fog = revertFogState;
	}
}
