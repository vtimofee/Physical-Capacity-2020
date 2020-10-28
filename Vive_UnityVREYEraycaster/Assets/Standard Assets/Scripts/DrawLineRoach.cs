using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawLineRoach : MonoBehaviour 
{
	public LineRenderer line;
	private bool isMousePressed;
	public List<Vector3> pointsList;
	private Vector3 mousePos;
	public Color color1;
	public Color color2;
	public bool off;
	private Vector3 tempposition1;
	public GameObject roach1tracker;
	public GameObject roach2tracker;
	public GameObject roach3tracker;
	public GameObject roach4tracker;
	public GameObject roach5tracker;
	public GameObject roach6tracker;
	private Vector3 trackeroffposition;
	public Material linematerial;

	private float timeCount;
	private bool on;
	public Vector3 tempPos;
	public int levelcounter;
	public MasterControls master;
	private string whoami;

	private bool turnedon;
	private bool moveaway;
	public Material linematerial2;



	// Structure for line points
	struct myLine
	{
		public Vector3 StartPoint;
		public Vector3 EndPoint;

	};
	//    -----------------------------------    
	void Awake()
	{


		roach2tracker = GameObject.Find ("Roach2_tracker");
		roach3tracker = GameObject.Find ("Roach3_tracker");
		roach4tracker = GameObject.Find ("Roach4_tracker");
		roach5tracker = GameObject.Find ("Roach5_tracker");
		roach6tracker = GameObject.Find ("Roach6_tracker");

		trackeroffposition = new Vector3 (.591f, 39.667f, 3.11f);

		whoami = gameObject.name;
		//color1 = new Color (1, 0,0, 0.5f);
		//color2 = new Color (0, 1, 0, .5f);
		// Create line renderer component and set its property
		//line = gameObject.AddComponent<LineRenderer>();

		line.material =  new Material(Shader.Find("Particles/Additive"));
		line.SetVertexCount(0);
		line.SetWidth(0.01f,0.01f);
		line.SetColors(Color.white, Color.white);
		line.useWorldSpace = true;    
		isMousePressed = false;
		pointsList = new List<Vector3>();
		//isMousePressed = true;
		line.SetVertexCount(0);
		pointsList.RemoveRange(0,pointsList.Count);
		//InvokeRepeating ("Measure", .1f, .1f);
		//InvokeRepeating ("Add", 5f, .1f);
		//InvokeRepeating ("Remove", 10f, .1f);
		//Off ();

		//        renderer.material.SetTextureOffset(
	}
	//    -----------------------------------    
	void Update () 
	{

		if (master.outlinemoveaway) {
			Off ();

		}

		if (moveaway) {

			roach1tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, 1 * Time.deltaTime);
			roach2tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, 1 * Time.deltaTime);
			roach3tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, 2 * Time.deltaTime);
			roach4tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, 1.5f * Time.deltaTime);
			roach5tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, .5f * Time.deltaTime);
			roach6tracker.transform.position = Vector3.Lerp (roach1tracker.transform.position, trackeroffposition, .7f * Time.deltaTime);


		}
		if (master.initialized && !turnedon) {
			turnedon = true;
			Off ();
			Invoke ("Moveawayreset", 2);
		}

		// If mouse button down, remove old line and set its color to green

		switch (master.levelcounter)
		{
			case 1:
			if (whoami  == "1" && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);

		} else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
			if (whoami == "1") roach1tracker.transform.position = trackeroffposition;

		}

			break;

		case 2:
			if ((whoami == "2" || whoami == "3") && gameObject.tag != "dead" && !on) {
				on = true;
				InvokeRepeating ("Add", 0, .1f);
			} else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "2") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "3") roach2tracker.transform.position = trackeroffposition;

			}
			break;

		case 3:
			if ( (whoami=="4" || whoami=="5" || whoami=="6") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "4") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "5") roach2tracker.transform.position = trackeroffposition;
				else if (whoami == "6") roach3tracker.transform.position = trackeroffposition;
			}
			break;

		case 4:
			if ( (whoami=="7" || whoami=="8" || whoami=="9" || whoami=="10") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "7") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "8") roach2tracker.transform.position = trackeroffposition;
				else if (whoami == "9") roach3tracker.transform.position = trackeroffposition;
				else if (whoami == "10") roach4tracker.transform.position = trackeroffposition;
			}
			break;

		case 5:
			if ( (whoami=="11" || whoami=="12" || whoami=="13" || whoami=="14") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "11") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "12") roach2tracker.transform.position = trackeroffposition;
				else if (whoami == "13") roach3tracker.transform.position = trackeroffposition;
				else if (whoami == "14") roach4tracker.transform.position = trackeroffposition;
			}
			break;

		case 6:
			if ( (whoami=="15" || whoami=="16" || whoami=="17" || whoami=="18" || whoami=="19") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "15") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "16") roach2tracker.transform.position = trackeroffposition;
				else if (whoami == "17") roach3tracker.transform.position = trackeroffposition;
				else if (whoami == "18") roach4tracker.transform.position = trackeroffposition;
				else if (whoami == "19") roach5tracker.transform.position = trackeroffposition;

			}
			break;

		case 7:
			if ( (whoami=="20" || whoami=="21" || whoami=="22" || whoami=="23" || whoami=="24" || whoami=="25") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "20") roach1tracker.transform.position = trackeroffposition;
				else if (whoami == "21") roach2tracker.transform.position = trackeroffposition;
				else if (whoami == "22") roach3tracker.transform.position = trackeroffposition;
				else if (whoami == "23") roach4tracker.transform.position = trackeroffposition;
				else if (whoami == "24") roach5tracker.transform.position = trackeroffposition;
				else if (whoami == "25") roach6tracker.transform.position = trackeroffposition;

			}
			break;


		case 8:
			if ( (whoami=="26") && gameObject.tag!="dead" && !on){
				on=true;
				InvokeRepeating ("Add", 0, .1f);
			}
			else if (gameObject.tag == "dead" || gameObject.tag == "deaded") {
				if (whoami == "26") roach1tracker.transform.position = trackeroffposition;
			}
			break;

		}

		if (gameObject.tag == "dead") {
			CancelInvoke ("Add");
			pointsList.Clear ();
			line.SetVertexCount (0);
		}




		if (pointsList != null) {
			line.SetVertexCount (pointsList.Count);
			for (int i = 0; i < pointsList.Count; i++) {
				line.SetPosition (i, pointsList [i]);
			}

		} else
			line.SetVertexCount (0);






		// Drawing line when mouse is moving(presses)

	}
	//    -----------------------------------    
	//  Following method checks is currentLine(line drawn by last two points) collided with line 
	//    -----------------------------------    
	private bool isLineCollide()
	{
		/*if (pointsList.Count < 2)
			return false;
		int TotalLines = pointsList.Count - 1;
		myLine[] lines = new myLine[TotalLines];
		if (TotalLines > 1) 
		{
			for (int i=0; i<TotalLines; i++) 
			{
				lines [i].StartPoint = (Vector3)pointsList [i];
				lines [i].EndPoint = (Vector3)pointsList [i + 1];
			}
		}
		for (int i=0; i<TotalLines-1; i++) 
		{
			myLine currentLine;
			currentLine.StartPoint = (Vector3)pointsList [pointsList.Count - 2];
			currentLine.EndPoint = (Vector3)pointsList [pointsList.Count - 1];
			if (isLinesIntersect (lines [i], currentLine)) 
				return true;
		}*/
		return false;
	}
	//    -----------------------------------    
	//    Following method checks whether given two points are same or not
	//    -----------------------------------    
	private bool checkPoints (Vector3 pointA, Vector3 pointB)
	{
		return (pointA.x == pointB.x && pointA.y == pointB.y);
	}
	//    -----------------------------------    
	//    Following method checks whether given two line intersect or not
	//    -----------------------------------    
	private bool isLinesIntersect (myLine L1, myLine L2)
	{
		if (checkPoints (L1.StartPoint, L2.StartPoint) ||
			checkPoints (L1.StartPoint, L2.EndPoint) ||
			checkPoints (L1.EndPoint, L2.StartPoint) ||
			checkPoints (L1.EndPoint, L2.EndPoint))
			return false;

		return((Mathf.Max (L1.StartPoint.x, L1.EndPoint.x) >= Mathf.Min (L2.StartPoint.x, L2.EndPoint.x)) &&
			(Mathf.Max (L2.StartPoint.x, L2.EndPoint.x) >= Mathf.Min (L1.StartPoint.x, L1.EndPoint.x)) &&
			(Mathf.Max (L1.StartPoint.y, L1.EndPoint.y) >= Mathf.Min (L2.StartPoint.y, L2.EndPoint.y)) &&
			(Mathf.Max (L2.StartPoint.y, L2.EndPoint.y) >= Mathf.Min (L1.StartPoint.y, L1.EndPoint.y)) 
		);
	}
		






	private void Add()
	{
		if (master.outlinemoveaway) {
			Off ();
			return;
		}


		if (pointsList.Count>20)
			pointsList.RemoveAt (0);


		if (Mathf.Abs (tempPos.x - GameObject.Find (gameObject.name).transform.position.x) < .05f) {
			if (Mathf.Abs (tempPos.z - GameObject.Find (gameObject.name).transform.position.z) < .05f)
				return;
		}

		if (GameObject.Find (gameObject.name).transform.position.z > 1.01f)
			return;
		if (GameObject.Find (gameObject.name).transform.position.x > 2.41f)
			return;

		Tracker ();


		int j = 0;
		List<Vector3> tempPoints = new List<Vector3> ();

		if (pointsList != null) {
			for (j = 0; j < pointsList.Count; j++)
				tempPoints.Add (pointsList [j]);

		}
		tempPos = new Vector3 (GameObject.Find (gameObject.name).transform.position.x, 40, GameObject.Find (gameObject.name).transform.position.z);
		tempPoints.Add (tempPos);
		pointsList = new List<Vector3> ();
		pointsList = tempPoints;

	}

	void Tracker()
	{


		tempposition1 = GameObject.Find (gameObject.name).transform.position;
		tempposition1.y += 40;

		switch (master.levelcounter) {
		case 1:
			switch (whoami) {
			case "1":
				roach1tracker.transform.position = tempposition1;
				break;
			}
		break;

		case 2:
			switch (whoami) {
			case "2":
				if (gameObject.tag == "Finish")
					roach1tracker.transform.position = tempposition1;
				else
					roach1tracker.transform.position = trackeroffposition;
				
				break;

			case "3":
				if (gameObject.tag == "Finish")
				roach2tracker.transform.position = tempposition1;
				else roach2tracker.transform.position = trackeroffposition;

				break;
			}
			break;

		case 3:
			switch (whoami) {
			case "4":
				roach1tracker.transform.position = tempposition1;
				break;

			case "5":
				roach2tracker.transform.position = tempposition1;
				break;

			case "6":
				roach3tracker.transform.position = tempposition1;
				break;
			}
			break;

		case 4:
			switch (whoami) {
			case "7":
				roach1tracker.transform.position = tempposition1;
				break;

			case "8":
				roach2tracker.transform.position = tempposition1;
				break;

			case "9":
				roach3tracker.transform.position = tempposition1;
				break;

			case "10":
				roach4tracker.transform.position = tempposition1;
				break;
			}
			break;

		case 5:
			switch (whoami) {
			case "11":
				roach1tracker.transform.position = tempposition1;
				break;

			case "12":
				roach2tracker.transform.position = tempposition1;
				break;

			case "13":
				roach3tracker.transform.position = tempposition1;
				break;

			case "14":
				roach4tracker.transform.position = tempposition1;
				break;
			}
			break;

		case 6:
			switch (whoami) {
			case "15":
				roach1tracker.transform.position = tempposition1;
				break;

			case "16":
				roach2tracker.transform.position = tempposition1;
				break;

			case "17":
				roach3tracker.transform.position = tempposition1;
				break;

			case "18":
				roach4tracker.transform.position = tempposition1;
				break;

			case "19":
				roach5tracker.transform.position = tempposition1;
				break;
			}
			break;

		case 7:
			switch (whoami) {
			case "20":
				roach1tracker.transform.position = tempposition1;
				break;

			case "21":
				roach2tracker.transform.position = tempposition1;
				break;

			case "22":
				roach3tracker.transform.position = tempposition1;
				break;

			case "23":
				roach4tracker.transform.position = tempposition1;
				break;

			case "24":
				roach5tracker.transform.position = tempposition1;
				break;

			case "25":
				roach6tracker.transform.position = tempposition1;
				break;
			}
			break;

		case 8:
			switch (whoami) {
			case "26":
				Debug.Log ("I AM HGERE");
				roach1tracker.transform.position = tempposition1;
				break;

			}
			break;

		


		}
	//	roach1tracker.transform.position = tempposition1;




	}

	void Off(){
		moveaway = true;



	}

void Moveawayreset()
{
	moveaway=false;

}

}