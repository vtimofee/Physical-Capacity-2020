using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CubeZoomTest : MonoBehaviour {

	public Camera ccamera;
	public Image reticle;
	public Sprite reticleon;
	public Sprite reticleoff;

	public bool on;

	// Use this for initialization
	void Start () {
		reticle.sprite = reticleoff;

		//reticle.color = Color.red;
	}
	
	// Update is called onc

	void Update()
	{

		//Debug.Log ("on:" + on);

		if (on && ccamera.fieldOfView > 50) {
			ccamera.fieldOfView -= 40 * Time.deltaTime;
			reticle.sprite = reticleon;
			//ccamera.GetComponent<CameraFilterPack_Blur_Tilt_Shift_Hole> ().enabled = true;
	
		} else if (!on)  {
				ccamera.fieldOfView=Mathf.Lerp(ccamera.fieldOfView,120,1*Time.deltaTime);
			reticle.sprite = reticleoff;
			//ccamera.GetComponent<CameraFilterPack_Blur_Tilt_Shift_Hole> ().enabled = false;



		}
	}

}
