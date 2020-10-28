using UnityEngine;
using System.Collections;

public class RoachInteraction : MonoBehaviour {

	public bool gazedAt;
	private float timer;
	public float gazeTime=2f;

	private Color reticleColor;
	//public GameObject reticle;
	//private Material reticleMaterial;
	private bool colorchanged;
	public bool start;

	public bool roachon;

	public MasterControls masterscript;
	// Use this for initialization
	void Start () {
	//	reticleMaterial = reticle.GetComponent<Renderer> ().material;
		//reticleColor = reticleMaterial.color;

	}

	// Update is called once per frame
	void Update () {

		/*

		if (Input.GetKey ("1") && start) {
		//	reticleColor.r=0;
		}

		//reticle.GetComponent<Renderer> ().material.color = reticleColor;


		if (gazedAt && start) 
			{
			
			//reticle.GetComponent<Renderer> ().material.color = reticleColor;

			//Debug.Log ("gazeon!");
			//Debug.Log (reticleColor.r);
			//transform.Translate (Vector3.up * Time.deltaTime);
			timer += Time.deltaTime;
			//reticleColor=reticleMaterial.color;
			//reticleColor = Color.Lerp (reticleColor, Color.black, 1f * Time.deltaTime);
		//	Debug.Log(reticleColor);
			reticle.GetComponent<Renderer> ().material.color = reticleColor;

			if (reticleColor.r <= .1f ) {

				//gazedAt = false;
				//reticleColor = Color.white;
				gameObject.GetComponent<BoxCollider> ().enabled = false;
				gameObject.tag = "dead";
				masterscript.roachcounter++;


				switch (masterscript.roachcounter) {
				case 1:
					masterscript.levelcounter+=1;

					break;
				case 2:
					//masterscript.levelcounter+=1;
					break;
				case 3:
					masterscript.levelcounter += 1;
					break;
				case 6:
					masterscript.levelcounter += 1;
					break;



					
					
				}



			}

		} 
		else 
		{

		}


		if (timer > gazeTime) {
			//ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
			timer = 0;
		}

*/

	}

	public void PointerEnter()
	{
		Debug.Log ("Pointerneter");
		gazedAt = true;

	}

	public void PointerExit()
	{
		//reticleColor = Color.white;
		//reticle.GetComponent<Renderer> ().material.color = reticleColor;


		Debug.Log ("Pointerexit");
		gazedAt = false;

		timer = 0;

	}

	public void PointerDown()
	{

		Debug.Log ("Pointerdown");
	}


}
