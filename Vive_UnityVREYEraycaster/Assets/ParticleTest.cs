using UnityEngine;
using System.Collections;

public class ParticleTest : MonoBehaviour {

	public ParticleSystem explosion;

	// Use this for initialization
	void Awake()
	{

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("a")) {

			if (!explosion.isPlaying) {
				explosion.Play ();
			//	explosion.emission.enabled = true;

			}

		}
	}
}
