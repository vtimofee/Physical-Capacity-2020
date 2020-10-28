using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {
	public Camera abovecamera;

	public MasterControls mastercontrols;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	
	}



	public void Turnon()
	{

		transform.GetChild (0).gameObject.SetActive (true);
		abovecamera.enabled = true;


	}

	public void Turnoff()
	{

		transform.GetChild (0).gameObject.SetActive (false);
		abovecamera.enabled = false;


	}

	public void Turnonbelow()
	{

		transform.GetChild (1).gameObject.SetActive (true);

	}

	public void Turnoffbelow()
	{

		transform.GetChild (1).gameObject.SetActive (false);

	}


}
