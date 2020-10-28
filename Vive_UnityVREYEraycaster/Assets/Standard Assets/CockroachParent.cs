using UnityEngine;
using System.Collections;

public class CockroachParent : MonoBehaviour {


	public int levelcounter;

	// Use this for initialization
	void Start () {
		foreach (Transform child in this.transform) {
			child.gameObject.SetActive (false);

		}
		transform.GetChild (0).gameObject.SetActive (true);


	
	}
	
	// Update is called once per frame
	void Update () {


		switch (levelcounter) {
		case 1:
			transform.GetChild (0).gameObject.SetActive (true);
			//transform.GetChild (25).gameObject.SetActive (true);
		
			break;
		case 2:
			//transform.GetChild (0).gameObject.SetActive (false);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			break;
		case 3:
			//transform.GetChild (1).gameObject.SetActive (false);
			//transform.GetChild (2).gameObject.SetActive (false);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
			transform.GetChild (5).gameObject.SetActive (true);
			break;
		case 4:
	
			//transform.GetChild (3).gameObject.SetActive (false);
			//transform.GetChild (4).gameObject.SetActive (false);
			//transform.GetChild (5).gameObject.SetActive (false);
			transform.GetChild (6).gameObject.SetActive (true);
			transform.GetChild (7).gameObject.SetActive (true);
			transform.GetChild (8).gameObject.SetActive (true);
			transform.GetChild (9).gameObject.SetActive (true);
			break;
		case 5:

			transform.GetChild (10).gameObject.SetActive (true);
			transform.GetChild (11).gameObject.SetActive (true);
			transform.GetChild (12).gameObject.SetActive (true);
			transform.GetChild (13).gameObject.SetActive (true);

			break;

		case 6:

			transform.GetChild (14).gameObject.SetActive (true);
			transform.GetChild (15).gameObject.SetActive (true);
			transform.GetChild (16).gameObject.SetActive (true);
			transform.GetChild (17).gameObject.SetActive (true);
			transform.GetChild (18).gameObject.SetActive (true);


			break;

		case 7:

			transform.GetChild (19).gameObject.SetActive (true);
			transform.GetChild (20).gameObject.SetActive (true);
			transform.GetChild (21).gameObject.SetActive (true);
			transform.GetChild (22).gameObject.SetActive (true);
			transform.GetChild (23).gameObject.SetActive (true);
			transform.GetChild (24).gameObject.SetActive (true);



			break;

		case 8:

			//transform.GetChild (25).gameObject.SetActive (true);
		



			break;






		}
	
	}
}
