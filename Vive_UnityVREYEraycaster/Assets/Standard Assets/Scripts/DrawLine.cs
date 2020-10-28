using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawLine : MonoBehaviour 
{
	public LineRenderer line;
	private bool isMousePressed;
	public List<Vector3> pointsList;
	private Vector3 mousePos;
	public Color color1;
	public Color color2;
	public bool off;
	private Vector3 tempposition1;
	private Vector3 tempposition2;
	public Material LineMaterial;
	public GameObject fpstracker;
	public GameObject startcubetracker;
	private float timeCount;
	private bool on;
	public Vector3 tempPos;
	public MasterControls master;
	private bool started;
	private Vector3 trackeroffposition;


	// Structure for line points
	struct myLine
	{
		public Vector3 StartPoint;
		public Vector3 EndPoint;

	};
	//    -----------------------------------    
	void Awake()
	{
		//color1 = new Color (1, 0,0, 0.5f);
		//color2 = new Color (0, 1, 0, .5f);
		// Create line renderer component and set its property
		//line = gameObject.AddComponent<LineRenderer>();

		InvokeRepeating ("Startcube", 0, .1f);
		trackeroffposition = new Vector3 (.59f, 39f, 4f);
		line.material =  new Material(Shader.Find("Particles/Additive"));
		line.SetVertexCount(0);
		line.SetWidth(0.01f,0.01f);
		line.SetColors(Color.green, Color.red);
		line.useWorldSpace = true;    
		isMousePressed = false;
		pointsList = new List<Vector3>();
		//isMousePressed = true;
		line.SetVertexCount(0);
		pointsList.RemoveRange(0,pointsList.Count);
		//InvokeRepeating ("Measure", .1f, .1f);
		//InvokeRepeating ("Remove", 10f, .1f);


		//        renderer.material.SetTextureOffset(
	}
	//    -----------------------------------    
	void Update () 
	{
		// If mouse button down, remove old line and set its color to green




		if (master.readytostart && !started) {
			started = true;
			InvokeRepeating ("Add", 0f, .1f);
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


	public void Reset()
	{
		off = true;
		//isMousePressed = true;
		pointsList.RemoveRange(0,pointsList.Count);
		line.SetVertexCount (0);


	}

	public void Restart()
	{
		off = false;
		pointsList = new List<Vector3>();
		//isMousePressed = true;



	}





	private void Add()
	{

		if (master.pattern) {

				pointsList.Clear ();
				line.SetVertexCount (0);
				fpstracker.transform.position = trackeroffposition;

		}


		if (pointsList.Count>100)
			pointsList.RemoveAt (0);

		if (master.setupplayer==false){
		if (Mathf.Abs (tempPos.x - GameObject.Find ("FPSController (head)").transform.position.x) < .05f) {
			if (Mathf.Abs (tempPos.z - GameObject.Find ("FPSController (head)").transform.position.z) < .05f)
				return;
		}
		}

		if (GameObject.Find ("FPSController (head)").transform.position.z > 1.01f)
			return;
		if (GameObject.Find ("FPSController (head)").transform.position.x > 2.41f)
			return;


		if (master.pattern)
			return;

		tempposition1 = GameObject.Find ("FPSController (head)").transform.position;
		tempposition1.y += 40;
		fpstracker.transform.position = tempposition1;



		int j = 0;
		List<Vector3> tempPoints = new List<Vector3> ();

		if (pointsList != null) {
			for (j = 0; j < pointsList.Count; j++)
				tempPoints.Add (pointsList [j]);

		}
		tempPos = new Vector3 (GameObject.Find ("FPSController (head)").transform.position.x, 40, GameObject.Find ("FPSController (head)").transform.position.z);
		tempPoints.Add (tempPos);
		pointsList = new List<Vector3> ();
		pointsList = tempPoints;

	}

	void Startcube()
	{

		tempposition2 = GameObject.Find ("Start_cube2").transform.position;
		tempposition2.y += 37;
		startcubetracker.transform.position = tempposition2;
	}


}