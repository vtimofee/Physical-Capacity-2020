using UnityEngine;
using System.Collections;

public class SphereeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision (GameObject.Find ("Cube").GetComponent<Collider> (), GetComponent<Collider> ());
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * .2f * Time.deltaTime);

	
	}
}
