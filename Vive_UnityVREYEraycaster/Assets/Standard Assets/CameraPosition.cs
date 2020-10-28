using UnityEngine;
using System.Collections;
using Valve.VR;


public class CameraPosition : MonoBehaviour {

	// Use this for initialization

	public Vector3 steamcameraposition;
	public Quaternion headrotation;
	private Vector3 zeroposition=new Vector3(0.0f,0.0f,0.0f);
	public bool readytostart;
	private float headrotationx;
	private float headrotationy;
	private float headrotationz;

	public bool turnofftracking;
	public bool below;
	public bool above;

	public bool headtouch;
	public bool headtouchcieling;
	public bool startrequirement;

	public bool headabove;



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log ("HEADTOUCH : " + headtouch);
		//headrotationx = headrotation.x;
		//headrotationy = headrotation.y;
		//headrotationz = headrotation.z;

		//Debug.Log ("X : " + headrotationx + "Y : " + headrotationy + "Z : " + headrotationz);

		
	
		if (steamcameraposition!=zeroposition && Time.time>1 && !turnofftracking)
		{
			//Debug.Log (steamcameraposition);
			if (steamcameraposition.y < 0.3f && !readytostart && startrequirement) {
				readytostart = true;
			} 

			if (steamcameraposition.y >= 0.3f && readytostart) {
				above = true;
			} else if (steamcameraposition.y < 0.3f && readytostart) {
				above = false;
			}
				

			
		}




	}


	void OnTriggerStay(Collider other)
	{
		//Debug.Log ("COLLIDE WITH" + other.gameObject.tag);
		if (headabove)return;
		if (other.tag == "border" || other.tag == "wall") {
			headtouch = true;
			Debug.Log ("COLLLIDER : " + other.gameObject.name);
		//	Debug.Log ("HEADTOUCH!!!!");
		}
		else if (other.tag == "cieling")
			headtouchcieling = true;
	}

	void OnTriggerExit(Collider other)
	{
		headtouch =false;

	}


}
