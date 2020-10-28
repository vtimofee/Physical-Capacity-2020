using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CubeInteration : MonoBehaviour {

	public bool gazedAt;
	private float timer;
	public float gazeTime=10f;
	private Color reticleColor;
	public GameObject reticle;
	private Material reticleMaterial;
	private bool colorchanged;

	public GameObject testobject;
	// Use this for initialization
	void Start () {
		reticleMaterial = reticle.GetComponent<Renderer> ().material;
		reticleColor = reticleMaterial.color;

	}

	// Update is called once per frame
	void Update () {

		Debug.Log (gazedAt);

		//Debug.Log (gazedAt);
		reticle.GetComponent<Renderer> ().material.color = reticleColor;


		if (gazedAt) {
			Debug.Log ("gazeon!");
			Debug.Log (reticleColor.r);
			//transform.Translate (Vector3.up * Time.deltaTime);
			timer += Time.deltaTime;
			//reticleColor=reticleMaterial.color;
			reticleColor = Color.Lerp (reticleColor, Color.black, 1f * Time.deltaTime);
			Debug.Log(reticleColor);
			reticle.GetComponent<Renderer> ().material.color = reticleColor;

			if (reticleColor.r <= .1f) {

				//gazedAt = false;
				gameObject.GetComponent<BoxCollider> ().enabled = false;

			}




		} 
		else 
		{

		}


		if (timer > gazeTime) {
			ExecuteEvents.Execute (gameObject, new PointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
			timer = 0;
		}



	}

	public void PointerEnter()
	{
		Debug.Log ("Pointerneter");
		gazedAt = true;

	}

	public void PointerExit()
	{
		reticleColor = Color.white;

		Debug.Log ("Pointerexit");
		gazedAt = false;

		timer = 0;

	}

	public void PointerDown()
	{

		Debug.Log ("Pointerdown");
	}

}
