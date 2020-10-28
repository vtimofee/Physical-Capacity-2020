using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using UnityStandardAssets;
using UnityEngine.UI;


public class MasterControls : MonoBehaviour {
	private Vector3 outlineonposition;
	private Vector3 outlineoffposition;
	private Vector3 outlineoff2position;

	// Use this for initialization
	private bool holdoff;
	public CameraPosition cameraposition;
	public bool gamestart;
	public Material cockroachskybox;
	public Material cockroachskybox2;

	private float exposure = .62f;
	public GameObject fourwalls;
	private Vector3 fourwallsstartposition;
	private Vector3 fourwallstargetposition;
	private float fourwallsy;
	private float ambientintensity=0f;
	private float targetambientintensity=2f;
	public GameObject sphere;
	public GameObject sphere2;
	public GameObject sphere3;
	public bool onstartcube;
	private Vector3 startcubestartposition;

	private float spherey;
	private float sphereytarget;
	private Vector3 sphereposition;
	public Light spotlight;
	private float spotangle;
	public CanvasGroup arrows;
	private float arrowtransparencytarget=0;
	private float arrowtransparency;


	private Vector3 level2wall1targetposition;
	private Vector3 level2wall2targetposition;
	private Vector3 level2wall1startposition;
	private Vector3 level2wall2startposition;

	private Vector3 level3wall3startposition;
	private Vector3 level3wall4startposition;
	private Vector3 level3wall3targetposition;
	private Vector3 level3wall4targetposition;
	private Vector3 level4wall5targetposition;
	private Vector3 level4wall6targetposition;
	private Vector3 level4wall5startposition;
	private Vector3 level4wall6startposition;
	private Vector3 level4wall7targetposition;

	private Vector3 wall7startposition;
	private Vector3 wall7targetposition;
	private Vector3 wall8startposition;
	private Vector3 wall8targetposition;
	private Vector3 wall9startposition;
	private Vector3 wall9targetposition;
	private Vector3 wall10startposition;
	private Vector3 wall10targetposition;




	private Vector3 storageposition;


	public Camera ccamera;

	public Material roachnumber;
	public Texture2D roachnumber0;
	public Texture2D roachnumber1;
	public Texture2D roachnumber2;
	public Texture2D roachnumber3;
	public Texture2D roachnumber4;
	public Texture2D roachnumber5;
	public Texture2D roachnumber6;
	public Texture2D roachnumber7;
	public Texture2D roachnumber8;
	public Texture2D roachnumber9;
	public Material levelnumber;


	public  int roachcounter;
	public int levelcounter;

	public Transform walltest1;
	private float distancebetween;
	public Vector3 headrotation;

	public bool on;
	//public Camera ccamera;
	public Image reticle;
	public Sprite reticleon;
	public Sprite reticleoff;
	public Sprite reticleblank;

	public string currentroach;
	public Image snakesprite1;
	public Image snakesprite2;
	private Color colorstorage1;
	private Color colorstorage2;


	private float colornumber = 10f;
	private float colornumber2=10f;

	private bool setupover;

	public Text levelcountertext;
	public Text levelcountertext2;
	public Text levelcountertext3;
	public Text levelcountertext4;
	public Text levelcountertext5;


	public Text roachcountertext;

	private int currentroachint;

	private bool levelchange1to2;
	private bool levelchange2to3;
	private bool levelchange3to4;
	private bool levelchange4to5;
	private bool levelchange5to6;
	private bool levelchange6to7;
	private bool levelchange7to8;



	private bool levelswitchinprogress;

	private bool readylevel1;

	public Material blue;
	public Material red;
	public Material green;
	public Material yellow;
	public Material brown;
	public Material cyan;
	public Material blank;
	public Material orange;
	public Material magenta;
	public Material white;

	public GameObject P1;
	public GameObject P2;
	public GameObject P3;
	public GameObject P4;
	public GameObject P5;
	public GameObject P6;
	public GameObject P7;
	public GameObject P8;
	public GameObject P0;



	private Color ccolor;

	private float patterntimer=3f;

	private bool pattern1on;
	private bool pattern2on;
	private bool pattern3on;
	private bool pattern4on;
	private bool pattern5on;
	private bool pattern6on;
	private bool pattern7on;
	private bool pattern8on;



	private bool pattern2_00on;

	private bool pattern2_0on;
	private bool pattern2_1on;
	private bool pattern2_2on;
	private bool pattern2_3on;
	private bool pattern3_00on;

	private bool pattern3_0on;
	private bool pattern3_1on;
	private bool pattern3_2on;
	private bool pattern3_3on;
	private bool pattern3_4on;
	private bool pattern4_0on;

	private bool pattern4_1on;
	private bool pattern4_2on;
	private bool pattern4_3on;
	private bool pattern4_4on;
	private bool pattern4_5on;
	private bool pattern5_0on;
	private bool pattern5_1on;
	private bool pattern5_2on;
	private bool pattern5_3on;
	private bool pattern5_4on;
	private bool pattern5_5on;
	private bool pattern6_0on;
	private bool pattern6_1on;
	private bool pattern6_2on;
	private bool pattern6_3on;
	private bool pattern6_4on;
	private bool pattern6_5on;
	private bool pattern6_6on;

	private bool pattern7_0on;
	private bool pattern7_1on;
	private bool pattern7_2on;
	private bool pattern7_3on;
	private bool pattern7_4on;
	private bool pattern7_5on;
	private bool pattern7_6on;
	private bool pattern7_7on;


	private bool pattern8_0on;
	private bool pattern8_1on;
	private bool pattern8_2on;
	private bool pattern8_3on;
	private bool pattern8_4on;
	private bool pattern8_5on;

	private int materialcounter;


	private bool patternreticle;

	private bool pattern2done;

	private bool pattern2turningoff;
	private bool pattern3turningoff;
	private bool pattern4turningoff;
	private bool pattern5turningoff;
	private bool pattern6turningoff;
	private bool pattern7turningoff;
	private bool pattern8turningoff;


	private bool patterntrigger;
	private bool pattern2oninprogress;
	private bool pattern3oninprogress;


	private Vector3 p1offposition;
	private Vector3 p1onposition;


	private Vector3 p0offposition;
	private Vector3 p0onposition;


	private Vector3 p2offposition;
	private Vector3 p2onposition;
	private Vector3 p3offposition;
	private Vector3 p3onposition;
	private Vector3 p4offposition;
	private Vector3 p4onposition;
	private Vector3 p5offposition;
	private Vector3 p5onposition;
	private Vector3 p6offposition;
	private Vector3 p6onposition;
	private Vector3 p7offposition;
	private Vector3 p7onposition;

	private float alphafull;
	private float alphazero;
	private float currentalpha0 = 1;
	private float currentalpha;
	private float currentalpha2;
	private float currentalpha3;
	private float currentalpha4;
	private float currentalpha5;
	private float currentalpha6;
	private float currentalpha7;
	private float currentalpha8;
	private float currentalpha9;
	private float currentalpha10;
	private float currentalpha11;
	private float currentalpha12;
	private float currentalpha13=1f;


	private bool end;



	private int score;
	public Text clock;
	private string clockstring;

	private float patterntimerthreshold;
	private float patterntimerthreshold_2=4;
	private float patterntimerthreshold_3=5; 
	private float patterntimerthreshold_4=6;
	private float patterntimerthreshold_5=6;
	private float patterntimerthreshold_6=7;
	private float patterntimerthreshold_7=8;
	private float patterntimerthreshold_8=5;





	public bool start0;

	private Vector3 sphereposition1;
	private Vector3 sphereposition2;
	private Vector3 sphereposition3;

	public bool pattern;
	public CockroachParent cockroachparent;



	private float alpha_s1;
	private float alpha_s2;
	private float alpha_s3;
	private float alpha_s4;

	private bool on_trigger;
	private bool off_trigger;

	private bool reset_0;

	private bool reset_1;
	private bool reset_2;
	private bool reset_3;
	private bool reset_4;
	private bool reset_5;
	private bool reset_6;
	private bool reset_7;

	private bool forcedprogress;


	private int patterndeaths;

	private float alphacut = .5f;
	//private float alphacut = 1f;

	private float alphacut0 = .3f;
	//private float alphacutfinal = .03f;
	private float alphacutfinal = .05f;



	public Material floormaterial;
	private float scalex;
	private float scaley;

	public Material wallmaterial;
	private float wallscalex;
	private float wallscaley;

	public Transform st_target;
	private float st_speed=70;
	private float st_rotationspeed=1f;
	private float st_range1=4f;
	private float st_range2 = 10;
	public Transform st_transform;
	private float st_stop=.1f;

	public Transform spheretargetlook;


	//public Transform roachprefab;

	private float distanceWanted = 2f;
	private Vector3 diff;

	private float distanceWanted2 = .2f;
	private Vector3 diff2;

	private float distanceWanted3 = .4f;
	private Vector3 diff3;

	private Color coloryellow;
	private Color colorred;
	private Color colorblue;
	private Color colorgreen;

	private float fadered;

	public AudioClip sound1;
	public AudioClip sound2;
	public AudioClip sound3;
	public AudioClip sound4;
	public AudioClip sound5;
	public AudioClip sound6;
	public AudioClip sound7;

	public AudioSource dotsound;

	public AudioSource soundtogether;
	public AudioClip soundall;
	private bool alltogether;

	private Color currentcolor;
	private Color tempcolor1;
	private Color tempcolor2;
	private Color tempcolor3;
	private Color tempcolor4;
	private Color tempcolor5;
	private Color tempcolor6;



	private bool gazeontrigger;
	private bool gazeofftrigger;
	private bool gazeonreset;
	private bool gazeoffreset;

	private float spotlight_targetintensity1 = 2.81f;

	private float tempvolume1;
	private float tempvolume2;
	private float tempvolume3;
	private float tempvolume4;
	private float tempvolume5;
	private float tempvolume6;




	public GameObject cieling;
	private Vector3 cielingposition1;
	private Vector3 cielingposition2;
	private Vector3 cielingposition3;
	private Vector3 cielingposition4;
	private Vector3 cielingposition5;
	private Vector3 cielingposition6;
	private Vector3 cielingposition7;
	private Vector3 cielingposition8;






	private bool fullcolordelay;
	private bool fullcolorfade;

	private bool cracking;
	private float crackingthresholdsmall=2;
	private float crackingthresholdmedium=2;
	private int crackingdirection=0;

	private Color Colorbrown;

	public GameObject floor;
	public GameObject floor2;

	private Vector3 flooronposition;
	private Vector3 flooroffposition;

	private Vector3 floor2onposition;
	private Vector3 floor2offposition;

	private Vector3 floordownposition;
	private Vector3 tempposition1;
	public GameObject redsphere;

	public GameObject FPSLine;
	public GameObject Roach1Line;

	public Text fpspointcountertext;
	private int fpspointcounter;
	public Text roach1pointcountertext;
	private int roach1pointcounter;

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4_borders;
	public GameObject level4_floor;
	public GameObject level8;



	private Vector3 level1startposition;
	private Vector3 level1offposition;
	private Vector3 level1targetposition;
	private Vector3 level2startposition;
	private Vector3 level2offposition;
	private Vector3 level2targetposition;
	public Vector3 level3offposition;
	public Vector3 level3startposition;
	public Vector3 level4offposition;
	public Vector3 level4startposition;
	public Vector3 level5offposition;
	public Vector3 level5startposition;
	public Vector3 level6offposition;
	public Vector3 level6startposition;
	public Vector3 level6targetposition;
	public Vector3 level7offposition;
	public Vector3 level7startposition;
	public Vector3 level7targetposition;

	private Vector3 level6_flooroffposition;
	private Vector3 level7_flooroffposition;
	private Vector3 level7_floortargetposition;
	private Vector3 level7_bordersoffposition;
	private Vector3 level7_borderstargetposition;

	private Vector3 level6_floortargetposition;
	private Vector3 level6_borderstargetposition;
	//private Vector3 level7_borderstargetposition;







	public ParticleSystem expl1;
	public ParticleSystem expl2;
	public ParticleSystem expl3;
	public ParticleSystem expl4;
	public ParticleSystem expl5;
	public ParticleSystem expl6;

	public ParticleSystem levelxpl1;
	public GameObject levelxpl1_light;
	public ParticleSystem levelxpl2;
	public GameObject levelxpl2_light;
	public ParticleSystem levelxpl3;
	public GameObject levelxpl3_light;
	public ParticleSystem levelxpl4;
	public GameObject levelxpl4_light;
	public ParticleSystem levelxpl5;
	public GameObject levelxpl5_light;
	public ParticleSystem levelxpl6;
	public GameObject levelxpl6_light;

	public ParticleSystem level7_xpl2;
	public GameObject level7_xpl2_light;
	public AudioSource level7_xpl2_sound1;

	public ParticleSystem level7_xpl1;
	public GameObject level7_xpl1_light;
	public AudioSource level7_xpl1_sound1;




	public int levelxplcounter;
	private bool levelxplshake;



	public AudioSource explsound;

	public AudioSource expl1sound;
	public AudioSource expl2sound;
	public AudioSource expl3sound;
	public AudioSource expl4sound;
	public AudioSource expl5sound;
	public AudioSource expl6sound;

	public AudioSource levelxpl_sound1;
	public AudioSource levelxpl_sound2;
	public AudioSource levelxpl_sound3;
	public AudioSource levelxpl_sound4;
	public AudioSource levelxpl_sound5;
	public AudioSource levelxpl_sound6;




	public bool roachexplode;
	public GameObject grid;
	private Vector3 gridonposition;
	private Vector3 gridoffposition;
	public bool readytostart;
	public GameObject structure;
	private Vector3 structureonposition;
	private Vector3 structureoffposition;
	private string headunderwater;
	public Text warningtext;
	private Vector3 cielingoffposition;
	private bool abovegrid;
	private bool fromabovetobelowgrid;
	public CanvasGroup scorecanvas;

	private float leveltimer=10;
	public float roachdrop;
	public AudioSource wallsound;
	public bool roachplant;

	private int level4direction;
	private Vector3 tempposition4;
	public GameObject wall1;

	public AudioSource roomsound;

	private bool dddebug=false;


	public Camera hudcamera;
	public AudioSource noisesound;
	private Vector3 currentcielingposition;
	private float currentcielingthreshold;

	public GameObject level5_floor;
	public GameObject level5_borders;
	public GameObject level6_floor;
	public GameObject level6_borders;
	public GameObject level7_floor;
	public GameObject level7_borders;

	private float spotlightrange1=1.7f;
	private float spotlightrange2=1.4f;
	private float spotlightrange3=1.2f;

	private float spotlightrange4=1.2f;
	private float spotlightrange5=1f;
	private float spotlightrange6=0f;
	private float spotlightrange7=1f;
	//private float spotlightrange8=.4f;
	private float spotlightrange8=.5f;



	private Color reticlecolor1;
	private Color reticlecolor2;
	public CanvasGroup reticlegroup;
	private bool headtouchtrigger;
	private float crackingthresholdmin=2f;
	private float levelxplthreshold=1;
	private float levelxpl_shakex=.07f;
	private float levelxpl_shakey=.07f;

	private int currentp;


	private Vector3 level7_xplposition1= new Vector3(.49f,-.005f,-1.552f);
	private Vector3 level7_xplposition2= new Vector3(.198f,-.005f,.53f);
	private Vector3 level7_xplposition3= new Vector3(1.802f,-.005f,-.477f);
	private Vector3 playerpos;
	private int quadrant;
	private float distance;

	public Transform bp1;
	public Transform bp2;
	public Transform bp3;
	public Transform bp4;


	public GameObject boss;
	private Quaternion bossrotation;
	public bool initialized;
	public GameObject startcube;
	private float athickness;
	public GameObject directlight;
	private float directlightx;
	public GameObject floor_start;
	private Vector3 floor_startonposition;
	private Vector3 tempposition10;

	private bool prestartover;
	private bool prestartgaze;
	private Vector3 startcubeoffposition;

	private float lerpsky;
	private Color colorsky1;
	private Color colorsky2 = Color.black;
	private float skyduration =1.0f;


	public Vector3 c1onposition=new Vector3(-23.843f,-81.357f,-95.244f);
	public Vector3 c2onposition=new Vector3(-22.909f,-81.357f,-95.244f);
	public Vector3 c3onposition=new Vector3(-24.995f,-81.357f,-94.67f);
	public Vector3 c4onposition=new Vector3(-23.54f,-81.357f,-95.36f);
	public Vector3 c5onposition=new Vector3(-24.941f,-81.357f,-95.386f);
	public Vector3 c6onposition=new Vector3(-22.605f,-81.357f,-94.793f);
	public Image downarrow;
	public Sprite downarrowsprite;

	public Material material1;
	public Material material2;
	public Material material3;
	public Material material4;
	public Material material5;
	public Material material6;

	public GameObject level2wall1;
	public GameObject level2lwall;
	public GameObject level2rwall;
	public GameObject level2fwall;
	public GameObject level2bwall;

	public GameObject level3wall1;	
	public GameObject level3wall2;
	public GameObject level3wall3;
	public GameObject level3wall4;
	public GameObject level3wall5;

	public GameObject level3lwall;
	public GameObject level3rwall;
	public GameObject level3fwall;
	public GameObject level3bwall;
	public GameObject level4lwall;
	public GameObject level4rwall;
	public GameObject level4fwall;
	public GameObject level4bwall;
	public GameObject level4floor1;
	public GameObject level4floor2;
	public GameObject level5lwall;
	public GameObject level5rwall;
	public GameObject level5fwall;
	public GameObject level5bwall;
	public GameObject level5floor1;
	public GameObject level5floor2;
	public GameObject level5floor3;
	public GameObject level5wall1;
	public GameObject level5wall2;
	public GameObject level5wall3;
	public GameObject level6lwall;
	public GameObject level6rwall;
	public GameObject level6fwall;
	public GameObject level6bwall;
	public GameObject level6floor;
	public GameObject level7lwall;
	public GameObject level7rwall;
	public GameObject level7fwall;
	public GameObject level7bwall;
	public GameObject level7wall1;
	public GameObject level7wall2;
	public GameObject level7wall3;
	public GameObject level7wall4;
	public GameObject level7wall5;
	public GameObject level7wall6;
	public GameObject level7wall7;
	public GameObject level7wall8;
	public GameObject level7wall9;

	public GameObject level7floor1;
	public GameObject level7floor2;

	public GameObject level8wall1;
	public GameObject level8wall2;
	public GameObject level8wall3;
	public GameObject level8wall4;



	private Quaternion bossr1;
	private Quaternion bossr2;
	private Quaternion bossr3;
	private Quaternion bossr4;

	private int[] pattern2;
	private int[] pattern3;
	private int[] pattern4;
	private int[] pattern5;
	private int[] pattern6;
	private int[] pattern7;


	public bool outlinemoveaway;
	public bool outlinemovein;




	public AudioSource materialswitch;
	public Camera abovecamera;
	public CameraSwitcher cameraswitcher;
	private Material currentmaterial;

	public int explosioncounter;

	private Vector3 tempposition20;
	public AudioClip room1sound;
	public AudioClip room2sound;
	public AudioClip room3sound;

	private float level1targetpitch=.8f;
	private float level2targetpitch=1f;
	private float level3targetpitch=1.2f;
	private float level4targetpitch=1.4f;
	private float level5targetpitch=1.6f;
	private float level6targetpitch=1.8f;
	private float level7targetpitch=2f;
	private float level8targetpitch=2.2f;

	private float level1targetv=.4f;
	private float level2targetv=.6f;
	private float level3targetv=.8f;
	private float level4targetv=1f;
	private float level5targetv=1.2f;
	private float level6targetv=1.4f;
	private float level7targetv=1.6f;
	private float level8targetv=.4f;
	public Light startpointlight;

	private Vector3 bossoffposition;
	private Vector3 bossstartposition;

	private Animator bossanimator;
	private bool proximity;
	public AudioSource bosssound;

	public Text scoretext;
	public Text scoretext2;
	public Text scoretext3;
	public Text scoretext4;
	public Text scoretext5;

	private string scorestring;
	private int scoreint;
	private int scorecount;

	private Vector3 level5_bordersstartposition;
	private Vector3 level6_bordersstartposition;
	private Vector3 level7_bordersstartposition;


	private float tttimeelapsed;
	public Text totaltimetext;
	public Text totaltimetext2;
	public Text totaltimetext3;
	public Text totaltimetext4;
	public Text totaltimetext5;


	public Camera trackcamera;

	public GameObject out_level1;
	public GameObject out_level2;
	public GameObject out_level3;
	public GameObject out_level4;
	public GameObject out_level5;
	public GameObject out_level6;
	public GameObject out_level7;
	public GameObject out_level8;


	public Sprite reticle_start;

	public Sprite reticle_start1;
	public Sprite reticle_start2;
	public Sprite reticle_start3;
	public Sprite reticle_start4;
	private bool gazestartcube;

	private float countdowntimer1;
	private float lengthoftime=60;






	public GameObject cockroach1;
	public GameObject cockroach2;
	public GameObject cockroach3;
	public GameObject cockroach4;
	public GameObject cockroach5;
	public GameObject cockroach6;
	public GameObject cockroach7;
	public GameObject cockroach8;
	public GameObject cockroach9;
	public GameObject cockroach10;
	public GameObject cockroach11;
	public GameObject cockroach12;
	public GameObject cockroach13;
	public GameObject cockroach14;
	public GameObject cockroach15;
	public GameObject cockroach16;
	public GameObject cockroach17;
	public GameObject cockroach18;
	public GameObject cockroach19;
	public GameObject cockroach20;
	public GameObject cockroach21;
	public GameObject cockroach22;
	public GameObject cockroach23;
	public GameObject cockroach24;
	public GameObject cockroach25;
	public GameObject cockroach26;
	public GameObject floor_rest;

	public float level7dreamint1=7;
	public float level7dreamint2=8;



	public Camera hudcamera_th;
	public Camera ccamera_th;

	private bool endstarted;

	private Vector3 idleposition;
	private Quaternion idlerotation;


	private float idlethreshhold;
	public bool setupplayer;

	private float awaymove=.3f;


	//DEFINE
	void Start () {

		//outlinemoveaway = true;

		level6offposition = new Vector3 (-5, -20, -1);
		countdowntimer1 = lengthoftime;
		outlineonposition = new Vector3 (.634f, 39.6f, -.505f);
		outlineoffposition = new Vector3 (.634f, 39.6f, 7.07f);
		outlineoff2position = new Vector3 (.634f,39.6f, -6.07f);
		//outlineoff2position = new Vector3 (.634f, 41, 7.07f);



		level5_bordersstartposition = new Vector3 (.72f, -1.94f, -.886f);
		level6_bordersstartposition = new Vector3 (-5.62f,-2,-1.17f);
		level7_bordersstartposition = new Vector3 (-5.012f,-4,-1.19f);


		startcubestartposition = startcube.transform.position;
		floor_startonposition = floor_start.transform.position;
		bossanimator = GameObject.Find ("26").GetComponent<Animator> ();
		bossoffposition=new Vector3(.46f,-4f,-.68938f);
		bossstartposition = new Vector3 (.46f, -.171f, -.68938f);

		boss.transform.position = bossoffposition;
		bossr1 = GameObject.Find ("Boss_rotation1").transform.rotation;
		bossr2 = GameObject.Find ("Boss_rotation2").transform.rotation;
		bossr3= GameObject.Find ("Boss_rotation3").transform.rotation;
		bossr4 = GameObject.Find ("Boss_rotation4").transform.rotation;

		spotlight.shadowNearPlane = 0;
		currentmaterial = material1;
		structureonposition = new Vector3 (0, 3.17f, .65f);
		structureoffposition = new Vector3 (0, -100f, .65f);
		structure.transform.position = structureoffposition;

		startcubeoffposition = new Vector3 (.63f, -20, 1.73f);
		bossrotation = GameObject.Find ("Boss_rotation4").transform.rotation;
		spotlight.transform.parent = GameObject.Find ("FPSController (head)").transform;

		reticlecolor1 = new Color (1, 1, 1, .5f);
		reticlecolor2 = new Color (0, 0, 0, .5f);
		reticle.color = reticlecolor1;

		InvokeRepeating ("BlackWhite", 0, .5f);
		cielingoffposition = new Vector3 (.7f, 40, -.4f);


		floordownposition = new Vector3 (0.7f, -2.466f, -.4f);

		//Colorbrown = new Color(.1f,1f,.1f,1f);
		Colorbrown = new Color(.66f,.294f,.294f,1f);



		GameObject.Find ("HUD (ears)").GetComponent<AudioListener> ().enabled = false;
		GameObject.Find ("AboveCamera (ears)").GetComponent<AudioListener> ().enabled = false;

		//Debug.Log ("tempcolor :" + tempcolor1);

		tempcolor1 = Color.white;
		tempcolor2 = Color.white;
		tempcolor3 = Color.white;
		tempcolor4 = Color.white;



		dotsound.volume = 0;
	//	dotsound.pitch = 0;



		coloryellow = Color.yellow;

		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;


		currentmaterial.SetTextureScale ("_MainTex", new Vector2 (2, 2));

		floormaterial.SetTextureScale ("_MainTex", new Vector2 (2, 2));
		wallmaterial.SetTextureScale ("_MainTex", new Vector2 (4, 4));



		red.SetFloat ("_Cutoff", 0);
		white.SetFloat ("_Cutoff", 0);

		/*p1onposition = new Vector3 (-5.34f, 2.96f, 16.97f);
		p1offposition = new Vector3 (-25f, 40f, 1f);

		p2onposition = new Vector3 (1.77f, 2.96f, 16.97f);
		p2offposition = new Vector3 (1.7f,40f, 16.97f);

		p3onposition = new Vector3 (7.45f, 2.96f, 16.97f);
		p3offposition = new Vector3 (27f, 40f, 16.97f);*/

		p1onposition = new Vector3 (-5.47f, 3.31f, 15.54f);
		p1offposition = new Vector3 (-5.47f, 3.31f,-1.14f);

		p0onposition = new Vector3 (2.2f,-7.4f,12.3f);
		p0offposition = new Vector3 (2,-500f,-100f);

		p2onposition = new Vector3 (9.68f, 3.31f, 15.54f);
		p2offposition = new Vector3 (9.68f,3.31f,-.13f);

		p3onposition = new Vector3 (-5.47f, -2.58f, 15.54f);
		p3offposition = new Vector3 (-5.47f, -2.58f, -.69f);

		p4onposition = new Vector3 (9.68f,-2.58f,15.54f);
		p4offposition = new Vector3 (9.68f,-2.58f,-.43f);

		p5onposition = new Vector3 (-5.47f,-8.5f,15.54f);
		p5offposition = new Vector3 (-5.47f,-8.5f,.75f);

		p6onposition = new Vector3 (9.68f,-8.5f,15.54f);
		p6offposition = new Vector3 (9.68f,-8.5f,.75f);

		p7onposition = new Vector3 (-5.47f,-8.45f,16.97f);
		p7offposition = new Vector3 (-5.47f,-8.45f,-2f);

		P0.transform.localPosition=p0offposition;
		P1.transform.localPosition=p1offposition;
		P2.transform.localPosition=p2offposition;
		P3.transform.localPosition=p3offposition;
		P4.transform.localPosition=p4offposition;
		P5.transform.localPosition=p5offposition;
		P6.transform.localPosition=p6offposition;
		P7.transform.localPosition=p7offposition;

		sphereposition1 = new Vector3 (.82f,1.66f,-.53f);
		sphereposition2 = new Vector3 (.82f,1.55f,-.53f);
		sphereposition3 = new Vector3 (.82f,1.51f,-.53f);

		floor2onposition=new Vector3(-.275f,-1.994f,-0.574f);

		floor2offposition=new Vector3(7.4f,-.3f,-.4f);
		flooroffposition = new Vector3(7.84f,-20.9f,-.4f);
		flooronposition = new Vector3(.65f,-.29f,-.4f);


		sphereytarget = 1.9f;
		storageposition = new Vector3 (20, 20, 20);

		//level2wall1.transform.position=storageposition;
		//level2wall2.transform.position=storageposition;

		levelcounter = 0;
		cockroachskybox.SetFloat("_AtmosphereThickness",exposure);

		//fourwallsstartposition = fourwalls.transform.position;
		//fourwallsstartposition.y = 1.84f;
		//fourwalls.transform.position = new Vector3 (fourwallsstartposition.x, fourwallsstartposition.y, fourwallsstartposition.z);

		//fourwallstargetposition = fourwallsstartposition;
		//fourwallstargetposition.y = 2.8f;

		//sphereposition = sphere.transform.position;
		spherey = sphereposition.y;
		//spotangle = spotlight.spotAngle;
		//InvokeRepeating ("Fadingarrows", 0, 2);

		level1startposition = new Vector3 (0.596f, -2f, -1.17f);
		level1targetposition = new Vector3 (0.596f, -1.226f, -1.17f);
		level6_floortargetposition = new Vector3 (.57f, -1.145f, -1.17f);
		level6targetposition = new Vector3 (-5, -1.153f, -1.17f);
		level7targetposition = new Vector3 (-5.013f, -1.488f, -1.124f);

		level1offposition = new Vector3 (0.596f, -10f, -1.17f);
		level2offposition = new Vector3 (0.596f, -12f, -1.17f);
		level3offposition = new Vector3 (0.596f, -14, -1.17f);
		level4offposition = new Vector3 (0.596f, -16, -1.17f);
		level5offposition = new Vector3 (0.596f, -18, -1.17f);

		level7_floortargetposition = new Vector3(.654f,-2.08f, -1.182f);
		level7_borderstargetposition = new Vector3(-5.012f,-1.486822f,-1.19f);
		level7_bordersstartposition = new Vector3(-5.012f,-3f,-1.19f);

		level6_flooroffposition = new Vector3 (0.596f, -10f, -1.17f);
		level7_flooroffposition = new Vector3 (0.596f, -12f, -1.17f);


		level1.transform.localPosition = level1startposition;
		level2.transform.localPosition = level1startposition;
		/*level3.transform.localPosition = level1startposition;
		level4_borders.transform.localPosition = level1startposition;
		level4_floor.transform.localPosition = level1startposition;
		level5_borders.transform.localPosition = level1startposition;
		level5_floor.transform.localPosition = level1startposition;
		level6_borders.transform.localPosition = level1startposition;
		level6_floor.transform.localPosition = level1startposition;*/


		//InvokeRepeating ("QuadrantCheck", 0, 2);
		red.SetFloat("_Cutoff",0);
		blue.SetFloat("_Cutoff",0);
		green.SetFloat("_Cutoff",0);
		yellow.SetFloat("_Cutoff",0);
		brown.SetFloat("_Cutoff",0);
		cyan.SetFloat("_Cutoff",0);
		magenta.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);

		cielingposition1 =  new Vector3 (.53f, .7f, -.4f);
		cielingposition2 = new Vector3 (.7f, .67f, -.4f);
		cielingposition3 = new Vector3 (.7f, .64f, -.4f);
		cielingposition3 = new Vector3 (.7f, .6f, -.4f);
		cielingposition4 = new Vector3 (.7f, .56f, -.4f);
		cielingposition5 = new Vector3 (.7f, .52f, -.4f);
		cielingposition6 = new Vector3 (.7f, .5f, -.4f);
		cielingposition7 = new Vector3 (.7f, .45f, -.4f);
		cielingposition8 = new Vector3 (.7f, .4f, -.4f);








		gridonposition = new Vector3 (0, .7f, 0);
		gridoffposition = new Vector3 (0, -10, 0);
		headunderwater = "PLEASE PUT HEAD UNDER GRID";
		pattern2 = new int[2];pattern2 [0] = 1;pattern2 [1] = 2;
		pattern3 = new int[3];pattern3 [0] = 1;pattern3 [1] = 2;pattern3 [2] = 3;
		pattern4 = new int[4];pattern4 [0] = 1;pattern4 [1] = 2;pattern4 [2] = 3;pattern4 [3] = 4;
		pattern5 = new int[4];pattern5 [0] = 4;pattern5 [1] = 3;pattern5 [2] = 2;pattern5 [3] = 1;
		pattern6 = new int[5];pattern6 [0] = 2;pattern6 [1] = 5;pattern6 [2] = 4;pattern6 [3] = 3;pattern6 [4] = 1;
		pattern7 = new int[6];pattern7 [0] = 6;pattern7 [1] = 3;pattern7 [2] = 2;pattern7 [3] = 5;pattern7 [4] = 1;pattern7 [5] = 4;





		
	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey("r")) {
		
			Application.LoadLevel(Application.loadedLevel);


		}

		if (Input.GetKey("escape")) {

			Application.Quit ();


		}
	//	Debug.Log ("countdowntimer : " + countdowntimer1);
		//Debug.Log ("dotsoundvolume :" + dotsound.volume + " dotsoundclip:" + dotsound.clip + "countdowntimer : " + countdowntimer1 + " pattern: " + pattern + " headtouch : " + cameraposition.headtouch);
		if (outlinemoveaway) {
		
			out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineoffposition, 2 * Time.deltaTime);
			out_level2.transform.position = Vector3.Lerp (out_level2.transform.position, outlineoffposition, 3 * Time.deltaTime);
			out_level3.transform.position = Vector3.Lerp (out_level3.transform.position, outlineoffposition, 1.5f * Time.deltaTime);
			out_level4.transform.position = Vector3.Lerp (out_level4.transform.position, outlineoffposition, 4 * Time.deltaTime);
			out_level5.transform.position = Vector3.Lerp (out_level5.transform.position, outlineoffposition, 2.5f * Time.deltaTime);
			out_level7.transform.position = Vector3.Lerp (out_level7.transform.position, outlineoffposition, 2 * Time.deltaTime);





		}

		if (outlinemovein) {

			out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineonposition, 2 * Time.deltaTime);
			out_level2.transform.position = Vector3.Lerp (out_level2.transform.position, outlineonposition, 3 * Time.deltaTime);
			out_level3.transform.position = Vector3.Lerp (out_level3.transform.position, outlineonposition, 1.5f * Time.deltaTime);
			out_level4.transform.position = Vector3.Lerp (out_level4.transform.position, outlineonposition, 4 * Time.deltaTime);
			out_level5.transform.position = Vector3.Lerp (out_level5.transform.position, outlineonposition, 2.5f * Time.deltaTime);
			out_level7.transform.position = Vector3.Lerp (out_level7.transform.position, outlineonposition, 2 * Time.deltaTime);





		}


		if (initialized) {
			
			if (!endstarted)tttimeelapsed += Time.deltaTime;
			scoretext.text = scoreint.ToString ();
			scoretext2.text = scoreint.ToString ();
			scoretext3.text = scoreint.ToString ();
			scoretext4.text = scoreint.ToString ();
			scoretext5.text = scoreint.ToString ();


			levelcountertext.text = levelcounter.ToString ();
			levelcountertext2.text = levelcounter.ToString ();
			levelcountertext3.text = levelcounter.ToString ();
			levelcountertext4.text = levelcounter.ToString ();
			levelcountertext5.text = levelcounter.ToString ();


			if (initialized) {
				totaltimetext.text = tttimeelapsed.ToString ("F2");
				totaltimetext2.text = tttimeelapsed.ToString ("F2");
				totaltimetext3.text = tttimeelapsed.ToString ("F2");
				totaltimetext4.text = tttimeelapsed.ToString ("F2");
				totaltimetext5.text = tttimeelapsed.ToString ("F2");

			}

		} else {
			scoretext.text = "";
			scoretext2.text = "";
			scoretext3.text = "";
			scoretext4.text = "";
			levelcountertext.text = "";
			levelcountertext2.text = "";
			levelcountertext3.text = "";
			levelcountertext4.text = "";
			totaltimetext.text =  "";
			totaltimetext2.text = "";
			totaltimetext3.text =  "";
			totaltimetext4.text = "";

		}




		//Debug.Log ("pattern1" + pattern1);


		if (!prestartgaze) {
		
			startcube.transform.LookAt (ccamera.transform);
			startcube.transform.RotateAround (ccamera.transform.position, Vector3.up, 7 * Time.deltaTime);
			if (athickness < 5.5f)
				athickness += 1 * Time.deltaTime;
			else
				athickness = 0;
			//RenderSettings.skybox.SetFloat ("_AtmosphereThickness", athickness);

			directlight.transform.Rotate (Vector3.up * 25 * Time.deltaTime, Space.World);


		}
		else if(prestartgaze && !initialized) {
			directlight.GetComponent<Light> ().enabled = false;

			RenderSettings.skybox = cockroachskybox2;
			//colorsky1 = cockroachskybox.GetColor ("_SkyTint");
			exposure = Mathf.Lerp (exposure, 0, 4 * Time.deltaTime);
			cockroachskybox.SetFloat("_AtmosphereThickness",0);
		//	lerpsky = Mathf.PingPong (Time.time, skyduration) / skyduration;
		
			structure.transform.position = structureonposition;
			spotlight.range = Mathf.Lerp (spotlight.range, spotlightrange1, 4 * Time.deltaTime);
			spotlight.enabled = false;
			structure.gameObject.layer = 0;
			floor.gameObject.layer = 0;
			cieling.gameObject.layer = 0;
			floor.transform.position = flooronposition;
			floor_start.transform.position = flooroffposition;




		}


			currentcielingposition = cieling.transform.position;
			currentcielingthreshold = currentcielingposition.y;
		if (!endstarted) {
			grid.transform.position = currentcielingposition;
		}




		if (cameraposition.headtouch && !holdoff) {
			Debug.Log ("HEADTOUCHERE!!!");
			if (headtouchtrigger)CancelInvoke ("Headtouchoff");
			headtouchtrigger = false;
			hudcamera.GetComponent<CameraFilterPack_Gradients_Therma>().enabled = true;
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake >().enabled = true;
			hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade = 1;
			hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch = 1;

			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 37.3f;
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .06f;
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .07f;

			hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma>().enabled = true;
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake >().enabled = true;
			hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade = 1;
			hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch = 1;

			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 37.3f;
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .06f;
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .07f;


			noisesound.volume = 1;
			if (!noisesound.isPlaying)noisesound.Play ();

		} else {
			if (!headtouchtrigger) {
				headtouchtrigger = true;
				Invoke ("Headtouchoff", 2);
				}
				//x and y to 0 , speed faster, fadfe figure out
			hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade=Mathf.Lerp(hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade,0,3*Time.deltaTime);
			hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch=Mathf.Lerp(hudcamera.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch,0,3*Time.deltaTime);
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = Mathf.Lerp (hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed, 0, 3 * Time.deltaTime);
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = Mathf.Lerp (hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X, 0, 3 * Time.deltaTime);
			hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = Mathf.Lerp (hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y, 0, 3 * Time.deltaTime);

			hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade=Mathf.Lerp(hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Fade,0,3*Time.deltaTime);
			hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch=Mathf.Lerp(hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma> ().Switch,0,3*Time.deltaTime);
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = Mathf.Lerp (hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed, 0, 3 * Time.deltaTime);
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = Mathf.Lerp (hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X, 0, 3 * Time.deltaTime);
			hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = Mathf.Lerp (hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y, 0, 3 * Time.deltaTime);
			noisesound.volume = Mathf.Lerp (noisesound.volume, 0, 3 * Time.deltaTime);

		}



		if (levelxplshake) {

			ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = Mathf.Lerp (ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed, 0, 8 * Time.deltaTime);
			ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = Mathf.Lerp (ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X, 0, 4f * Time.deltaTime);
			ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = Mathf.Lerp (ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y, 0, 4f * Time.deltaTime);

			ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = Mathf.Lerp (ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed, 0, 8 * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = Mathf.Lerp (ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X, 0, 4f * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = Mathf.Lerp (ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y, 0, 4f * Time.deltaTime);
		}




		fpspointcounter = FPSLine.GetComponent<DrawLine> ().pointsList.Count;
		fpspointcountertext.text = fpspointcounter.ToString ();

		roach1pointcounter = Roach1Line.GetComponent<DrawLineRoach> ().pointsList.Count;
		roach1pointcountertext.text = roach1pointcounter.ToString ();

	



		if (GameObject.Find ("FPSController (head)").transform.position.y < .8f && !readytostart && Time.time>1 && initialized) {
			readytostart = true;
		}
			


		if (GameObject.Find ("FPSController (head)").transform.position.y >= (currentcielingthreshold) && !abovegrid) {



			if (!prestartgaze && !initialized) {

				RenderSettings.skybox = cockroachskybox2;
				startcube.gameObject.layer = 15;
				P0.transform.position = p0offposition;
				floor_start.gameObject.layer = 15;
				directlight.GetComponent<Light> ().enabled = false;
				//downarrow.sprite = downarrowsprite;
				downarrow.enabled = true;
				currentalpha0 = 1;
				white.SetFloat ("_Cutoff", currentalpha0);

				ccamera.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness = 1;

			}

			AudioListener.pause = true;

			cameraswitcher.Turnon ();
			downarrow.enabled = true;
			ccamera.fieldOfView = 120;
			ccamera_th.fieldOfView = 120;
			fromabovetobelowgrid = false;
			grid.transform.position = gridonposition;
			abovegrid = true;

			//RenderSettings.skybox = cockroachskybox2;
			//directlight.GetComponent<Light> ().enabled = false;
			//ccamera.enabled = false;
			ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity = .379f;
			ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity = .379f;

			//if (!abovegrid)warningtext.text = headunderwater;
			grid.transform.position = gridonposition;
			//spotlight.enabled = false;
			//structure.transform.position = new Vector3 (0, 0, .65f);
			//cameraposition.headabove=true;
			reticle.sprite = reticleblank;
		//	scorecanvas.alpha = 0;



		} else if (!fromabovetobelowgrid && GameObject.Find("FPSController (head)").transform.position.y < currentcielingthreshold  ){
			

			if (!prestartgaze && !initialized) {

				RenderSettings.skybox = cockroachskybox;
				startcube.gameObject.layer = 0;
				floor_start.gameObject.layer = 0;
				directlight.GetComponent<Light> ().enabled = true;
				downarrow.enabled = false;


			} else {
				directlight.GetComponent<Light> ().enabled = false;
				RenderSettings.skybox = cockroachskybox;


			}

			AudioListener.pause = false;


			if (initialized)spotlight.enabled = true;

			cameraswitcher.Turnoff ();

			//RenderSettings.skybox = cockroachskybox;
			downarrow.enabled = false;
			//ccamera.enabled = true;
			scorecanvas.alpha = 1;
			fromabovetobelowgrid = true;
			//cameraposition.headabove=false;
			abovegrid = false;
			grid.transform.position = gridoffposition;
			if (!prestartgaze && !initialized)spotlight.enabled = true;
			//structure.transform.position = new Vector3 (0, 3.17f, .65f);
			//warningtext.text = "";


		}


		//Debug.Log ("leveltimer" + leveltimer);



		//EYEBALLS CAMEARS SPHERES

		diff = sphere.transform.position - spheretargetlook.transform.position;
		diff.y = spheretargetlook.transform.position.y-.1f;
		sphere.transform.position = Vector3.Lerp(sphere.transform.position,spheretargetlook.transform.position+diff.normalized * distanceWanted,.2f*Time.deltaTime);

		diff2 = sphere2.transform.position - spheretargetlook.transform.position;
		diff2.y = spheretargetlook.transform.position.y+.05f;
		sphere2.transform.position = Vector3.Lerp(sphere2.transform.position,spheretargetlook.transform.position+diff2.normalized * distanceWanted2,.7f*Time.deltaTime);

		diff3 = sphere3.transform.position - spheretargetlook.transform.position;
		diff3.y = spheretargetlook.transform.position.y+.01f;
		sphere3.transform.position = Vector3.Lerp(sphere3.transform.position,spheretargetlook.transform.position+diff3.normalized * distanceWanted3,1.5f*Time.deltaTime);



		int.TryParse(currentroach,out currentroachint);
		cockroachparent.levelcounter = levelcounter;

	



		if (pattern) {
			ccamera.fieldOfView=Mathf.Lerp(ccamera.fieldOfView,120,5f*Time.deltaTime);
			ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity = Mathf.Lerp (ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity, .379f, 5f * Time.deltaTime);
			ccamera_th.fieldOfView=Mathf.Lerp(ccamera_th.fieldOfView,120,5f*Time.deltaTime);
			ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity = Mathf.Lerp (ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity, .379f, 5f * Time.deltaTime);
		}

		if (spotlight.enabled == false || patternreticle || levelcounter==8 || !initialized) {
			
			reticle.sprite = reticleblank;
			//if (!abovegrid)cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingoffposition, 1 * Time.deltaTime);
		}
			



		if (readytostart && levelcounter == 0 ) {

				if (!start0) {
				start0 = true;
				spotlight.enabled = false;
				spotlight.intensity = 0;
				pattern1on = true;
				pattern = true;
				patternreticle = true;
				cameraposition.turnofftracking = true;
			}

			if (pattern1on) {

				level2.transform.localPosition = level1startposition;

				dotsound.clip = sound1;
				dotsound.volume = .5f;
				//dotsound.pitch = 1;
				if (!dotsound.isPlaying)dotsound.Play ();
				
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				patterntimer -= Time.deltaTime;
	
				if (patterntimer < 0) {
					
					patterntimer = patterntimerthreshold_2;
					readylevel1 = true;
					pattern1on = false;
					pattern = false;
					patternreticle = false;
					//cameraposition.readytostart = false;
					spotlight.enabled = true;
					//GameObject.Find ("1").transform.localPosition = c1onposition;

				}

			} 

		}




		if (readylevel1 && !setupover) 
		{

			if (!gamestart) 
			{
				wallsound.Play ();

				currentalpha = 1;
	
				levelcounter = 1;
				gamestart = true;
				Invoke ("StopSetup", 2);
				//P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 1);
				dotsound.volume = 0;
				//dotsound.pitch = 0;
				if (dotsound.isPlaying)dotsound.Stop ();



			}

			//Debug.Log ("gamestart" + gamestart);
			CancelInvoke ("Fadingarrows");

			spotlight.intensity = Mathf.Lerp (spotlight.intensity,spotlight_targetintensity1, 3 * Time.deltaTime);
			out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineonposition, 5 * Time.deltaTime);

			level1.transform.localPosition = Vector3.Lerp (level1.transform.localPosition, level1targetposition, 3f * Time.deltaTime);
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition1, 7f * Time.deltaTime);
			//fourwalls.transform.position = Vector3.Lerp (fourwalls.transform.position, fourwallstargetposition, 3f * Time.deltaTime);

			//spotangle = Mathf.Lerp (spotangle, 10, .5f * Time.deltaTime);
			//spotlight.spotAngle = spotangle;
			//sphere.transform.position = Vector3.Lerp (sphere.transform.position, sphereposition1, 1 * Time.deltaTime);
			//	red.color = Color.Lerp (red.color, redblankcolor, 3f * Time.deltaTime);
			P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 1.5f * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch, level1targetpitch, 2 *Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level1targetv, 2 *Time.deltaTime);





		}






		if (pattern2on) {

		//	Debug.Log ("pattern2on and patterntimer: " + patterntimer);
			level1.transform.localPosition = Vector3.Lerp (level1.transform.localPosition, level1startposition, 1.5f * Time.deltaTime);

			//cieling.transform.localPosition = Vector3.Lerp (cieling.transform.localPosition, cielingoffposition, 1.5f * Time.deltaTime);

			roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);
			//level2.transform.localPosition = level1startposition;

			

			if (pattern2_0on) {
				out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineoff2position, 5 * Time.deltaTime);

				level1.transform.localPosition = Vector3.Lerp (level1.transform.localPosition, level1offposition, 2f * Time.deltaTime);
				ccamera.GetComponent<BlurOptimized> ().blurSize = Mathf.Lerp (ccamera.GetComponent<BlurOptimized> ().blurSize, 0, 2 * Time.deltaTime);
				ccamera_th.GetComponent<BlurOptimized> ().blurSize = Mathf.Lerp (ccamera_th.GetComponent<BlurOptimized> ().blurSize, 0, 2 * Time.deltaTime);


				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 1 * Time.deltaTime);
				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}
			if (pattern2_1on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				spotlight.enabled = false;

			} else if (pattern2_2on) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 * Time.deltaTime);

				spotlight.enabled = true;

			} else if (pattern2_3on) {

				P1.transform.localPosition =p1offposition;
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 * Time.deltaTime);

				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;



			}

			if (!pattern2_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_3;
				pattern2on = false;
				pattern2turningoff = true;
				//readylevel2 = true;
				sphereytarget = 2.8f;




			}
		} else if (pattern2turningoff) {
			currentalpha2 = Mathf.Lerp (currentalpha2, 1, 5 * Time.deltaTime);
			currentalpha3 = Mathf.Lerp (currentalpha3, 1, 5 * Time.deltaTime);

			red.SetFloat("_Cutoff",currentalpha2);
			green.SetFloat("_Cutoff",currentalpha3);


		}




		if (pattern3on) {


			//level3.transform.localPosition = level1startposition;
			level2.transform.localPosition = Vector3.Lerp (level2.transform.localPosition, level1startposition, 1.5f * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);
			//cieling.transform.localPosition = Vector3.Lerp (cieling.transform.localPosition, cielingoffposition, 1.5f * Time.deltaTime);

			if (pattern3_0on) {
				out_level2.transform.position = Vector3.Lerp (out_level2.transform.position, outlineoff2position, 5 * Time.deltaTime);

				level2.transform.localPosition = level1offposition;

			//P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 2 * Time.deltaTime);
			//P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 2 * Time.deltaTime);

			dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
			spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}
			


			if (pattern3_1on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				spotlight.enabled = false;

			} else if (pattern3_2on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 * Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				spotlight.enabled = false;

			} else if (pattern3_3on) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 *Time.deltaTime);
				spotlight.enabled = true;

			}else if (pattern3_4on){
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 5 *Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern3_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_4;
				pattern3on = false;
				pattern3turningoff = true;
				//readylevel2 = true;

				spotlight.enabled = true;
				sphereytarget = 2.8f;



			}
		} else if (pattern3turningoff) {
			currentalpha4 = Mathf.Lerp (currentalpha4, 1, 1);
			currentalpha5 = Mathf.Lerp (currentalpha5, 1, 1);
			currentalpha6 = Mathf.Lerp (currentalpha6, 1, 1);


			red.SetFloat("_Cutoff",currentalpha4);
			green.SetFloat("_Cutoff",currentalpha5);
			blue.SetFloat("_Cutoff",currentalpha6);


		}




		if (pattern4on) {
			level3.transform.localPosition = Vector3.Lerp (level3.transform.localPosition, level1startposition, 2f * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);


			if (pattern4_0on) {
				out_level3.transform.position = Vector3.Lerp (out_level3.transform.position, outlineoff2position, 5 * Time.deltaTime);

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 2 * Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 2 * Time.deltaTime);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 2 * Time.deltaTime);
				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}



			if (pattern4_1on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				//spotlight.enabled = false;

			} else if (pattern4_2on) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 * Time.deltaTime);

				//spotlight.enabled = false;

			} else if (pattern4_3on) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 *Time.deltaTime);

				//spotlight.enabled = true;

			} else if (pattern4_4on) {
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 5 *Time.deltaTime);

				
			

			}
			else if (pattern4_5on) {

				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 5 *Time.deltaTime);

				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern4_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_5;
				pattern4on = false;
				pattern4turningoff = true;
				//readylevel2 = true;
				spotlight.enabled = true;
				//sphereytarget = 2.8f;



			}
		} else if (pattern4turningoff) {
			currentalpha7 = Mathf.Lerp (currentalpha7, 1, 1);
			currentalpha8 = Mathf.Lerp (currentalpha8, 1, 1);
			currentalpha9 = Mathf.Lerp (currentalpha9, 1, 1);
			currentalpha10 = Mathf.Lerp (currentalpha10, 1, 1);

			red.SetFloat("_Cutoff",currentalpha7);
			green.SetFloat("_Cutoff",currentalpha8);
			blue.SetFloat("_Cutoff",currentalpha9);
			yellow.SetFloat("_Cutoff",currentalpha10);

		}




		if (pattern5on) {

			if (pattern5_0on) {
				out_level4.transform.position = Vector3.Lerp (out_level4.transform.position, outlineoff2position, 5 * Time.deltaTime);


				level4_borders.transform.localPosition = Vector3.Lerp (level4_borders.transform.localPosition, level1startposition, 2f * Time.deltaTime);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 2 * Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 2 * Time.deltaTime);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 2 * Time.deltaTime);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 2 * Time.deltaTime);
				roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}



			if (pattern5_1on) {
				//spotlight.enabled = false;
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);

			} else if (pattern5_2on) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 5 *Time.deltaTime);

				//spotlight.enabled = false;

			} else if (pattern5_3on) {
				//spotlight.enabled = true;
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 5 *Time.deltaTime);


			} else if (pattern5_4on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 *Time.deltaTime);





			}
			else if (pattern5_5on) {

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 * Time.deltaTime);

				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern5_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_6;
				pattern5on = false;
				pattern5turningoff = true;
				//readylevel2 = true;
				spotlight.enabled = true;
				//sphereytarget = 2.8f;



			}
		} else if (pattern5turningoff) {
			currentalpha7 = Mathf.Lerp (currentalpha7, 1, 1);
			currentalpha8 = Mathf.Lerp (currentalpha8, 1, 1);
			currentalpha9 = Mathf.Lerp (currentalpha9, 1, 1);
			currentalpha10 = Mathf.Lerp (currentalpha10, 1, 1);

			red.SetFloat("_Cutoff",currentalpha7);
			green.SetFloat("_Cutoff",currentalpha8);
			blue.SetFloat("_Cutoff",currentalpha9);
			yellow.SetFloat("_Cutoff",currentalpha10);

		}




		if (pattern6on) {

			Debug.Log ("at pattern6on");

			if (pattern6_0on) {

				out_level5.transform.position = Vector3.Lerp (out_level5.transform.position, outlineoff2position, 5 * Time.deltaTime);

				Debug.Log ("at pattern6on");
				level5_borders.transform.localPosition = Vector3.Lerp (level5_borders.transform.localPosition, level5_bordersstartposition, 2f * Time.deltaTime);
				roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 2 * Time.deltaTime);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, 2 * Time.deltaTime);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 2 * Time.deltaTime);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 2 * Time.deltaTime);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 2 * Time.deltaTime);


				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}



			if (pattern6_1on) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				//spotlight.enabled = false;

			} else if (pattern6_2on) {
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5onposition, 1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 * Time.deltaTime);

				//spotlight.enabled = false;

			} else if (pattern6_3on) {
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, 5 * Time.deltaTime);

				//spotlight.enabled = true;

			} else if (pattern6_4on) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 5 *Time.deltaTime);

			} else if (pattern6_5on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 5 *Time.deltaTime);

			}

			


			else if (pattern6_6on) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 *Time.deltaTime);

				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern6_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_7;
				pattern6on = false;
				pattern6turningoff = true;
				//readylevel2 = true;
				spotlight.enabled = true;
				//sphereytarget = 2.8f;



			}
		} else if (pattern6turningoff) {
			currentalpha7 = Mathf.Lerp (currentalpha7, 1, 1);
			currentalpha8 = Mathf.Lerp (currentalpha8, 1, 1);
			currentalpha9 = Mathf.Lerp (currentalpha9, 1, 1);
			currentalpha10 = Mathf.Lerp (currentalpha10, 1, 1);
			currentalpha11 = Mathf.Lerp (currentalpha11, 1, 1);


			green.SetFloat("_Cutoff",currentalpha7);
			cyan.SetFloat("_Cutoff",currentalpha8);
			yellow.SetFloat("_Cutoff",currentalpha9);
			blue.SetFloat("_Cutoff",currentalpha10);
			red.SetFloat("_Cutoff",currentalpha11);


		}





		if (pattern7on) {


			if (pattern7_0on) {
				out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineoff2position, 5 * Time.deltaTime);

				level6_borders.transform.localPosition = Vector3.Lerp (level6_borders.transform.localPosition, level6_bordersstartposition, 2f * Time.deltaTime);
				roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);
				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}



			if (pattern7_1on) {

				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6onposition, 1);
				level6_floor.transform.position = level6_flooroffposition;


			} else if (pattern7_2on) {

				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6offposition, 5 * Time.deltaTime);


			} else if (pattern7_3on) {

				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 5 * Time.deltaTime);


			} else if (pattern7_4on) {

				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5onposition, 1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 5 *Time.deltaTime);

			
			} else if (pattern7_5on) {

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, 5 *Time.deltaTime);

			
			} else if (pattern7_6on) {

				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 *Time.deltaTime);

			}
			else if (pattern7_7on) {

				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 1);

				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern7_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				Debug.Log ("HERERERERERE OATTERBN TIMER <0");
				patterntimer = patterntimerthreshold_7;
				pattern7on = false;
				pattern7turningoff = true;
				//readylevel2 = true;
				spotlight.enabled = true;
				//sphereytarget = 2.8f;



			}
		} else if (pattern7turningoff) {

			
			currentalpha7 = Mathf.Lerp (currentalpha7, 1, 1);
			currentalpha8 = Mathf.Lerp (currentalpha8, 1, 1);
			currentalpha9 = Mathf.Lerp (currentalpha9, 1, 1);
			currentalpha10 = Mathf.Lerp (currentalpha10, 1, 1);
			currentalpha11 = Mathf.Lerp (currentalpha11, 1, 1);
			currentalpha12 =  Mathf.Lerp (currentalpha11, 1, 1);

			green.SetFloat("_Cutoff",currentalpha7);
			cyan.SetFloat("_Cutoff",currentalpha8);
			yellow.SetFloat("_Cutoff",currentalpha9);
			blue.SetFloat("_Cutoff",currentalpha10);
			red.SetFloat("_Cutoff",currentalpha11);
			magenta.SetFloat("_Cutoff",currentalpha12);

		}





		if (pattern8on) {


			if (pattern8_0on) {
				out_level7.transform.position = Vector3.Lerp (out_level7.transform.position, outlineoff2position, 5 * Time.deltaTime);


				roomsound.pitch = Mathf.Lerp (roomsound.pitch,0,2*Time.deltaTime);
				level7_borders.transform.localPosition = Vector3.Lerp (level7_borders.transform.localPosition, level7_bordersstartposition, 2f * Time.deltaTime);

			/*	P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 1);
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition,1);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 1);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6offposition, 5 * Time.deltaTime);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, 5 *Time.deltaTime);*/



				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, 0, 5 * Time.deltaTime);
			}



			if (pattern8_1on) {
				
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
			


				//spotlight.enabled = false;




			}
			else if (pattern8_2on) {
				
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 5 *Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity, spotlight_targetintensity1, 3 * Time.deltaTime);
				dotsound.volume = 0;

			}

			if (!pattern8_0on)patterntimer -= Time.deltaTime;

			if (patterntimer < 0) {
				patterntimer = patterntimerthreshold_8;
				pattern8on = false;
				pattern8turningoff = true;
				//readylevel2 = true;
				spotlight.enabled = true;
				//sphereytarget = 2.8f;



			}
		} else if (pattern8turningoff) {
			currentalpha7 = Mathf.Lerp (currentalpha7, 1, 1);
			currentalpha8 = Mathf.Lerp (currentalpha8, 1, 1);
			currentalpha9 = Mathf.Lerp (currentalpha9, 1, 1);
			currentalpha10 = Mathf.Lerp (currentalpha10, 1, 1);
			currentalpha11 = Mathf.Lerp (currentalpha11, 1, 1);
			currentalpha12 = Mathf.Lerp (currentalpha12, 1, 1);



			green.SetFloat("_Cutoff",currentalpha7);
			brown.SetFloat("_Cutoff",currentalpha8);
			magenta.SetFloat("_Cutoff",currentalpha9);
			blue.SetFloat("_Cutoff",currentalpha10);
			red.SetFloat("_Cutoff",1);
			magenta.SetFloat("_Cutoff",1);

		}






		//LEVELCOUNTER

		if (levelcounter == 0 && !holdoff) {

			if (reset_0) {

			//	P0.transform.localPosition = Vector3.Lerp (P0.transform.localPosition, p0offposition, .3f * Time.deltaTime);
				if (currentalpha0 > 0 && currentalpha0 < 1 )
					currentalpha0 += .9f * Time.deltaTime;
				white.SetFloat ("_Cutoff", currentalpha0);
			}

		}

		if (levelcounter == 1 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;
				cockroach1.tag = "dead";
				levelcounter = 1;
				Patternchange (2);
				pattern = true;
			//	currentalpha = 0;
			//	RoachVision (1, levelcounter);
			}

			
			/*	
			if (leveltimer > 0)
				leveltimer -= Time.deltaTime;
			else
			 {
				//leveltimer = 10;
				leveltimer=10;
				currentroach = "1";
				alphacut = 0;
				GameObject.Find (currentroach).tag = "";

				levelcounter = 1;
				Patternchange (2);
				pattern = true;

				//	int tempnum1 = Random.Range (1, 3);
				//if (tempnum1 == 1) {
				roachexplode = true;

				if (!expl1.isPlaying) {
					Invoke ("RoachExplodeReset", 2);
					expl1.Play ();
					//expl2.Play ();
					//expl3.Play ();
					//expl5.GetComponent<ExplosionsLightCurves> ().OnEnable ();
					explsound.Play ();
				}

			}*/



		
		}else if (levelcounter == 2 && !holdoff) {

			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			////Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach2.tag = "dead";
				cockroach3.tag = "dead";

				Patternchange (3);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}

			scalex = Mathf.Cos (Time.time) * .1f + 2;
			scaley = Mathf.Sin(Time.time) * .1f + 2;

			currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));


				
				if (reset_1) {

					P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
				}

			if (reset_2) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
				}


			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}



		}


		if (levelcounter == 3 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach4.tag = "dead";
				cockroach5.tag = "dead";
				cockroach6.tag = "dead";

				Patternchange (4);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}



			scalex = Mathf.Cos (Time.time) * .5f + 2;
			scaley = Mathf.Sin(Time.time) * .5f + 2;

			currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));

			if (reset_1 ) {

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}

			if (reset_2 ) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
			}

			if (reset_3 ) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, awaymove * Time.deltaTime);
			}

			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}


		}






		if (levelcounter == 4 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach7.tag = "dead";
				cockroach8.tag = "dead";
				cockroach9.tag = "dead";
				cockroach10.tag = "dead";

				Patternchange (5);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}




			scalex = Mathf.Cos (Time.time) * .7f + 2;
			scaley = Mathf.Sin(Time.time) * .7f + 2;

			currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));



			if (reset_1 ) {

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}

			if (reset_2 ) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
			}

			if (reset_3) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, awaymove* Time.deltaTime);
			}

		if (reset_4 ) {
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, awaymove * Time.deltaTime);
			}

			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}



		}

		if (levelcounter == 5 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach11.tag = "dead";
				cockroach12.tag = "dead";
				cockroach13.tag = "dead";
				cockroach14.tag = "dead";

				Patternchange (6);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}



			scalex = Mathf.Cos (Time.time) * .9f + 2;
			scaley = Mathf.Sin(Time.time) * .9f + 2;

			wallscalex = Mathf.Cos (Time.time) * .7f + 4;
			wallscaley = Mathf.Sin(Time.time) * .7f + 4;


			currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));




			if (reset_1) {

				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, awaymove * Time.deltaTime);
			}

			if (reset_2 ) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, awaymove * Time.deltaTime);
			}

			if (reset_3 ) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
			}

			if (reset_4 ) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}
			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}


		}



		if (levelcounter == 6 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);

			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach15.tag = "dead";
				cockroach16.tag = "dead";
				cockroach17.tag = "dead";
				cockroach18.tag = "dead";
				cockroach19.tag = "dead";

				Patternchange (7);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}


			//Debug.Log ("atLEVELCOUNTER6");


			scalex = Mathf.Cos (Time.time *1.5f) * 1f + 2;
			scaley = Mathf.Sin(Time.time * 1.5f) * 1f + 2;

			wallscalex = Mathf.Cos (Time.time) * 1.5f + 4;
			wallscaley = Mathf.Sin(Time.time) * 1.5f + 4;


		currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));




			if (reset_1 ) {

				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
			}

			if (reset_2) {
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, awaymove * Time.deltaTime);
			}

			if (reset_3 ) {
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, awaymove * Time.deltaTime);
			}

			if (reset_4) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, awaymove * Time.deltaTime);
			}
			if (reset_5 ) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}

			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}


		}


		if (levelcounter == 7 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);


			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach20.tag = "dead";
				cockroach21.tag = "dead";
				cockroach22.tag = "dead";
				cockroach23.tag = "dead";
				cockroach24.tag = "dead";
				cockroach25.tag = "dead";

				Patternchange (8);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}


			ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = level7dreamint1;
			ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = level7dreamint2;



			//Debug.Log ("atLEVELCOUNTER6");


			scalex = Mathf.Cos (Time.time *2.5f) * 1f + 2;
			scaley = Mathf.Sin(Time.time * 2.5f) * 1f + 2;

			wallscalex = Mathf.Cos (Time.time) * 2.5f + 4;
			wallscaley = Mathf.Sin(Time.time) * 2.5f + 4;


			currentmaterial.SetTextureScale ("_MainTex", new Vector2 (scalex, scaley));




			if (reset_1) {

				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6offposition, awaymove * Time.deltaTime);
			}

			if (reset_2) {
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, awaymove * Time.deltaTime);
			}

			if (reset_3 ) {
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, awaymove * Time.deltaTime);
			}

			if (reset_4) {
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, awaymove * Time.deltaTime);
			}
			if (reset_5 ) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}
			if (reset_6 ) {
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, awaymove * Time.deltaTime);
			}

			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);


			}




		}
		if (levelcounter == 8 && !holdoff) {


			if (!abovegrid)countdowntimer1 -= 1 * Time.deltaTime;
			//Debug.Log ("countdowntimer : " + countdowntimer1);


			if (countdowntimer1 <= 0) {
				forcedprogress = true;

				cockroach26.tag = "dead";
			

				Patternchange (9);
				pattern = true;
				//	currentalpha = 0;
				//	RoachVision (1, levelcounter);
			}




			if (currentalpha13<.5f && currentalpha13 >.1f)
			{
				bossanimator.SetInteger("Deathcounter",1);
			}
			else if (currentalpha13<.05f)
			{
				bossanimator.SetInteger("Deathcounter",2);

			}



			if (reset_1) {

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, awaymove * Time.deltaTime);
			}
				

			if (fullcolorfade) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 1 * Time.deltaTime);

				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 1 * Time.deltaTime);

			}
			//END3


			if (alltogether && !end) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 3 * Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 2.5f * Time.deltaTime);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 3f * Time.deltaTime);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 3 * Time.deltaTime);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5onposition, 2.7f * Time.deltaTime);
				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6onposition, 3 * Time.deltaTime);
				level8.transform.position = Vector3.Lerp (level8.transform.position, level1startposition, 3 * Time.deltaTime);
				cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingoffposition, 2 * Time.deltaTime);
				soundtogether.volume=Mathf.Lerp(soundtogether.volume,.6f, 3 * Time.deltaTime);
				out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineoff2position, 3 * Time.deltaTime);
			}
			else if (end) {
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 2 * Time.deltaTime);
				P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 2 * Time.deltaTime);
				P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 2 * Time.deltaTime);
				P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4offposition, 2 * Time.deltaTime);
				P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5offposition, 2 * Time.deltaTime);
				P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6offposition, 2 * Time.deltaTime);
				soundtogether.volume=Mathf.Lerp(soundtogether.volume,0, 3 * Time.deltaTime);
				dotsound.volume = Mathf.Lerp (dotsound.volume, 0, 3 * Time.deltaTime);
				spotlight.intensity = Mathf.Lerp (spotlight.intensity,0, 3 * Time.deltaTime);
				roomsound.volume = Mathf.Lerp (roomsound.volume, 0, 3 * Time.deltaTime);


			}



		}







			





		



		//LEVELCHANGE


		if (levelchange1to2 && levelswitchinprogress)
		{
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition2, 2f * Time.deltaTime);
			level2.transform.localPosition = Vector3.Lerp (level2.transform.localPosition, level1targetposition, 2f * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level2targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level2targetv, 2 *Time.deltaTime);
			out_level2.transform.position = Vector3.Lerp (out_level2.transform.position, outlineonposition, 5 * Time.deltaTime);




		}else if (levelchange2to3 && levelswitchinprogress)
		{
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition3, 2f * Time.deltaTime);
			level3.transform.localPosition = Vector3.Lerp (level3.transform.localPosition, level1targetposition, 2 * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level3targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level3targetv, 2 *Time.deltaTime);
			out_level3.transform.position = Vector3.Lerp (out_level3.transform.position, outlineonposition, 2 * Time.deltaTime);





		}else if (levelchange3to4 && levelswitchinprogress)
		{	level4_floor.transform.localPosition = level1targetposition;
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition4, 2f * Time.deltaTime);
			level4_borders.transform.localPosition = Vector3.Lerp (level4_borders.transform.localPosition, level1targetposition, 2 * Time.deltaTime);
			floor.transform.position = level1offposition;
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level4targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level4targetv, 2 *Time.deltaTime);
			out_level4.transform.position = Vector3.Lerp (out_level4.transform.position, outlineonposition, 2 * Time.deltaTime);


		}
		else if (levelchange4to5 && levelswitchinprogress)
		{	
		level5_floor.transform.localPosition = level1targetposition;
		cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition5, 2f * Time.deltaTime);
		level5_borders.transform.localPosition = Vector3.Lerp (level5_borders.transform.localPosition, level1targetposition, 2 * Time.deltaTime);
		floor.transform.position = Vector3.Lerp (floor.transform.position, level1offposition, 3f * Time.deltaTime);
		roomsound.pitch = Mathf.Lerp (roomsound.pitch,level5targetpitch,2*Time.deltaTime);
		roomsound.volume = Mathf.Lerp (roomsound.volume, level5targetv, 2 *Time.deltaTime);
			out_level5.transform.position = Vector3.Lerp (out_level5.transform.position, outlineonposition, 2 * Time.deltaTime);


		}
		else if (levelchange5to6 && levelswitchinprogress)
		{	

			level6_floor.transform.localPosition = level6_floortargetposition;
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition6, 2f * Time.deltaTime);
			level6_borders.transform.localPosition = Vector3.Lerp (level6_borders.transform.localPosition, level6targetposition, 2 * Time.deltaTime);
			floor.transform.position = Vector3.Lerp (floor.transform.position, level1offposition, 3f * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level6targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level6targetv, 2 *Time.deltaTime);
			out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineonposition, 2 * Time.deltaTime);


		}
		else if (levelchange6to7 && levelswitchinprogress)
		{	

			level7_floor.transform.localPosition = level7_floortargetposition;
			floor.transform.position = flooroffposition;
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition7, 2f * Time.deltaTime);
			level7_borders.transform.localPosition = Vector3.Lerp (level7_borders.transform.localPosition, level7_borderstargetposition, 2 * Time.deltaTime);
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level7targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level7targetv, 2 *Time.deltaTime);
			out_level7.transform.position = Vector3.Lerp (out_level7.transform.position, outlineonposition, 2 * Time.deltaTime);


		}

		else if (levelchange7to8 && levelswitchinprogress)
		{	

			floor.transform.position = flooronposition;
			cieling.transform.position = Vector3.Lerp (cieling.transform.position, cielingposition8, 2f * Time.deltaTime);
			level8.transform.localPosition = level1targetposition;
			level7_floor.transform.position = level7_flooroffposition;
			level7_borders.transform.position = level1offposition;
			level6_floor.transform.position = level6_flooroffposition;
			roomsound.pitch = Mathf.Lerp (roomsound.pitch,level8targetpitch,2*Time.deltaTime);
			roomsound.volume = Mathf.Lerp (roomsound.volume, level8targetv, 2 *Time.deltaTime);
			out_level1.transform.position = Vector3.Lerp (out_level1.transform.position, outlineonposition, 2 * Time.deltaTime);





		}











		//ONGAZE



		if (on && !patternreticle && !abovegrid) {




				//Debug.Log ("ON CALLL " + "_currentroach: " + currentroachint + "level : " + levelcounter + " gazeontrigger : " + gazeontrigger + " gazeonreset :" + gazeonreset + " gazeoffreset : " + gazeoffreset + " gazeofftrigger : " +gazeofftrigger);
			if (levelcounter == 8) {
				if (distance < .7f) {
					if (!dotsound.isPlaying)
						dotsound.Play ();
				}
			} else {
				if (!dotsound.isPlaying)
					dotsound.Play ();
			}

				

			if (fullcolorfade)
					fullcolorfade = false;

				if (!gazeonreset) {
					gazeonreset = true;
					gazeontrigger = true;
					gazeoffreset = false;
					//CancelInvoke ("BlackWhite");
				if (levelcounter != 8) {
					
						reticle.color = reticlecolor1;
						reticlegroup.alpha = .8f;

			


				}


					//InvokeRepeating ("BlackWhite", 0, .1f);

					//dotsound.volume = tempvolume1;
					//	Fade (dotsound.volume, tempvolume1);
					//Debug.Log ("!IF GAZE ON RESET " + " gazeontrigger : " + gazeontrigger + " gazeonreset :" + gazeonreset + " gazeoffreset : " + gazeoffreset + " gazeofftrigger : " +gazeofftrigger);


				}
				


				RoachVision (currentroachint, levelcounter);

				//ccamera.GetComponent<BlurOptimized>().enabled = true;
				//ccamera.GetComponent<BlurOptimized> ().blurSize += .5f * Time.deltaTime;

			if (levelcounter == 0) {

				if (ccamera.fieldOfView > 10){
					ccamera.fieldOfView -= 30 * Time.deltaTime;
					ccamera_th.fieldOfView -= 30 * Time.deltaTime;

				ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity += .15f * Time.deltaTime;
				ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity += .15f * Time.deltaTime;

				}

			}

		if (ccamera.fieldOfView > 50 && levelcounter != 8 && levelcounter!=0) {
					ccamera.fieldOfView -= 30 * Time.deltaTime;
					ccamera_th.fieldOfView -= 30 * Time.deltaTime;

					ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity += .15f * Time.deltaTime;
					ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity += .15f * Time.deltaTime;

				}

			if (levelcounter == 8 && distance<.5f) {


				if (ccamera.fieldOfView > 40) {
					ccamera.fieldOfView -= 5 * Time.deltaTime;
					ccamera_th.fieldOfView -= 10 * Time.deltaTime;

					//ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity += .01f * Time.deltaTime;
				}

			}



			if (levelcounter != 8) {

				if (levelcounter < 1) {
					if (!prestartgaze)reticle.sprite = reticle_start;
					else reticle.sprite = reticleblank;
				} else {
					reticle.sprite = reticleon;
					reticlegroup.alpha = .8f;
				}
			} else {
				reticle.sprite = reticleblank;
			}
			reticlegroup.alpha = .8f;

				//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;


		}
		else if (!on && !patternreticle && !abovegrid)  
	{

			//Debug.Log ("OFF CALLL " + "_currentroach: " + currentroachint + "level : " + levelcounter + " gazeontrigger : " + gazeontrigger + " gazeonreset :" + gazeonreset + " gazeoffreset : " + gazeoffreset + " gazeoffreset : " +gazeoffreset);
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 2 * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.white, 2 * Time.deltaTime);

			if (!gazeoffreset) {

				if (!fullcolordelay) { 
				//Thursday preopening edit	
				//Fadeout (0);
				dotsound.volume = 0;

				}
				//InvokeRepeating ("BlackWhite", 0, .5f);
				gazeofftrigger = true;
				gazeoffreset = true;
				gazeonreset = false;
				//dotsound.volume = 0;
			}

			//ccamera.GetComponent<BlurOptimized>().enabled = false;

		
				
			if (ccamera.fieldOfView < 120 && levelcounter!=8) {
					ccamera.fieldOfView += 30 * Time.deltaTime;
					ccamera.GetComponent<BlurOptimized> ().blurSize = 0;
					ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity -= .15f * Time.deltaTime;

				ccamera_th.fieldOfView += 30 * Time.deltaTime;
				ccamera_th.GetComponent<BlurOptimized> ().blurSize = 0;
				ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity -= .15f * Time.deltaTime;
				}

			if (ccamera.fieldOfView < 120 && levelcounter<1) {
				ccamera.fieldOfView += 60 * Time.deltaTime;
				ccamera.GetComponent<BlurOptimized> ().blurSize = 0;
				ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity -= .30f * Time.deltaTime;

				ccamera_th.fieldOfView += 60 * Time.deltaTime;
				ccamera_th.GetComponent<BlurOptimized> ().blurSize = 0;
				ccamera_th.GetComponent<VignetteAndChromaticAberration> ().intensity -= .30f * Time.deltaTime;
			}

			if (levelcounter == 8) {
				if (ccamera.fieldOfView < 120) {
					ccamera.fieldOfView += 30 * Time.deltaTime;
					ccamera.GetComponent<BlurOptimized> ().blurSize = 0;

					ccamera_th.fieldOfView += 30 * Time.deltaTime;
					ccamera_th.GetComponent<BlurOptimized> ().blurSize = 0;
					//ccamera.GetComponent<VignetteAndChromaticAberration> ().intensity -= .15f * Time.deltaTime;
				}

			}


		
			if (levelcounter != 8) {

				if (levelcounter < 1) {
					if (!prestartgaze)reticle.sprite = reticle_start;
					else reticle.sprite = reticleblank;
				} else {

					if (reticle.sprite != reticleoff)
						reticle.sprite = reticleoff;
				}
			} else {
				reticle.sprite = reticleblank;
			}
			reticlegroup.alpha = .8f;


		RoachOff (currentroachint, levelcounter);

		//ccamera.GetComponent<CameraFilterPack_Blur_Tilt_Shift_Hole> ().enabled = false;

	}

			







		//distancebetween = Vector3.Distance (walltest1.position, cameraposition.steamcameraposition);
		//Debug.Log("distancebetween" +distancebetween);

		//Debug.Log ("roachcounter : " + roachcounter + "levelcounter : " + levelcounter);

		//ccamera.GetComponent<Fisheye> ().strengthX -= .5f * Time.deltaTime;

	//	Debug.Log ("arrowsalpha: " + arrows.alpha + " arrowtransparency: " + arrowtransparency + " target: " + arrowtransparencytarget);
		//arrows.alpha = arrowtransparency;
		/*if (!gamestart) {
			arrowtransparency = Mathf.Lerp (arrowtransparency, arrowtransparencytarget, 3 * Time.deltaTime);
		} else
			arrows.alpha = 0;*/

	

	
		


		/*if (Time.time > 10) {
			wallextra1y = Mathf.Lerp (wallextra1y, 1.7f, .3f * Time.deltaTime);

		}

		if (Time.time > 20) {
			wallextra2y = Mathf.Lerp (wallextra2y, 1.7f, .3f * Time.deltaTime);

		}

		if (Time.time > 15) {

			wall1.transform.Translate (Vector3.forward*.05f*Time.deltaTime);
		}*/
	/*
		if (levelcounter == 2) {
			sphereytarget = 2.8f;


			level2wall1.transform.position = Vector3.Lerp (level2wall1.transform.position, level2wall1targetposition, .3f * Time.deltaTime);
			ccamera.GetComponent<Fisheye> ().strengthX = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthX, -.2f, .5f * Time.deltaTime);
			ccamera.GetComponent<Fisheye> ().strengthY = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthY, -.2f, .5f * Time.deltaTime);
			level2wall2.transform.position = Vector3.Lerp (level2wall2.transform.position, level2wall2targetposition, .3f * Time.deltaTime);



		}
		else if (levelcounter == 3) {
			sphereytarget = 2.7f;

			ccamera.GetComponent<Fisheye> ().strengthX = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthX, -.4f, .5f * Time.deltaTime);
			ccamera.GetComponent<Fisheye> ().strengthY = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthY, -.4f, .5f * Time.deltaTime);
			level3wall3.transform.position = Vector3.Lerp (level3wall3.transform.position, level3wall3targetposition, .3f * Time.deltaTime);
			level3wall4.transform.position = Vector3.Lerp (level3wall4.transform.position, level3wall4targetposition, .3f * Time.deltaTime);


		}
		else if (levelcounter == 4) {

			sphereytarget = 2.6f;

			level4wall5.transform.position = Vector3.Lerp (level4wall5.transform.position, level4wall5targetposition, .3f * Time.deltaTime);
			level4wall6.transform.position = Vector3.Lerp (level4wall6.transform.position, level4wall6targetposition, .3f * Time.deltaTime);
			level4wall7.transform.position = Vector3.Lerp (level4wall7.transform.position, level4wall7targetposition, .3f * Time.deltaTime);
			ccamera.GetComponent<Fisheye> ().strengthX = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthX, -.5f, .5f * Time.deltaTime);
			ccamera.GetComponent<Fisheye> ().strengthY = Mathf.Lerp (ccamera.GetComponent<Fisheye> ().strengthY, -.5f, .5f * Time.deltaTime);


		}*/

	/*



			
			
			



		}*/





	
	}


void FixedUpdate()
{

		Vector3 direction = spheretargetlook.transform.position - sphere.transform.position;
		Quaternion toRotation = Quaternion.FromToRotation (sphere.transform.forward, direction);
	sphere.transform.rotation = Quaternion.Lerp (sphere.transform.rotation, spheretargetlook.transform.rotation, 2 * Time.deltaTime);

	Vector3 direction2 = spheretargetlook.transform.position - sphere2.transform.position;
	Quaternion toRotation2 = Quaternion.FromToRotation (sphere2.transform.forward, direction2);
	sphere2.transform.rotation = Quaternion.Lerp (sphere2.transform.rotation, toRotation2, 2 * Time.deltaTime);

	Vector3 direction3 = spheretargetlook.transform.position - sphere3.transform.position;
	Quaternion toRotation3 = Quaternion.FromToRotation (sphere3.transform.forward, direction3);
	sphere3.transform.rotation = Quaternion.Lerp (sphere3.transform.rotation, toRotation3, 2 * Time.deltaTime);

}






	void Fadingarrows()
	{
		if (Time.time<6)return;
		if (arrowtransparencytarget == 0)
			arrowtransparencytarget = 1f;
		else
			arrowtransparencytarget = 0;

	}

void StopSetup()
{
		setupover = true;
		red.SetFloat("_Cutoff",currentalpha);
}



void RoachVision(int roach, int level )
{

		if (forcedprogress)
			return;

		switch (level) {
		
		case 2:
			switch (roach) {
			case 2:
				currentp = 1;
				break;

			case 3:
				currentp = 2;
				break;
			}
			break;

		case 3:
			switch (roach) {
			case 4:
			currentp = 1;
			break;

			case 5:
			currentp = 2;
			break;

			case 6:
			currentp = 3;
			break;
			}
		break;

		case 4:
			switch (roach) {
			case 7:
			currentp = 1;
			break;

			case 8:
			currentp = 2;
			break;

			case 9:
			currentp = 3;
			break;

			case 10:
			currentp = 4;
			break;
		}
		break;

	case 5:
		switch (roach) {
		case 11:
			currentp = 4;
			break;

		case 12:
			currentp = 3;
			break;

		case 13:
			currentp = 2;
			break;

		case 14:
			currentp = 1;
			break;
		}
		break;

	case 6:
		switch (roach) {
		case 15:
			currentp = 2;
			break;

		case 16:
			currentp = 5;
			break;

		case 17:
			currentp = 4;
			break;

		case 18:
			currentp = 3;
			break;

		case 19:
			currentp = 1;
			break;
		}
		break;

	case 7:
		switch (roach) {
		case 20:
			currentp = 6;
			break;

		case 21:
			currentp = 3;
			break;

		case 22:
			currentp = 2;
			break;

		case 23:
			currentp = 5;
			break;

		case 24:
			currentp = 1;
			break;

		case 25:
			currentp = 4;
			break;
		}
		break;

		}

//	Debug.Log ("currentp : " + currentp + " currentroach: " + currentroach + " patterndeath : " + patterndeaths + " pattern: " + pattern + " levelcounter : " + levelcounter + " level : " + level1 + " scorecount : " + scorecount + "scoreint" + scoreint  );



	if (levelcounter ==0 && !prestartgaze  ){

			gazestartcube = true;

		if (gazeontrigger) {
			//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			//dotsound.volume=tempvolume1;
			gazeontrigger = false;
		}

		dotsound.clip = soundall;
		if (dotsound.volume < .7f)
			dotsound.volume += .1f * Time.deltaTime;
		tempvolume1 = dotsound.volume;

		reset_0 = false;
			

		//ccamera.backgroundColor = Color.Lerp (Color.white, Color.black, 4 * Time.deltaTime);
		ccamera.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness-=.5f * Time.deltaTime;
		ccamera_th.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness-=.5f * Time.deltaTime;

		P0.transform.localPosition = Vector3.Lerp (P0.transform.localPosition, p0onposition, 1);
		currentalpha0 -= alphacut0 * Time.deltaTime;
		white.SetFloat ("_Cutoff", currentalpha0);
		//	Debug.Log ("currentalpha0 " + currentalpha0);

			if (currentalpha0 <=0 && !prestartgaze) {


			//ccamera.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness -= alphacut0 * Time.deltaTime;
				outlinemoveaway = true;
				spotlight.enabled = false;
				P0.transform.position = p0offposition;
				white.SetFloat ("_Cutoff", 1);

				prestartgaze=true;
				//cieling.transform.position = cielingoffposition;
				directlight.GetComponent<Light> ().intensity = 0;
				ccamera.backgroundColor = Color.black;
				ccamera.clearFlags = CameraClearFlags.Skybox;



			ccamera_th.backgroundColor = Color.black;
			ccamera_th.clearFlags = CameraClearFlags.Skybox;

				Invoke ("SetInitialize", 2);
			idleposition=GameObject.Find("FPSController (head)").transform.position;
			idlerotation=GameObject.Find("FPSController (head)").transform.rotation;

			InvokeRepeating ("Idler", 0, .1f);


				startpointlight.enabled = false;
			startcube.tag = "dead";
			startcube.transform.position = startcubeoffposition;


				wallsound.Play ();
				dotsound.volume = 0;
				//reticle.sprite = reticleblank;
			if (alphacut0 < 1 && alphacut0 >= .7f) {
				reticle.sprite = reticle_start1;
			}
			else if (alphacut0 < .7f && alphacut0 >= .4f) {
				reticle.sprite = reticle_start2;
			}
			else if (alphacut0 < .4f && alphacut0 >= .2f) {
				reticle.sprite = reticle_start3;
			}
			else if (alphacut0 < .2f && alphacut0 >= 0) {
				reticle.sprite = reticle_start4;
			}


			}

		return;
	}
		

	switch(roach)
	{
		case 1:
			if (gazeontrigger) {
				//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
				//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			//	Fadein (tempvolume1);
				dotsound.volume=tempvolume1;
				gazeontrigger = false;
			}

			dotsound.clip = sound1;
			if (dotsound.volume < 1)
				dotsound.volume += alphacut * Time.deltaTime;
			tempvolume1 = dotsound.volume;
			currentp = 1;
			//dotsound.pitch += .3f * Time.deltaTime;
			P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
			currentalpha -= alphacut * Time.deltaTime;
			red.SetFloat ("_Cutoff", currentalpha);
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);

			tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;


			

			if (currentalpha <= 0f) 
			{
				GameObject.Find (currentroach).tag = "dead";
				currentalpha = 10;
				scoreint++;

			if (!expl1.isPlaying && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Invoke ("RoachExplodeReset", .5f);
				expl1.Play ();
				expl1sound.Play ();

			}

				if (dddebug) {
					levelcounter = 6;
					Patternchange (7);
					pattern = true;
					

				} else {
					fullcolordelay = true;
					Invoke ("FadeOutColor", 3f);

					levelcounter = 1;
					Patternchange (2);
					pattern = true;
				}

			//	int tempnum1 = Random.Range (1, 3);
				//if (tempnum1 == 1) {
					
				
						
					//}
			}
			break;







		case 2:
			




			if (gazeontrigger) {
			//Debug.Log ("GAZEONTRIGGER ROACH 2 GREEN " + "gazeontrigger : " + gazeontrigger + " gazeonreset :" + gazeonreset + " gazeoffreset : " + gazeoffreset + " gazeofftrigger : " +gazeofftrigger);
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;

				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

				gazeontrigger = false;
			//	Fadein (tempvolume1);
				dotsound.volume = tempvolume1;

			}

			dotsound.clip = sound1;
			if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
			tempvolume1=dotsound.volume;
			currentp = 1;

			reset_1 = false;
			P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
			currentalpha2 -= alphacut * Time.deltaTime;
			red.SetFloat ("_Cutoff", currentalpha2);
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

			if (currentalpha2 <= 0f) {
				currentalpha2 = 1;
				GameObject.Find (currentroach).tag = "dead";
				


		//	int tempnum1 = Random.Range (1, 3);
		//	if (tempnum1 == 1) {
				
		
				if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
						expl1.Play ();
						expl1sound.Play ();
						Invoke ("RoachExplodeReset1", .5f);

					
				} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;

					expl2.Play ();
					expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

				}

				
			//}
				

			if (patterndeaths == 0){

					if (pattern2 [patterndeaths] == currentp) {

					}

					patterndeaths++;
					fullcolordelay = true;
					Invoke ("FadeOutColor", 3f);



			
			
			
			
			}
				else if (patterndeaths == 1)
				{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);

				patterndeaths++;
				Patternchange (3);
				pattern = true;
				}

				Debug.Log ("Patterndeaths : " + patterndeaths);
			//levelcounter = 1;
			//Patternchange (2);
		}
			

			break;




		case 3:



		if (gazeontrigger) {
			//Debug.Log ("GAZEONTRIGGER ROACH 3 BLUE " + " gazeontrigger : " + gazeontrigger + " gazeonreset :" + gazeonreset + " gazeoffreset : " + gazeoffreset + " gazeofftrigger : " +gazeofftrigger);
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;

			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;

			gazeontrigger = false;
			//Fadein (tempvolume2);
				dotsound.volume = tempvolume2;

		}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;



		reset_2 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha3 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha3);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .3f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;


		if (currentalpha3 <= 0f) 
		{
			currentalpha3 = 1;
			GameObject.Find (currentroach).tag = "dead";

			//int tempnum1 = Random.Range (1, 3);
		//	if (tempnum1 == 1) {
			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			}
		//	}


		if (patterndeaths == 0){
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
			}
			else if (patterndeaths == 1)
			{

				if (pattern2 [patterndeaths] == currentp) {

						scoreint = 1;
						
				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				Patternchange (3);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;


		// LEVEL3


	case 4:
		if (!on_trigger) {
			on_trigger = true;

		}

		//Debug.Log("currentroach: " + roach + "level : " + level + "case4_yellow:alpha: " + yellow.GetFloat("_Cutoff") + "currentalpha4" + currentalpha4 + "patterndeaths: " + patterndeaths + "reset_1 : " + reset_1);
			

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;

			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			gazeontrigger = false;
			//Fadein (tempvolume1);
			dotsound.volume=tempvolume1;
		}

		dotsound.clip = sound1;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume1=dotsound.volume;

		reset_1 = false;

		P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
		currentalpha4 -= alphacut * Time.deltaTime;
		red.SetFloat ("_Cutoff", currentalpha4);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha4 <= 0f) {
			currentalpha4 = 1;
			GameObject.Find (currentroach).tag = "dead";


			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			}
			//	}



			if (patterndeaths < 2){

				if (pattern3 [patterndeaths] == currentp) {

						scorecount++; 
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
			}
			else if (patterndeaths == 2)
			{	


				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (4);
				pattern = true;
			}

			Debug.Log ("Patterndeaths : " + patterndeaths);
			//levelcounter = 1;
			//Patternchange (2);
		}


		break;
		case 5:

			Debug.Log ("currentroach: " + roach + "level : " + level + "case5_white:alpha: " + cyan.GetFloat ("_Cutoff") + "currentalpha5" + currentalpha5 + "patterndeaths: " + patterndeaths + "reset_2 : " + reset_2);

			if (gazeontrigger) {
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;

				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;

				gazeontrigger = false;
				//Fadein (tempvolume2);


			}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;

		reset_2 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha5 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha5);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .2f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha5 <= 0f) 
		{
			currentalpha5 = 1;
			GameObject.Find (currentroach).tag = "dead";


			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			}
			//	}


			if (patterndeaths <2){
				if (pattern3 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
						scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
			}
			else if (patterndeaths == 2)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (4);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;

	case 6:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound3;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume3=dotsound.volume;

		reset_3 = false;

		P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
		currentalpha6 -= alphacut * Time.deltaTime;
		blue.SetFloat ("_Cutoff", currentalpha6);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, .2f * Time.deltaTime);

		tempcolor3 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha6 <= 0f) 
		{
			currentalpha6 = 1;
			GameObject.Find (currentroach).tag = "dead";



			//int tempnum1 = Random.Range (1, 3);
			//	if (tempnum1 == 1) {
			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			}
			//	}


			if (patterndeaths <2){
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
			}
			else if (patterndeaths == 2)
			{	
					Debug.Log ("CORRECT!" + " scorecount:" + scorecount);
				if (pattern3 [patterndeaths] == currentp) {
						scorecount++;
						if (scorecount == 3)
							scoreint++;
				}


				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (4);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;





		// LEVEL4





	case 7:


		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound1;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume1=dotsound.volume;

		reset_1 = false;

		P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
		currentalpha7 -= alphacut * Time.deltaTime;
		red.SetFloat ("_Cutoff", currentalpha7);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha7 <= 0f) 
		{
			currentalpha7 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter = 0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}

			if (patterndeaths <3){

				if (pattern4 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1f);
			}
			else if (patterndeaths == 3)
			{	fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (5);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 8:


		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;

		reset_2 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha8 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha8);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .2f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha8 <= 0f) 
		{
			currentalpha8 = 1;
			GameObject.Find (currentroach).tag = "dead";


			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}


			if (patterndeaths <3){

				if (pattern4 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3);
			}
			else if (patterndeaths == 3)
			{
				patterndeaths++;
				Patternchange (5);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 9:


		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound3;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume3=dotsound.volume;

		reset_3 = false;

		P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
		currentalpha9 -= alphacut * Time.deltaTime;
		blue.SetFloat ("_Cutoff", currentalpha9);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, .2f * Time.deltaTime);

		tempcolor3 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha9 <= 0f) 
		{
			currentalpha9 = 1;
			GameObject.Find (currentroach).tag = "dead";


			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}


			if (patterndeaths <3){

				if (pattern4 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (5);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;



	case 10:


		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound4;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume4=dotsound.volume;

		reset_4 = false;

		P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
		currentalpha10 -= alphacut * Time.deltaTime;
		yellow.SetFloat ("_Cutoff", currentalpha10);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, .2f * Time.deltaTime);

		tempcolor4 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha10 <= 0f) 
		{
			currentalpha10 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}


			if (patterndeaths <3){

				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{

			Debug.Log ("CORRECT!" + " scorecount:" + scorecount);
				if (pattern4 [patterndeaths] == currentp) {
					Debug.Log ("ADD SCORE");
					scorecount++;
					if (scorecount == 4)
						scoreint++;
				
			}
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
				patterndeaths++;
				Patternchange (5);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;



		//LEVEL5



	case 11:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound4;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume1=dotsound.volume;

		reset_1 = false;

		P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
		currentalpha7 -= alphacut * Time.deltaTime;
		yellow.SetFloat ("_Cutoff", currentalpha7);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha7 <= 0f) 
		{
			currentalpha7 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}

			if (patterndeaths <3){

		if (pattern5 [patterndeaths] == currentp) {
			Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
			scorecount++; 

		}
		
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (6);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 12:

		Debug.Log("currentroach: " + roach + "level : " + level + "case8_brown:alpha: " + brown.GetFloat("_Cutoff") + "currentalpha8" + currentalpha8 + "patterndeaths: " + patterndeaths + "reset_2 : " + reset_2);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound3;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;

		reset_2 = false;

		P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
		currentalpha8 -= alphacut * Time.deltaTime;
		blue.SetFloat ("_Cutoff", currentalpha8);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, .2f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha8 <= 0f) 
		{
			currentalpha8 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}

			if (patterndeaths <3){

		if (pattern5 [patterndeaths] == currentp) {
			Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
			scorecount++; 

		}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (6);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 13:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume3=dotsound.volume;

		reset_3 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha9 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha9);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .2f * Time.deltaTime);

		tempcolor3 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha9 <= 0f) 
		{
			currentalpha9 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}

			if (patterndeaths <3){

		if (pattern5 [patterndeaths] == currentp) {
			Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
			scorecount++; 

		}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (6);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 14:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound1;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume4=dotsound.volume;

		reset_4 = false;

		P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
		currentalpha10 -= alphacut * Time.deltaTime;
		red.SetFloat ("_Cutoff", currentalpha10);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor4 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha10 <= 0f) 
		{
			currentalpha10 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			}

			if (patterndeaths <3){
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 3)
			{

		Debug.Log ("CORRECT!" + " scorecount:" + scorecount);
		if (pattern5 [patterndeaths] == currentp) {
			scorecount++;
			if (scorecount == 4)
				scoreint++;
		}
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (6);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;



		//LEVEL 6

	case 15:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume1=dotsound.volume;

		reset_1 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha7 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha7);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha7 <= 0f) 
		{
			currentalpha7 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <4){

				if (pattern6 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}

				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 4)
			{fullcolordelay = true;
				Invoke ("FadeOutColor", 5f);
				patterndeaths++;
				Patternchange (7);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 16:

		Debug.Log("currentroach: " + roach + "level : " + level + "case8_brown:alpha: " + brown.GetFloat("_Cutoff") + "currentalpha8" + currentalpha8 + "patterndeaths: " + patterndeaths + "reset_2 : " + reset_2);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound5;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;

		reset_2 = false;

		P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5onposition, 1);
		currentalpha8 -= alphacut * Time.deltaTime;
		cyan.SetFloat ("_Cutoff", currentalpha8);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.cyan, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.cyan, .2f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha8 <= 0f) 
		{
			currentalpha8 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <4){

				if (pattern6 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 4)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (7);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 17:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound4;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume3=dotsound.volume;

		reset_3 = false;

		P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
		currentalpha9 -= alphacut * Time.deltaTime;
		yellow.SetFloat ("_Cutoff", currentalpha9);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, .2f * Time.deltaTime);

		tempcolor3 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha9 <= 0f) 
		{
			currentalpha9 = 1;
			GameObject.Find (currentroach).tag = "dead";


			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <4){

				if (pattern6 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3);
			}
			else if (patterndeaths == 4)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (7);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 18:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound3;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume4=dotsound.volume;

		reset_4 = false;

		P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
		currentalpha10 -= alphacut * Time.deltaTime;
		blue.SetFloat ("_Cutoff", currentalpha10);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, .2f * Time.deltaTime);

		tempcolor4 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha10 <= 0f) 
		{
			currentalpha10 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <4){

				if (pattern6 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3);
			}
			else if (patterndeaths == 4)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (7);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 19:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor5;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor5;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound1;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume5=dotsound.volume;

		reset_5 = false;

		P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
		currentalpha11 -= alphacut * Time.deltaTime;
		red.SetFloat ("_Cutoff", currentalpha11);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor5 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha11 <= 0f) 
		{
			currentalpha11 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <4){
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 4)
			{

				Debug.Log ("CORRECT!" + " scorecount:" + scorecount);
				if (pattern6 [patterndeaths] == currentp) {
					scorecount++;
					if (scorecount == 5)
						scoreint++;
				}

				fullcolordelay = true;
				Invoke ("FadeOutColor", 5f);
				patterndeaths++;
				Patternchange (7);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;


		// LEVEL7





	case 20:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor1;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound6;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume1=dotsound.volume;

		reset_1 = false;

		P6.transform.localPosition = Vector3.Lerp (P6.transform.localPosition, p6onposition, 1);
		currentalpha7 -= alphacut * Time.deltaTime;
		magenta.SetFloat ("_Cutoff", currentalpha7);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.magenta, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.magenta, .2f * Time.deltaTime);

		tempcolor1 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha7 <= 0f) 
		{
			currentalpha7 = 1;
			GameObject.Find (currentroach).tag = "dead";

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){

				if (pattern7 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}
				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 21:

		Debug.Log("currentroach: " + roach + "level : " + level + "case8_brown:alpha: " + brown.GetFloat("_Cutoff") + "currentalpha8" + currentalpha8 + "patterndeaths: " + patterndeaths + "reset_2 : " + reset_2);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor2;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound3;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume2=dotsound.volume;

		reset_2 = false;

		P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3onposition, 1);
		currentalpha8 -= alphacut * Time.deltaTime;
		blue.SetFloat ("_Cutoff", currentalpha8);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.blue, .2f * Time.deltaTime);

		tempcolor2 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha8 <= 0f) 
		{
			currentalpha8 = 1;
			GameObject.Find (currentroach).tag = "dead";

			roachexplode = true;

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){

				if (pattern7 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}


				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 22:

		Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor3;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound2;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume3=dotsound.volume;

		reset_3 = false;

		P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2onposition, 1);
		currentalpha9 -= alphacut * Time.deltaTime;
		green.SetFloat ("_Cutoff", currentalpha9);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.green, .2f * Time.deltaTime);

		tempcolor3 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha9 <= 0f) 
		{
			currentalpha9 = 1;
			GameObject.Find (currentroach).tag = "dead";

			roachexplode = true;

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){

				if (pattern7 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}


				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 23:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor4;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound5;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume4=dotsound.volume;

		reset_4 = false;

		P5.transform.localPosition = Vector3.Lerp (P5.transform.localPosition, p5onposition, 1);
		currentalpha10 -= alphacut * Time.deltaTime;
		cyan.SetFloat ("_Cutoff", currentalpha10);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.cyan, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.cyan, .2f * Time.deltaTime);

		tempcolor4 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha10 <= 0f) 
		{
			currentalpha10 = 1;
			GameObject.Find (currentroach).tag = "dead";

			roachexplode = true;

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){

				if (pattern7 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}


				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{
				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;




	case 24:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor5;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor5;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound1;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume5=dotsound.volume;

		reset_5 = false;

		P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
		currentalpha11 -= alphacut * Time.deltaTime;
		red.SetFloat ("_Cutoff", currentalpha11);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .2f * Time.deltaTime);

		tempcolor5 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha11 <= 0f) 
		{
			currentalpha11 = 1;
			GameObject.Find (currentroach).tag = "dead";

			roachexplode = true;

			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){

				if (pattern7 [patterndeaths] == currentp) {
					Debug.Log ("CORRECT!" + "currentroach: " + currentroach + "currentp : " + currentp  );
					scorecount++; 

				}


				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{	fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;



	case 25:

		//Debug.Log("currentroach: " + roach + "level : " + level + "case6_red:alpha: " + red.GetFloat("_Cutoff") + "currentalpha6" + currentalpha6 + "patterndeaths: " + patterndeaths + "reset_3 : " + reset_3);

		if (gazeontrigger) {
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor6;

			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor6;
			gazeontrigger = false;
			Fadein (tempvolume3);

		}

		dotsound.clip = sound4;
		if (dotsound.volume<.7f)dotsound.volume += alphacut * Time.deltaTime;
		tempvolume6=dotsound.volume;

		reset_6 = false;

		P4.transform.localPosition = Vector3.Lerp (P4.transform.localPosition, p4onposition, 1);
		currentalpha12 -= alphacut * Time.deltaTime;
		yellow.SetFloat ("_Cutoff", currentalpha12);
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow,alphacut * Time.deltaTime);
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.yellow, .2f * Time.deltaTime);

		tempcolor6 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

		if (currentalpha12 <= 0f) 
		{
			currentalpha12 = 1;
			GameObject.Find (currentroach).tag = "dead";

			roachexplode = true;
			if (explosioncounter == 0 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl1.transform.position = tempposition20;
				Debug.Log ("here1");
				expl1.Play ();
				expl1sound.Play ();
				Invoke ("RoachExplodeReset1", .5f);


			} else if (explosioncounter == 1 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl2.transform.position = tempposition20;
				Debug.Log ("here2");

				expl2.Play ();
				expl2sound.Play ();
				Invoke ("RoachExplodeReset2", .5f);

			} else if (explosioncounter == 2 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl3.transform.position = tempposition20;
				Debug.Log ("here2");

				expl3.Play ();
				expl3sound.Play ();
				Invoke ("RoachExplodeReset3", .5f);

			} else if (explosioncounter == 3 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl4.transform.position = tempposition20;

				expl4.Play ();
				expl4sound.Play ();
				Invoke ("RoachExplodeReset4", .5f);

			} else if (explosioncounter == 4 && !pattern) {
				roachexplode = true;
				explosioncounter++;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl5.Play ();
				expl5sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			} else if (explosioncounter == 5 && !pattern) {
				roachexplode = true;
				explosioncounter=0;
				tempposition20 = GameObject.Find (currentroach).transform.position;
				tempposition20.y += .19f;
				expl5.transform.position = tempposition20;

				expl6.Play ();
				expl6sound.Play ();
				Invoke ("RoachExplodeReset5", .5f);

			}

			if (patterndeaths <5){


				patterndeaths++;
				fullcolordelay = true;
				Invoke ("FadeOutColor", 1);
			}
			else if (patterndeaths == 5)
			{	
				Debug.Log ("CORRECT!" + " scorecount:" + scorecount);
				if (pattern6 [patterndeaths] == currentp) {
					scorecount++;
					if (scorecount == 6)
						scoreint++;
				}

				fullcolordelay = true;
				Invoke ("FadeOutColor", 3f);
				patterndeaths++;
				Patternchange (8);
				pattern = true;
			}


			//levelcounter = 1;
			//Patternchange (2);
		}
		break;

		//BOSS
		case 26:
			
			if (end)
				return;
			Debug.Log ("currentroach: " + roach + "level : " + levelcounter + "magentalevel" + magenta.GetFloat ("_Cutoff") + "currentalpha13" + currentalpha13 + "patterndeaths: " + patterndeaths + "reset_1 : " + reset_1);

			if (gazeontrigger) {
				if (distance < .5f) {
					ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
					ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor6;

				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = true;
				ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = tempcolor6;
					gazeontrigger = false;
					Fadein (tempvolume6);
				}

			}

		if (distance<.7f) {
			
				dotsound.clip = sound1;
			if (dotsound.volume<1f)dotsound.volume += .03f * Time.deltaTime;
				tempvolume6 = dotsound.volume;

				reset_1 = false;

				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1onposition, 1);
				currentalpha13 -= alphacutfinal * Time.deltaTime;
				red.SetFloat ("_Cutoff", currentalpha13);
				ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .03f * Time.deltaTime);
			ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, Color.red, .03f * Time.deltaTime);

			tempcolor6 = ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB;

			}

				if (currentalpha13 <= 0f && !pattern) {
					Debug.Log ("HERE DEAD");	
					//currentalpha13 = 1;
					//GameObject.Find (currentroach).tag = "dead";

					scoreint++;
					bosssound.Stop ();
					fullcolordelay = true;
					Invoke ("FadeOutColor", 1f);
					patterndeaths++;
					Patternchange (9);
					pattern = true;
				}
			

			//levelcounter = 1;
			//Patternchange (2);

		break;


	}


}


void RoachOff(int roach, int level )
{

	if (forcedprogress)
		return;
	if (levelcounter ==0){
			gazestartcube = false;

			P0.transform.localPosition = Vector3.Lerp (P0.transform.localPosition, p0offposition, 1f * Time.deltaTime);
			//currentalpha0 = 1;
			//white.SetFloat ("_Cutoff", currentalpha0);
			dotsound.volume = 0;
			ccamera.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness = 1;
			ccamera_th.GetComponent<CameraFilterPack_Colors_Brightness> ()._Brightness = 1;

			reset_0 = true;

				return;
	}




	switch(roach)
	{
		case 1:
			if (GameObject.Find (currentroach).tag != "dead") {
			P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 1f * Time.deltaTime);
		} else
				P1.transform.localPosition = Vector3.Lerp (P1.transform.localPosition, p1offposition, 1);


		break;

		//LEVEL2


		case 2:

			if (GameObject.Find (currentroach).tag != "dead") {
				//P2.transform.localPosition = Vector3.Lerp (P2.transform.localPosition, p2offposition, 1);
			reset_1 = true;

			} else {
				if (!off_trigger) {
					off_trigger = true;
				}

			}
			break;
		case 3:

			if (GameObject.Find (currentroach).tag != "dead") {
				//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

			} else {
				if (!off_trigger) {
					off_trigger = true;
				}

			}
			break;

		//LEVEL3

	case 4:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 5:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 6:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_3 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;


		// LEVEL4

	case 7:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 8:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 9:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_3 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 10:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_4 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

		// LEVEL 5


	case 11:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 12:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 13:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_3 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 14:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_4 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

		//LEVEL6


	case 15:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

		// LEVEL 5


	case 16:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 17:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_3 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 18:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_4 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 19:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_5 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;



// LEVEL7



	case 20:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

		// LEVEL 5


	case 21:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_2 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 22:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_3 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 23:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_4 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 24:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_5 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

	case 25:

		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_6 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;

		case 26:
			if (end)
				return;
		if (GameObject.Find (currentroach).tag != "dead") {
			//P3.transform.localPosition = Vector3.Lerp (P3.transform.localPosition, p3offposition, 1);
			reset_1 = true;

		} else {
			if (!off_trigger) {
				off_trigger = true;
			}

		}
		break;



	}




		
		

		



}



void LevelChange(int level)
{
		holdoff = false;
		if (levelswitchinprogress)
			return;
	
		fullcolorfade = false;

		levelswitchinprogress = true;
		switch (level)
		{
		
		case 1:
			levelcounter = 2;
			levelchange1to2 = true;
			//level2wall1.transform.position = level2wall1startposition;
			//level2wall2.transform.position = level2wall2startposition;

			
			break;
		case 2:
			levelcounter = 3;
			levelchange2to3 = true;

			break;
		case 3:
			levelcounter = 4;
			levelchange3to4=true;
			break;

		case 4:
		levelcounter = 5;
		levelchange4to5=true;
		break;


		case 5:
		levelcounter = 6;
		levelchange5to6=true;
		break;

		case 6:
		levelcounter = 7;
		levelchange6to7=true;
		break;

		case 7:
		levelcounter = 8;
		levelchange7to8=true;
		break;


}

	Invoke("LevelChangeStop",3);

}


void LevelChangeStop()
{
	levelswitchinprogress = false;

		switch (levelcounter) 
		{
		case 2:
			levelchange1to2 = false;
			break;

		case 3:
			levelchange2to3 = false;
			break;

		case 4:
		levelchange3to4 = false;
		break;

	case 5:
		levelchange4to5 = false;
		break;

	case 6:
		levelchange5to6 = false;
		break;

	case 7:
		levelchange6to7 = false;
		break;

	case 8:
		levelchange7to8 = false;
		break;

		}
}





void Patternchange(int pattern)
{

		holdoff = true;
				countdowntimer1 = lengthoftime;		
		switch (pattern) {
		case 2:
			if (pattern2on)return;
			pattern2on = true;
			patterntrigger = true;
		patterntimer=patterntimerthreshold_2;

		//	ccamera.GetComponent<BlurOptimized>().enabled =true;

			//spotlight.enabled = false;
			Invoke ("Pattern2_0", 1f);
			Invoke ("Pattern2_1", 3f);
			Invoke ("Pattern2_2", 4f);
			Invoke ("Pattern2_3", 5f);
			Invoke ("Pattern2_off", 7f);

			
			break;
		case 3:
			pattern3on = true;
			patterntrigger = true;
			patterntimer = patterntimerthreshold_3;

			CancelInvoke ("MaterialChanger");
			materialcounter = 0;


	//	ccamera.GetComponent<BlurOptimized>().enabled =true;

			//spotlight.enabled = false;

			red.SetFloat ("_Cutoff", 0);
			yellow.SetFloat ("_Cutoff", 0);
			cyan.SetFloat ("_Cutoff", 0);

			reset_1 = false;
			reset_2 = false;
			reset_3 = false;

			patterndeaths = 0;

			Invoke	("Pattern3_00", 0);
			Invoke	("Pattern3_0", 1);
			Invoke ("Pattern3_1", 3f);
			Invoke ("Pattern3_2", 4f);
			Invoke ("Pattern3_3", 5f);
			Invoke ("Pattern3_4", 6f);
			Invoke ("Pattern3_off", 8f);

			break;
	
		case 4:
		//ccamera.GetComponent<BlurOptimized>().enabled =true;

			pattern4on = true;
			patterntrigger = true;
			patterntimer=patterntimerthreshold_4;
		CancelInvoke ("MaterialChanger");
		materialcounter = 0;


		green.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);



		//spotlight.enabled = false;
			reset_1 = false;
			reset_2 = false;
			reset_3 = false;
			reset_4 = false;
			patterndeaths = 0;

		Invoke	("Pattern4_0", 1);

		Invoke ("Pattern4_1", 3f);
		Invoke ("Pattern4_2", 4f);
		Invoke ("Pattern4_3", 5f);
		Invoke ("Pattern4_4", 6f);
		Invoke ("Pattern4_5", 7f);

		Invoke ("Pattern4_off", 9f);



		break;


	case 5:
		//ccamera.GetComponent<BlurOptimized>().enabled =true;

		pattern5on = true;
		patterntrigger = true;
		patterntimer=patterntimerthreshold_5;
		CancelInvoke ("MaterialChanger");


		green.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);



		//spotlight.enabled = false;
		reset_1 = false;
		reset_2 = false;
		reset_3 = false;
		reset_4 = false;
		patterndeaths = 0;

		Invoke	("Pattern5_0", 1);

		Invoke ("Pattern5_1", 3f);
		Invoke ("Pattern5_2", 4f);
		Invoke ("Pattern5_3", 5f);
		Invoke ("Pattern5_4", 6f);
		Invoke ("Pattern5_5", 7f);

		Invoke ("Pattern5_off", 9f);



		break;


		case 6:

			Debug.Log ("AT PATTERNCHANGE6 _ START");
		//ccamera.GetComponent<BlurOptimized>().enabled =true;

		pattern6on = true;
		patterntrigger = true;
		patterntimer=patterntimerthreshold_6;
		CancelInvoke ("MaterialChanger");


		green.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);



		//spotlight.enabled = false;
		reset_1 = false;
		reset_2 = false;
		reset_3 = false;
		reset_4 = false;
		patterndeaths = 0;

		Invoke	("Pattern6_0", 1);

		Invoke ("Pattern6_1", 3f);
		Invoke ("Pattern6_2", 4f);
		Invoke ("Pattern6_3", 5f);
		Invoke ("Pattern6_4", 6f);
		Invoke ("Pattern6_5", 7f);
		Invoke ("Pattern6_6", 8f);


		Invoke ("Pattern6_off", 10f);


		Debug.Log ("AT PATTERNCHANGE6 _ FINSH");

		break;


	case 7:

		//ccamera.GetComponent<BlurOptimized>().enabled =true;

		pattern7on = true;
		patterntrigger = true;
		patterntimer=patterntimerthreshold_7;
		CancelInvoke ("MaterialChanger");


		green.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);
		red.SetFloat ("_Cutoff", 0);
		yellow.SetFloat ("_Cutoff", 0);




		//spotlight.enabled = false;
		reset_1 = false;
		reset_2 = false;
		reset_3 = false;
		reset_4 = false;
		reset_5 = false;
		reset_6 = false;


		patterndeaths = 0;

		Invoke	("Pattern7_0", 1);
		Invoke ("Pattern7_1", 3f);
		Invoke ("Pattern7_2", 4f);
		Invoke ("Pattern7_3", 5f);
		Invoke ("Pattern7_4", 6f);
		Invoke ("Pattern7_5", 7);
		Invoke ("Pattern7_6", 8f);
		Invoke ("Pattern7_7", 9f);

		Invoke ("Pattern7_off", 12f);



		break;


	case 8:

		//ccamera.GetComponent<BlurOptimized>().enabled =true;
		if (pattern8on)return;
		pattern8on = true;
		patterntrigger = true;
		patterntimer=patterntimerthreshold_8;
		CancelInvoke ("MaterialChanger");


		green.SetFloat ("_Cutoff", 0);
		brown.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);
		red.SetFloat ("_Cutoff", 0);
		yellow.SetFloat ("_Cutoff", 0);
		cyan.SetFloat ("_Cutoff", 0);





		//spotlight.enabled = false;
		reset_1 = false;
		reset_2 = false;
		reset_3 = false;
		reset_4 = false;
		reset_5 = false;
		reset_6 = false;
		reset_7 = false;


		patterndeaths = 0;

		Invoke	("Pattern8_0", 1);

		Invoke ("Pattern8_1", 3f);
		Invoke ("Pattern8_2", 5f);

		Invoke ("Pattern8_off", 8f);



		break;

		case 9:
		//END
			if (endstarted)
				return;
			endstarted = true;
			outlinemovein = true;

		Together();
			Invoke ("Death", 8);
			Invoke ("BoxCollider", 12);

			Invoke ("Restart", 15);
			wallsound.Play ();
			spotlight.range = 4;
			//spotlight.intensity = 1f;
			ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;
		ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;


			

			break;

	}

		





		






}


void ResetPatternTurningOff()
{
	pattern = false;

		switch (levelcounter) {
		case 2:
			pattern2turningoff = false;
			break;
		case 3:
			pattern3turningoff = false;
			break;
		case 4:
			pattern4turningoff = false;
			break;
		case 5:
			pattern5turningoff = false;
			break;
		case 6:
			pattern6turningoff = false;
			break;
		case 7:
		pattern7turningoff = false;
		break;
		case 8:
		pattern8turningoff = false;
		break;
		

		}



}

void Pattern2_0()
{
	//Debug.Log ("called_pattern2_1");
	pattern2_0on = true;
		patternreticle = true;
	ResetPattern ();



}

void Pattern2_1()
{		ccamera.GetComponent<BlurOptimized> ().blurSize = 5;
		ccamera.GetComponent<BlurOptimized>().enabled = false;

	ccamera_th.GetComponent<BlurOptimized> ().blurSize = 5;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;




		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
		ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

		dotsound.volume = .5f;
		dotsound.clip = sound1;
		dotsound.Play ();
		crackingthresholdsmall = 3;
		crackingthresholdmedium = 3;
		pattern2_1on = true;
		pattern2_0on = false;



}

void Pattern2_2()
	{
	//Debug.Log ("called_pattern2_2");
		dotsound.clip = sound2;
		dotsound.Play ();
		pattern2_2on = true;
		pattern2_1on = false;
	}

void Pattern2_3()
{

	pattern2_3on = true;
	pattern2_2on = false;
	patternreticle = false;
		wallsound.Play ();
	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 5, 5);

	floor.GetComponent<Renderer> ().material = material1;
	level2wall1.GetComponent<Renderer> ().material = material1;
	level2lwall.GetComponent<Renderer> ().material = material1;
	level2rwall.GetComponent<Renderer> ().material = material1;
	level2bwall.GetComponent<Renderer> ().material = material1;
	level2fwall.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;		
	currentmaterial = material1;

		roomsound.clip = room2sound;
		roomsound.Play ();

	level1.transform.localPosition = level1offposition;
		ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 1;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 1;

	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 1;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 1;



		crackingthresholdmin = 5;






}

void Pattern2_off()
{
	
	FPSLine.GetComponent<DrawLine> ().Reset ();
	FPSLine.GetComponent<DrawLine> ().Restart ();

	//GameObject.Find ("3").transform.localPosition = c2onposition;
	//GameObject.Find ("2").transform.localPosition = c3onposition;

	roachplant = false;

	pattern2_3on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
		tempvolume1 = 0;
		tempvolume2 = 0;
		tempvolume3 = 0;
	explosioncounter = 0;

	setupplayer = true;
	Invoke ("Setupplayerreset",2);

	//FPSLine.GetComponent<DrawLine> ().off = false;





}


void Pattern3_00()
	{
	pattern3_00on = true;

	}


void Pattern3_0()
{	

		ResetPattern ();


	pattern3_00on = false;
	pattern3_0on = true;
	patternreticle = true;



}



void Pattern3_1()
{
	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;

		fullcolorfade = false;
	pattern3_1on = true;


	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;


	level3.transform.position = level1startposition;
	dotsound.volume = .5f;
	crackingthresholdsmall = 6;
	crackingthresholdmedium = 7;
	crackingthresholdmin = 3;



	dotsound.clip = sound1;
	dotsound.Play ();
		dotsound.volume = .5f;
	pattern3_0on = false;
}

void Pattern3_2()
{
	//Debug.Log ("called_pattern2_2");
	dotsound.clip = sound2;
	dotsound.Play ();
	dotsound.volume = .5f;

	pattern3_2on = true;
	pattern3_1on = false;

}

void Pattern3_3()
{
	dotsound.clip = sound3;
	dotsound.Play ();
	dotsound.volume = .5f;

	pattern3_3on = true;
	pattern3_2on = false;



}
void Pattern3_4()
{
	wallsound.Play ();

	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 4, 3);

	floor.GetComponent<Renderer> ().material = material1;
	level3wall1.GetComponent<Renderer> ().material = material1;
	level3wall2.GetComponent<Renderer> ().material = material1;
	level3wall3.GetComponent<Renderer> ().material = material1;
	level3wall4.GetComponent<Renderer> ().material = material1;
	level3wall5.GetComponent<Renderer> ().material = material1;

	level3lwall.GetComponent<Renderer> ().material = material1;
	level3rwall.GetComponent<Renderer> ().material = material1;
	level3bwall.GetComponent<Renderer> ().material = material1;
	level3fwall.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;		
	currentmaterial = material1;

	pattern3_4on = true;
	pattern3_3on = false;
	patternreticle = false;

	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 2;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 2;

	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 2;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 2;






}

void Pattern3_off()
{


	roachplant = false;
	pattern3_4on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	explosioncounter = 0;
		Debug.Log ("PATTERN3OFF");

	setupplayer = true;
	Invoke ("Setupplayerreset",2);
}




void Pattern4_0()
{
	pattern4_0on = true;
	patternreticle = true;
	ResetPattern ();


}



void Pattern4_1()
{
	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;

	fullcolorfade = false;

	pattern4_1on = true;



	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;
	level2.transform.localPosition = level2offposition;

	level3.transform.localPosition = level3offposition;
	level4_borders.transform.position = level1startposition;

	dotsound.volume = .5f;
	crackingthresholdsmall = 25;
	crackingthresholdmedium = 12;
	crackingthresholdmin = 13;



	dotsound.clip = sound1;
	dotsound.Play ();
	pattern4_0on = false;
}

void Pattern4_2()
{
	//Debug.Log ("called_pattern2_2");
	dotsound.clip = sound2;
	dotsound.Play ();
	pattern4_2on = true;
	pattern4_1on = false;

}

void Pattern4_3()
{
	dotsound.clip = sound3;
	dotsound.Play ();
	pattern4_3on = true;
	pattern4_2on = false;

}
void Pattern4_4()
{
	dotsound.clip = sound4;
	dotsound.Play ();
	pattern4_4on = true;
	pattern4_3on = false;

}

void Pattern4_5()
{

	pattern4_5on = true;
	pattern4_4on = false;
	patternreticle = false;
		

	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 2, 2f);

	level4floor2.GetComponent<Renderer> ().material = material1;
	level4floor1.GetComponent<Renderer> ().material = material1;

	level4lwall.GetComponent<Renderer> ().material = material1;
	level4rwall.GetComponent<Renderer> ().material = material1;
	level4bwall.GetComponent<Renderer> ().material = material1;
	level4fwall.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;		
	currentmaterial = material1;


	level2.transform.localPosition = level2offposition;
	level1.transform.localPosition = level1offposition;
	level3.transform.localPosition = level3offposition;

		spotlight.range = spotlightrange4;
	level3.transform.localPosition = level3offposition;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 3;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 3;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 3;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 3;





	//InvokeRepeating ("Movingwalls", 0, 5);
}

void Pattern4_off()
{



	pattern4_5on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempcolor4 = Color.white;

	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	tempvolume4 = 0;

	setupplayer = true;
	Invoke ("Setupplayerreset",2);
}




void Pattern5_0()
	{
		pattern5_0on = true;
		patternreticle = true;
		level5_borders.transform.localPosition = level5_bordersstartposition;

		ResetPattern ();

	}


void Pattern5_1()
{
	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;

	fullcolorfade = false;

	pattern5_1on = true;



	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

		fullcolorfade = false;
	dotsound.volume = .5f;
	crackingthresholdsmall = 30;
	level5_borders.transform.localPosition = level1startposition;

	crackingthresholdmedium = 15;


	dotsound.clip = sound4;
	dotsound.Play ();
	pattern5_0on = false;
}

void Pattern5_2()
{
	//Debug.Log ("called_pattern2_2");
	dotsound.clip = sound3;
	dotsound.Play ();
	pattern5_2on = true;
	pattern5_1on = false;

}

void Pattern5_3()
{
	dotsound.clip = sound2;
	dotsound.Play ();
	pattern5_3on = true;
	pattern5_2on = false;

}
void Pattern5_4()
{
	dotsound.clip = sound1;
	dotsound.Play ();
	pattern5_4on = true;
	pattern5_3on = false;

}

void Pattern5_5()
{

	pattern5_5on = true;
	pattern5_4on = false;
	patternreticle = false;

	out_level1.transform.position = outlineoffposition;

	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 2, 1.5f);

	spotlight.range = spotlightrange5;

	level4_floor.transform.localPosition = level3offposition;
	level4_borders.transform.localPosition = level3offposition;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 4;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 4;

	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 4;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 4;



	level5floor2.GetComponent<Renderer> ().material = material1;
	level5floor1.GetComponent<Renderer> ().material = material1;
	level5floor3.GetComponent<Renderer> ().material = material1;

	level5lwall.GetComponent<Renderer> ().material = material1;
	level5rwall.GetComponent<Renderer> ().material = material1;
	level5bwall.GetComponent<Renderer> ().material = material1;
	level5fwall.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;
	level5wall1.GetComponent<Renderer> ().material = material1;
	level5wall2.GetComponent<Renderer> ().material = material1;
	level5wall3.GetComponent<Renderer> ().material = material1;
	currentmaterial = material1;



	//InvokeRepeating ("Movingwalls", 0, 5);
}

void Pattern5_off()
{


	pattern5_5on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempcolor4 = Color.white;

	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	tempvolume4 = 0;

	setupplayer = true;
	Invoke ("Setupplayerreset",2);

}




void Pattern6_0()
{

	ResetPattern ();

	pattern6_0on = true;
	patternreticle = true;
	level6_borders.transform.localPosition = level6_bordersstartposition;


}



void Pattern6_1()
{
	Debug.Log ("AT PATTERN61");
	fullcolorfade = false;

	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;



	pattern6_1on = true;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	dotsound.volume = .5f;
	crackingthresholdsmall = 35;
	crackingthresholdmedium = 17;


	dotsound.clip = sound2;
	dotsound.Play ();
	pattern6_0on = false;
}

void Pattern6_2()
{
	//Debug.Log ("called_pattern2_2");
	Debug.Log ("AT PATTERN62");

	dotsound.clip = sound5;
	dotsound.Play ();
	pattern6_2on = true;
	pattern6_1on = false;

}

void Pattern6_3()
{
	dotsound.clip = sound4;
	dotsound.Play ();
	pattern6_3on = true;
	pattern6_2on = false;

}
void Pattern6_4()
{
	dotsound.clip = sound3;
	dotsound.Play ();
	pattern6_4on = true;
	pattern6_3on = false;

}

void Pattern6_5()
{
	dotsound.clip = sound1;
	dotsound.Play ();
	pattern6_5on = true;
	pattern6_4on = false;
}


void Pattern6_6()
{

	pattern6_6on = true;
	pattern6_5on = false;
	patternreticle = false;


	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 2, 1);
	spotlight.range = spotlightrange6;

	level5_floor.transform.localPosition = level3offposition;
	level5_borders.transform.localPosition = level3offposition;
		level1.transform.position = level1offposition;
		level2.transform.position = level2offposition;
	level3.transform.position = level3offposition;
	level4_floor.transform.position = level4offposition;
		level4_borders.transform.position = level4offposition;

	/*level6floor.GetComponent<Renderer> ().material = material1;
	level6lwall.GetComponent<Renderer> ().material = material1;
	level6rwall.GetComponent<Renderer> ().material = material1;
	level6bwall.GetComponent<Renderer> ().material = material1;
	level6fwall.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;*/





		InvokeRepeating ("Level6Explosions", 1, .5f);
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 5;


	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 5;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 5;




	//InvokeRepeating ("Movingwalls", 0, 5);
}

void Pattern6_off()
{	ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled =true;

	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;
	Debug.Log ("AT PATTERN60FF");


	pattern6_5on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempcolor4 = Color.white;
	tempcolor5 = Color.white;

	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	tempvolume4 = 0;
	tempvolume5 = 0;

	setupplayer = true;
	Invoke ("Setupplayerreset",2);
}






void Pattern7_0()
{

	ResetPattern ();

	fullcolorfade = false;

	pattern7_0on = true;
	patternreticle = true;
	CancelInvoke ("Level6Explosions");
	level7_borders.transform.localPosition = level7_bordersstartposition;


}



void Pattern7_1()
{

	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	fullcolorfade = false;




	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;

	dotsound.volume = .5f;
	crackingthresholdsmall = 40;
	crackingthresholdmedium = 25;
		crackingthresholdmin = 20;


	dotsound.clip = sound6;
	dotsound.Play ();

	pattern7_1on = true;
	pattern7_0on = false;
}

void Pattern7_2()
{
	//Debug.Log ("called_pattern2_2");
	fullcolorfade = false;

	dotsound.clip = sound3;
	dotsound.Play ();
	pattern7_2on = true;
	pattern7_1on = false;

}

void Pattern7_3()
{
	dotsound.clip = sound2;
	dotsound.Play ();
	pattern7_3on = true;
	pattern7_2on = false;

}
void Pattern7_4()
{
	dotsound.clip = sound5;
	dotsound.Play ();
	pattern7_4on = true;
	pattern7_3on = false;

}

void Pattern7_5()
{
	dotsound.clip = sound1;
	dotsound.Play ();
	pattern7_5on = true;
	pattern7_4on = false;

}

void Pattern7_6()
{
	dotsound.clip = sound4;
	dotsound.Play ();
	pattern7_6on = true;
	pattern7_5on = false;

}

void Pattern7_7()
{

	pattern7_7on = true;
	pattern7_6on = false;
	patternreticle = false;

	out_level1.transform.position = outlineoffposition;


	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
	InvokeRepeating ("MaterialChanger", 2, .7f);

	spotlight.range = spotlightrange7;
	cieling.GetComponent<Renderer> ().material = material1;


	level5_floor.transform.localPosition = level3offposition;
	level5_borders.transform.localPosition = level3offposition;
	level1.transform.position = level1offposition;
	level2.transform.position = level2offposition;
	level3.transform.position = level3offposition;
	level4_floor.transform.position = level4offposition;
	level4_borders.transform.position = level4offposition;
	level6_floor.transform.localPosition = level6offposition;
	level6_borders.transform.localPosition = level6offposition;

	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;

	InvokeRepeating ("Level7Explosions_1", 1, 3f);
	InvokeRepeating ("Level7Explosions_2", 2, 3f);
	//InvokeRepeating ("Level7Explosions_3", 2.5f, 3f);

	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 7;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 8;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;


	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Speed = 7;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().Distortion = 8;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;






	//InvokeRepeating ("Movingwalls", 0, 5);
}

void Pattern7_off()
{
	Debug.Log ("AT PATTERN60FF");


	pattern7_7on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempcolor4 = Color.white;
	tempcolor5 = Color.white;
	tempcolor6 = Color.white;


	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	tempvolume4 = 0;
	tempvolume5 = 0;
	tempvolume6 = 0;



		setupplayer = true;
		Invoke ("Setupplayerreset",2);
}







void Pattern8_0()
{
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled = false;
	ResetPattern ();

	Debug.Log ("AT PATTERN80");
	pattern8_0on = true;
	patternreticle = true;
	CancelInvoke ("Level7Explosions_1");
	CancelInvoke ("Level7Explosions_2");
	CancelInvoke ("Level7Explosions_3");
	red.SetFloat("_Cutoff",0);




}



void Pattern8_1()
{
	Debug.Log ("AT PATTERN81");
	fullcolorfade = false;

	//Debug.Log ("called_pattern2_1");
	ccamera.GetComponent<BlurOptimized>().enabled = false;
	ccamera_th.GetComponent<BlurOptimized>().enabled = false;

	//level1.transform.position = level1offposition;
	pattern8_1on = true;
	ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;

	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.white;
	dotsound.volume = .5f;
	crackingthresholdsmall = 40;
	crackingthresholdmedium = 25;
	crackingthresholdmin = 20;


	dotsound.clip = sound1;
	dotsound.volume = .5f;
	dotsound.Play ();
	pattern8_0on = false;


	level8wall1.GetComponent<Renderer> ().material = material1;
	level8wall2.GetComponent<Renderer> ().material = material1;
	level8wall3.GetComponent<Renderer> ().material = material1;
	level8wall4.GetComponent<Renderer> ().material = material1;
	cieling.GetComponent<Renderer> ().material = material1;
	floor.GetComponent<Renderer> ().material = material1;
	currentmaterial = material1;
	currentmaterial.SetTextureScale ("_MainTex", new Vector2 (2, 2));



}


void Pattern8_2()
{
	boss.transform.position = bossstartposition;
	QuadrantCheck ();


	pattern8_2on = true;
	pattern8_1on = false;
	patternreticle = false;


	LevelChange (levelcounter);
	Invoke ("ResetPatternTurningOff",2);
		spotlight.range = spotlightrange8;
	roomsound.clip = room1sound;
	roomsound.Play ();
		bosssound.Play ();

	/*level5_floor.transform.localPosition = level3offposition;
	level5_borders.transform.localPosition = level3offposition;
	level1.transform.position = level1offposition;
	level2.transform.position = level2offposition;
	level3.transform.position = level3offposition;
	level4_floor.transform.position = level4offposition;
	level4_borders.transform.position = level4offposition;
	level6_floor.transform.localPosition = level6offposition;
	level6_borders.transform.localPosition = level6offposition;
	level7_floor.transform.localPosition = level6offposition;
	level7_borders.transform.localPosition = level6offposition;*/

	//InvokeRepeating ("Level7Explosions_3", 2.5f, 3f);

		ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;
		ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;
		ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled = false;

	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled = false;





	//InvokeRepeating ("Movingwalls", 0, 5);
}

void Pattern8_off()
{
	Debug.Log ("AT PATTERN60FF");


	pattern8_2on = false;
	tempcolor1 = Color.white;
	tempcolor2 = Color.white;
	tempcolor3 = Color.white;
	tempcolor4 = Color.white;
	tempcolor5 = Color.white;
	tempcolor6 = Color.white;


	tempvolume1 = 0;
	tempvolume2 = 0;
	tempvolume3 = 0;
	tempvolume4 = 0;
	tempvolume5 = 0;
	tempvolume6 = 0;
	pattern8turningoff = false;
	currentmaterial.SetTextureScale ("_MainTex", new Vector2 (2, 2));
	InvokeRepeating ("DistanceChecker", 0, .1f);
	Invoke ("Setupplayerreset",2);


}



void Fadeout(float to)
{


		
		do {
		//Debug.Log("CALLED FADEOUTfrom : " + dotsound.volume + "to :" + to + "round1" + Mathf.Round(dotsound.volume*100) + "round2" + Mathf.Round(to*100));
		dotsound.volume = Mathf.Lerp (dotsound.volume, to, 10 * Time.deltaTime);
	//	ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, colorto, 10 * Time.deltaTime);

	} while (Mathf.Round(dotsound.volume*100)!= Mathf.Round(to*100));

}

void Fadein(float to)
{

		dotsound.volume = to;
	/*
	do {
		//Debug.Log("CALL FADE IN<from : " + dotsound.volume + "to :" + to + "round1" + Mathf.Round(dotsound.volume*100) + "round2" + Mathf.Round(to*100));
		dotsound.volume = Mathf.Lerp (dotsound.volume, to, 10 * Time.deltaTime);
		//ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB = Color.Lerp (ccamera.GetComponent<CameraFilterPack_Color_RGB> ().ColorRGB, colorto, 10 * Time.deltaTime);

	} while (Mathf.Round(dotsound.volume*100)!= Mathf.Round(to*100));*/

}

void FadeOutColor()
{
		fullcolordelay = false;
		fullcolorfade = true;
		



}
	


void Cracking()
{

	if (crackingdirection == 1 && ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small < crackingthresholdsmall ) {
			ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small += 1f * Time.deltaTime;
			ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small += 1f * Time.deltaTime;

	} else if (crackingdirection == 0 && ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small > crackingthresholdmin ) {
		ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small -= 1f * Time.deltaTime;
		ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Small -= 1f * Time.deltaTime;

		}

	if (crackingdirection == 1 && ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium < crackingthresholdmedium ) {
		ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium += 1f * Time.deltaTime;
		ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium += 1f * Time.deltaTime;

	} else if (crackingdirection == 0 && ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium > crackingthresholdmin ) {
		ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium -= 1f * Time.deltaTime;
		ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().Broken_Medium -= 1f * Time.deltaTime;

	}




}
void CrackingDirection()
{
		if (crackingdirection == 1)
			crackingdirection = 0;
		else
			crackingdirection = 1;


}


void RoachExplodeReset()
{
		roachexplode = false;
}

void RoachExplodeReset1()
{
	roachexplode = false;
}

void RoachExplodeReset2()
{
	roachexplode = false;
}

void RoachExplodeReset3()
{
	roachexplode = false;
}


void RoachExplodeReset4()
{
	roachexplode = false;
}


void RoachExplodeReset5()
{
	roachexplode = false;
}

void RoachExplodeReset6()
{
	roachexplode = false;
}






void Movingwalls()
{
		if (level4direction == 0)
			level4direction = 1;
		else
			level4direction = 0;

}




void BlackWhite()
{return;

		if (reticle.color == reticlecolor1)
			reticle.color = reticlecolor2;
		else
			reticle.color = reticlecolor1;
		reticlegroup.alpha = .8f;
}



void Headtouchoff()
{
	noisesound.Stop ();
	hudcamera.GetComponent<CameraFilterPack_Gradients_Therma>().enabled = false;
	hudcamera.GetComponent<CameraFilterPack_FX_EarthQuake >().enabled = false;

	hudcamera_th.GetComponent<CameraFilterPack_Gradients_Therma>().enabled = false;
	hudcamera_th.GetComponent<CameraFilterPack_FX_EarthQuake >().enabled = false;
}



void Level6Explosions()
	{
		int tempnum7 = Random.Range (1, 13);
		if (tempnum7 > levelxplthreshold)
			return;

		//levelxpl_sound.Stop ();
		CancelInvoke ("Levelxplshakereset");

		float randomx = Random.Range (-77, 189);
		randomx /= 100;
		Debug.Log ("randomx" + randomx);

		float randomz = Random.Range (-160, 50);
		randomz /= 100;
		Debug.Log ("randomz" + randomz);

		levelxplcounter++;
		levelxplshake = true;
		ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 40;
		ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = levelxpl_shakex;
		ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = levelxpl_shakey;
		ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
		ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 40;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = levelxpl_shakex;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = levelxpl_shakey;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;

		Invoke ("Levelxplshakereset", 1);
		


		switch (levelxplcounter) {
		case 1:
			levelxpl1.transform.position = new Vector3 (randomx, .078f, randomz);
			levelxpl1.Play ();
			levelxpl1_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound1.Play ();
			break;
		case 2:
			levelxpl2.transform.position = new Vector3 (randomx, -.021f, randomz);
			levelxpl2.Play ();
			levelxpl2_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound2.Play ();
			break;

		case 3:
			levelxpl3.transform.position = new Vector3 (randomx, -.025f, randomz);
			levelxpl3.Play ();
			levelxpl3_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound3.Play ();
			levelxplcounter = 0;
			if (levelxplthreshold < 10) {
				levelxplthreshold++;
				levelxpl_shakex += .002f;
				levelxpl_shakey += .002f;
			}
			break;
		case 4:
			levelxpl4.transform.position = new Vector3 (randomx, -.022f, randomz);
			levelxpl4.Play ();
			levelxpl4_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound4.Play ();

			break;
		case 5:
			levelxpl5.transform.position = new Vector3 (randomx, -.107f, randomz);
			levelxpl5.Play ();
			levelxpl5_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound5.Play ();
			levelxplcounter = 0;

			break;

		case 6:
			levelxpl6.transform.position = new Vector3 (randomx, -.069f, randomz);
			levelxpl6.Play ();
			levelxpl6_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
			levelxpl_sound6.Play ();
			levelxplcounter = 0;
			if (levelxplthreshold < 10) {
				levelxplthreshold++;
				levelxpl_shakex += .002f;
				levelxpl_shakey += .002f;
			}
			levelxplcounter = 0;

			break;


		}
	}



void Level7Explosions_1()
{


		int tempnum8 = Random.Range (1, 6);
		if (tempnum8 > 3)
			return;
	CancelInvoke ("Level7xpl1_shakereset");

		level7_xpl1.transform.position =level7_xplposition1;
		level7_xpl1.Play ();
		level7_xpl1_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
	if (level7_xpl1_sound1.isPlaying)level7_xpl1_sound1.Stop ();
		level7_xpl1_sound1.volume = 1.2f;
		level7_xpl1_sound1.Play ();

		Invoke ("Level7xpl1_shakereset", 1);

	levelxplshake = true;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 50;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .1f;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .1f;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 50;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .09f;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .1f;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;


}

	void Level7Explosions_2()
	{
	int tempnum8 = Random.Range (1, 6);
	if (tempnum8 > 3)
		return;
	
	CancelInvoke ("Level7xp2_shakereset");

	level7_xpl2.transform.position =level7_xplposition2;
	level7_xpl2.Play ();
	level7_xpl2_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
	if (level7_xpl2_sound1.isPlaying)level7_xpl2_sound1.Stop ();
		level7_xpl2_sound1.volume = 1.2f;
	level7_xpl2_sound1.Play ();

	Invoke ("Level7xpl2_shakereset", 1);

	levelxplshake = true;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 60;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .15f;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .15f;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Speed = 50;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().X = .1f;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().Y = .09f;
	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = true;


	}

	void Level7Explosions_3()
	{
		return;
		levelxpl3.transform.position =level7_xplposition3;
		levelxpl3.Play ();
		levelxpl3_light.GetComponent<ExplosionsLightCurves> ().OnEnable ();
		levelxpl_sound3.Play ();


	}








void Levelxplshakereset()
{
		levelxplshake = false;
		ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
		ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;

}

void Level7xpl1_shakereset()
{
	levelxplshake = false;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;



}

void Level7xpl2_shakereset()
{
	levelxplshake = false;
	ccamera.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
	ccamera.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;

	ccamera_th.GetComponent<CameraFilterPack_FX_EarthQuake > ().enabled = false;
	ccamera_th.GetComponent<CameraFilterPack_Glow_Glow> ().enabled = false;



}





void QuadrantCheck()
	{
		playerpos = GameObject.Find ("FPSController (head)").transform.position;


		if (playerpos.x > -.98 && playerpos.x <= .6145) {
			if (playerpos.z > -1.9 && playerpos.z <= -.553)
				quadrant = 1;
			else
				quadrant = 3;
		} else {
			if (playerpos.z > -1.9 && playerpos.z <= -.553)
				quadrant = 2;
			else
				quadrant = 4;

		}

	Debug.Log ("PLAYER IS IN QUADRANT " + quadrant + " with position : " + playerpos + " boss position:" + boss.transform.position);


	//boss.GetComponent<Rigidbody>().isKinematic=false;

		switch (quadrant) {
		case 1:
			boss.transform.position = bp4.position;
			//boss.transform.rotation = bossr2;
			Debug.Log ("here1");
	

			break;

		case 2:
			boss.transform.position = bp3.position;
		//boss.transform.rotation = bossr1;

		Debug.Log ("here2");

			break;

		case 3:
			boss.transform.position = bp2.position;
			//boss.transform.rotation = bossr4;;

		Debug.Log ("here3");

			break;

		case 4:
			boss.transform.position = bp1.position;
		//boss.transform.rotation = bossr3;

		Debug.Log ("here4");

			break;

		}
		boss.transform.rotation = bossrotation;
		Debug.Log (" boss position:" + boss.transform.position);

	boss.GetComponent<Rigidbody>().isKinematic=false;


	}


void SetInitialize()
{

	/*
		scoretext.gameObject.layer = 17;
	scoretext2.gameObject.layer = 17;
	levelcountertext.gameObject.layer = 17;
	levelcountertext2.gameObject.layer = 17;
	totaltimetext.gameObject.layer = 17;
	totaltimetext2.gameObject.layer = 17;*/




		tempvolume1 = 0;
		dotsound.volume = 0;
		outlinemoveaway = false;
		tttimeelapsed = 0;
		ccamera.backgroundColor = Color.black;
		ccamera.clearFlags = CameraClearFlags.Skybox;

	ccamera_th.backgroundColor = Color.black;
	ccamera_th.clearFlags = CameraClearFlags.Skybox;

		initialized = true;
		spotlight.enabled = true;
		P0.transform.transform.position = p0offposition;
		InvokeRepeating ("Cracking", 2, .01f);
		InvokeRepeating ("CrackingDirection", 2, 5);
		ccamera.GetComponent<VignetteAndChromaticAberration> ().enabled = true;
		ccamera.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled = true;
		ccamera.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = true;

	ccamera_th.GetComponent<VignetteAndChromaticAberration> ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_TV_BrokenGlass> ().enabled = true;
	ccamera_th.GetComponent<CameraFilterPack_Distortion_Dream2> ().enabled = true;

		

}




void MaterialChanger()
	{
		

		if (levelcounter == 2) {

			materialcounter++;


			switch (materialcounter) {
			case 1:
				floor.GetComponent<Renderer> ().material = material2;
				level2wall1.GetComponent<Renderer> ().material = material2;
				level2lwall.GetComponent<Renderer> ().material = material2;
				level2rwall.GetComponent<Renderer> ().material = material2;
				level2bwall.GetComponent<Renderer> ().material = material2;
				level2fwall.GetComponent<Renderer> ().material = material2;
				cieling.GetComponent<Renderer> ().material = material2;
				currentmaterial = material2;


				break;
			case 2:
				floor.GetComponent<Renderer> ().material = material1;
				level2wall1.GetComponent<Renderer> ().material = material1;
				level2lwall.GetComponent<Renderer> ().material = material1;
				level2rwall.GetComponent<Renderer> ().material = material1;
				level2bwall.GetComponent<Renderer> ().material = material1;
				level2fwall.GetComponent<Renderer> ().material = material1;
				cieling.GetComponent<Renderer> ().material = material1;		
				currentmaterial = material1;

				materialcounter = 0;
				break;
			}
			materialswitch.Play ();
			spotlight.enabled = false;
			Invoke ("ResetSpotlight", .05f);

		} else if (levelcounter == 3) {

			materialcounter++;


			switch (materialcounter) {
			case 1:
				floor.GetComponent<Renderer> ().material = material2;
				level3wall1.GetComponent<Renderer> ().material = material2;
				level3wall2.GetComponent<Renderer> ().material = material2;
				level3wall3.GetComponent<Renderer> ().material = material2;
				level3wall4.GetComponent<Renderer> ().material = material2;
				level3wall5.GetComponent<Renderer> ().material = material2;

				level3lwall.GetComponent<Renderer> ().material = material2;
				level3rwall.GetComponent<Renderer> ().material = material2;
				level3bwall.GetComponent<Renderer> ().material = material2;
				level3fwall.GetComponent<Renderer> ().material = material2;
				cieling.GetComponent<Renderer> ().material = material2;
				currentmaterial = material2;


				break;
			case 2:
				floor.GetComponent<Renderer> ().material = material3;
				level3wall1.GetComponent<Renderer> ().material = material3;
				level3wall2.GetComponent<Renderer> ().material = material3;
				level3wall3.GetComponent<Renderer> ().material = material3;
				level3wall4.GetComponent<Renderer> ().material = material3;
				level3wall5.GetComponent<Renderer> ().material = material3;
		
				level3lwall.GetComponent<Renderer> ().material = material3;
				level3rwall.GetComponent<Renderer> ().material = material3;
				level3bwall.GetComponent<Renderer> ().material = material3;
				level3fwall.GetComponent<Renderer> ().material = material3;
				cieling.GetComponent<Renderer> ().material = material3;		
				currentmaterial = material3;
				break;
			case 3:
				floor.GetComponent<Renderer> ().material = material1;
				level3wall1.GetComponent<Renderer> ().material = material1;
				level3wall2.GetComponent<Renderer> ().material = material1;
				level3wall3.GetComponent<Renderer> ().material = material1;
				level3wall4.GetComponent<Renderer> ().material = material1;
				level3wall5.GetComponent<Renderer> ().material = material1;

				level3lwall.GetComponent<Renderer> ().material = material1;
				level3rwall.GetComponent<Renderer> ().material = material1;
				level3bwall.GetComponent<Renderer> ().material = material1;
				level3fwall.GetComponent<Renderer> ().material = material1;
				cieling.GetComponent<Renderer> ().material = material1;		
				currentmaterial = material1;
				materialcounter = 0;
				break;
			
			}
			materialswitch.Play ();
			spotlight.enabled = false;
			Invoke ("ResetSpotlight", .05f);

		} else if (levelcounter == 4) {

			materialcounter++;


			switch (materialcounter) {
			case 1:
				level4floor2.GetComponent<Renderer> ().material = material2;
				level4floor1.GetComponent<Renderer> ().material = material2;

				level4lwall.GetComponent<Renderer> ().material = material2;
				level4rwall.GetComponent<Renderer> ().material = material2;
				level4bwall.GetComponent<Renderer> ().material = material2;
				level4fwall.GetComponent<Renderer> ().material = material2;
				cieling.GetComponent<Renderer> ().material = material2;
				currentmaterial = material2;


				break;
			case 2:
				level4floor2.GetComponent<Renderer> ().material = material3;
				level4floor1.GetComponent<Renderer> ().material = material3;

				level4lwall.GetComponent<Renderer> ().material = material3;
				level4rwall.GetComponent<Renderer> ().material = material3;
				level4bwall.GetComponent<Renderer> ().material = material3;
				level4fwall.GetComponent<Renderer> ().material = material3;
				cieling.GetComponent<Renderer> ().material = material3;		
				currentmaterial = material3;
				break;
			case 3:
				level4floor2.GetComponent<Renderer> ().material = material4;
				level4floor1.GetComponent<Renderer> ().material = material4;

				level4lwall.GetComponent<Renderer> ().material = material4;
				level4rwall.GetComponent<Renderer> ().material = material4;
				level4bwall.GetComponent<Renderer> ().material = material4;
				level4fwall.GetComponent<Renderer> ().material = material4;
				cieling.GetComponent<Renderer> ().material = material4;		
				currentmaterial = material4;
				break;

			case 4:
				level4floor2.GetComponent<Renderer> ().material = material1;
				level4floor1.GetComponent<Renderer> ().material = material1;

				level4lwall.GetComponent<Renderer> ().material = material1;
				level4rwall.GetComponent<Renderer> ().material = material1;
				level4bwall.GetComponent<Renderer> ().material = material1;
				level4fwall.GetComponent<Renderer> ().material = material1;
				cieling.GetComponent<Renderer> ().material = material1;		
				currentmaterial = material1;
				materialcounter = 0;
				break;

			}
			materialswitch.Play ();
			spotlight.enabled = false;
			Invoke ("ResetSpotlight", .05f);

		} else if (levelcounter == 5) {

			materialcounter++;


			switch (materialcounter) {
			case 1:
				level5floor2.GetComponent<Renderer> ().material = material2;
				level5floor1.GetComponent<Renderer> ().material = material2;
				level5floor3.GetComponent<Renderer> ().material = material2;

				level5lwall.GetComponent<Renderer> ().material = material2;
				level5rwall.GetComponent<Renderer> ().material = material2;
				level5bwall.GetComponent<Renderer> ().material = material2;
				level5fwall.GetComponent<Renderer> ().material = material2;
				cieling.GetComponent<Renderer> ().material = material2;
				level5wall1.GetComponent<Renderer> ().material = material2;
				level5wall2.GetComponent<Renderer> ().material = material2;
				level5wall3.GetComponent<Renderer> ().material = material2;



				currentmaterial = material2;


				break;
			case 2:
				level5floor2.GetComponent<Renderer> ().material = material3;
				level5floor1.GetComponent<Renderer> ().material = material3;
				level5floor3.GetComponent<Renderer> ().material = material3;

				level5lwall.GetComponent<Renderer> ().material = material3;
				level5rwall.GetComponent<Renderer> ().material = material3;
				level5bwall.GetComponent<Renderer> ().material = material3;
				level5fwall.GetComponent<Renderer> ().material = material3;
				cieling.GetComponent<Renderer> ().material = material3;
				level5wall1.GetComponent<Renderer> ().material = material3;
				level5wall2.GetComponent<Renderer> ().material = material3;
				level5wall3.GetComponent<Renderer> ().material = material3;
				currentmaterial = material3;
				break;
			case 3:
				level5floor2.GetComponent<Renderer> ().material = material4;
				level5floor1.GetComponent<Renderer> ().material = material4;
				level5floor3.GetComponent<Renderer> ().material = material4;

				level5lwall.GetComponent<Renderer> ().material = material4;
				level5rwall.GetComponent<Renderer> ().material = material4;
				level5bwall.GetComponent<Renderer> ().material = material4;
				level5fwall.GetComponent<Renderer> ().material = material4;
				cieling.GetComponent<Renderer> ().material = material4;
				level5wall1.GetComponent<Renderer> ().material = material4;
				level5wall2.GetComponent<Renderer> ().material = material4;
				level5wall3.GetComponent<Renderer> ().material = material4;
				currentmaterial = material4;
				break;

			case 4:
				level5floor2.GetComponent<Renderer> ().material = material5;
				level5floor1.GetComponent<Renderer> ().material = material5;
				level5floor3.GetComponent<Renderer> ().material = material5;

				level5lwall.GetComponent<Renderer> ().material = material5;
				level5rwall.GetComponent<Renderer> ().material = material5;
				level5bwall.GetComponent<Renderer> ().material = material5;
				level5fwall.GetComponent<Renderer> ().material = material5;
				cieling.GetComponent<Renderer> ().material = material5;
				level5wall1.GetComponent<Renderer> ().material = material5;
				level5wall2.GetComponent<Renderer> ().material = material5;
				level5wall3.GetComponent<Renderer> ().material = material5;
				currentmaterial = material5;
				break;

			case 5:
				level5floor2.GetComponent<Renderer> ().material = material1;
				level5floor1.GetComponent<Renderer> ().material = material1;
				level5floor3.GetComponent<Renderer> ().material = material1;

				level5lwall.GetComponent<Renderer> ().material = material1;
				level5rwall.GetComponent<Renderer> ().material = material1;
				level5bwall.GetComponent<Renderer> ().material = material1;
				level5fwall.GetComponent<Renderer> ().material = material1;
				cieling.GetComponent<Renderer> ().material = material1;
				level5wall1.GetComponent<Renderer> ().material = material1;
				level5wall2.GetComponent<Renderer> ().material = material1;
				level5wall3.GetComponent<Renderer> ().material = material1;
				currentmaterial = material1;
				materialcounter = 0;
				break;


			}
			materialswitch.Play ();
			spotlight.enabled = false;
			Invoke ("ResetSpotlight", .05f);
		}

		else if (levelcounter == 6) {

			materialcounter++;


			switch (materialcounter) {
			case 1:
		

				level6lwall.GetComponent<Renderer> ().material = material2;
				level6rwall.GetComponent<Renderer> ().material = material2;
				level6bwall.GetComponent<Renderer> ().material = material2;
				level6fwall.GetComponent<Renderer> ().material = material2;
				cieling.GetComponent<Renderer> ().material = material2;
				level6floor.GetComponent<Renderer> ().material = material2;



				currentmaterial = material2;


				break;
			case 2:
				level6lwall.GetComponent<Renderer> ().material = material3;
				level6rwall.GetComponent<Renderer> ().material = material3;
				level6bwall.GetComponent<Renderer> ().material = material3;
				level6fwall.GetComponent<Renderer> ().material = material3;
				cieling.GetComponent<Renderer> ().material = material3;
				level6floor.GetComponent<Renderer> ().material = material3;

				currentmaterial = material3;
				break;
			case 3:
				level6lwall.GetComponent<Renderer> ().material = material4;
				level6rwall.GetComponent<Renderer> ().material = material4;
				level6bwall.GetComponent<Renderer> ().material = material4;
				level6fwall.GetComponent<Renderer> ().material = material4;
				cieling.GetComponent<Renderer> ().material = material4;
				level6floor.GetComponent<Renderer> ().material = material4;

				currentmaterial = material4;
				break;

			case 4:
				level6lwall.GetComponent<Renderer> ().material = material5;
				level6rwall.GetComponent<Renderer> ().material = material5;
				level6bwall.GetComponent<Renderer> ().material = material5;
				level6fwall.GetComponent<Renderer> ().material = material5;
				cieling.GetComponent<Renderer> ().material = material5;
				level6floor.GetComponent<Renderer> ().material = material5;

				currentmaterial = material5;
				break;

			case 5:
				level6lwall.GetComponent<Renderer> ().material = material6;
				level6rwall.GetComponent<Renderer> ().material = material6;
				level6bwall.GetComponent<Renderer> ().material = material6;
				level6fwall.GetComponent<Renderer> ().material = material6;
				cieling.GetComponent<Renderer> ().material = material6;
				level6floor.GetComponent<Renderer> ().material = material6;

				currentmaterial = material6;
				break;
			case 6:
				level6lwall.GetComponent<Renderer> ().material = material1;
				level6rwall.GetComponent<Renderer> ().material = material1;
				level6bwall.GetComponent<Renderer> ().material = material1;
				level6fwall.GetComponent<Renderer> ().material = material1;
				cieling.GetComponent<Renderer> ().material = material1;
				level6floor.GetComponent<Renderer> ().material = material1;

				currentmaterial = material1;
				materialcounter = 0;
				break;


			}
			materialswitch.Stop ();
			materialswitch.Play ();
			spotlight.enabled = false;
			Invoke ("ResetSpotlight", .05f);

		}
	else if (levelcounter == 7) {

		materialcounter++;


		switch (materialcounter) {
		case 1:


			level7lwall.GetComponent<Renderer> ().material = material2;
			level7rwall.GetComponent<Renderer> ().material = material2;
			level7bwall.GetComponent<Renderer> ().material = material2;
			level7fwall.GetComponent<Renderer> ().material = material2;
			level7wall1.GetComponent<Renderer> ().material = material2;
			level7wall2.GetComponent<Renderer> ().material = material2;
			level7wall3.GetComponent<Renderer> ().material = material2;
			level7wall4.GetComponent<Renderer> ().material = material2;
			level7wall5.GetComponent<Renderer> ().material = material2;
			level7wall6.GetComponent<Renderer> ().material = material2;
			level7wall7.GetComponent<Renderer> ().material = material2;
			level7wall8.GetComponent<Renderer> ().material = material2;
			level7wall9.GetComponent<Renderer> ().material = material2;

			level7floor1.GetComponent<Renderer> ().material = material2;
			level7floor2.GetComponent<Renderer> ().material = material2;

			cieling.GetComponent<Renderer> ().material = material2;

			currentmaterial = material2;


			break;
		case 2:
			level7lwall.GetComponent<Renderer> ().material = material3;
			level7rwall.GetComponent<Renderer> ().material = material3;
			level7bwall.GetComponent<Renderer> ().material = material3;
			level7fwall.GetComponent<Renderer> ().material = material3;
			level7wall1.GetComponent<Renderer> ().material = material3;
			level7wall2.GetComponent<Renderer> ().material = material3;
			level7wall3.GetComponent<Renderer> ().material = material3;
			level7wall4.GetComponent<Renderer> ().material = material3;
			level7wall5.GetComponent<Renderer> ().material = material3;
			level7wall6.GetComponent<Renderer> ().material = material3;
			level7wall7.GetComponent<Renderer> ().material = material3;
			level7wall8.GetComponent<Renderer> ().material = material3;
			level7wall9.GetComponent<Renderer> ().material = material3;
			level7floor1.GetComponent<Renderer> ().material = material3;
			level7floor2.GetComponent<Renderer> ().material = material3;			
			cieling.GetComponent<Renderer> ().material = material3;

			currentmaterial = material3;
			break;
		case 3:
			level7lwall.GetComponent<Renderer> ().material = material4;
			level7rwall.GetComponent<Renderer> ().material = material4;
			level7bwall.GetComponent<Renderer> ().material = material4;
			level7fwall.GetComponent<Renderer> ().material = material4;
			level7wall1.GetComponent<Renderer> ().material = material4;
			level7wall2.GetComponent<Renderer> ().material = material4;
			level7wall3.GetComponent<Renderer> ().material = material4;
			level7wall4.GetComponent<Renderer> ().material = material4;
			level7wall5.GetComponent<Renderer> ().material = material4;
			level7wall6.GetComponent<Renderer> ().material = material4;
			level7wall7.GetComponent<Renderer> ().material = material4;
			level7wall8.GetComponent<Renderer> ().material = material4;
			level7wall9.GetComponent<Renderer> ().material = material4;
			level7floor1.GetComponent<Renderer> ().material = material4;
			level7floor2.GetComponent<Renderer> ().material = material4;			
			cieling.GetComponent<Renderer> ().material = material4;

			currentmaterial = material4;
			break;

		case 4:
			level7lwall.GetComponent<Renderer> ().material = material5;
			level7rwall.GetComponent<Renderer> ().material = material5;
			level7bwall.GetComponent<Renderer> ().material = material5;
			level7fwall.GetComponent<Renderer> ().material = material5;
			level7wall1.GetComponent<Renderer> ().material = material5;
			level7wall2.GetComponent<Renderer> ().material = material5;
			level7wall3.GetComponent<Renderer> ().material = material5;
			level7wall4.GetComponent<Renderer> ().material = material5;
			level7wall5.GetComponent<Renderer> ().material = material5;
			level7wall6.GetComponent<Renderer> ().material = material5;
			level7wall7.GetComponent<Renderer> ().material = material5;
			level7wall8.GetComponent<Renderer> ().material = material5;
			level7wall9.GetComponent<Renderer> ().material = material5;

			level7floor1.GetComponent<Renderer> ().material = material5;
			level7floor2.GetComponent<Renderer> ().material = material5;		
			cieling.GetComponent<Renderer> ().material = material5;

			currentmaterial = material5;
			break;

		case 5:
			level7lwall.GetComponent<Renderer> ().material = material6;
			level7rwall.GetComponent<Renderer> ().material = material6;
			level7bwall.GetComponent<Renderer> ().material = material6;
			level7fwall.GetComponent<Renderer> ().material = material6;
			level7wall1.GetComponent<Renderer> ().material = material6;
			level7wall2.GetComponent<Renderer> ().material = material6;
			level7wall3.GetComponent<Renderer> ().material = material6;
			level7wall4.GetComponent<Renderer> ().material = material6;
			level7wall5.GetComponent<Renderer> ().material = material6;
			level7wall6.GetComponent<Renderer> ().material = material6;
			level7wall7.GetComponent<Renderer> ().material = material6;
			level7wall8.GetComponent<Renderer> ().material = material6;
			level7wall9.GetComponent<Renderer> ().material = material6;

			level7floor1.GetComponent<Renderer> ().material = material6;
			level7floor2.GetComponent<Renderer> ().material = material6;	
			cieling.GetComponent<Renderer> ().material = material6;

			currentmaterial = material6;
			break;
		case 6:
			level7lwall.GetComponent<Renderer> ().material = material1;
			level7rwall.GetComponent<Renderer> ().material = material1;
			level7bwall.GetComponent<Renderer> ().material = material1;
			level7fwall.GetComponent<Renderer> ().material = material1;
			level7wall1.GetComponent<Renderer> ().material = material1;
			level7wall2.GetComponent<Renderer> ().material = material1;
			level7wall3.GetComponent<Renderer> ().material = material1;
			level7wall4.GetComponent<Renderer> ().material = material1;
			level7wall5.GetComponent<Renderer> ().material = material1;
			level7wall6.GetComponent<Renderer> ().material = material1;
			level7wall7.GetComponent<Renderer> ().material = material1;
			level7wall8.GetComponent<Renderer> ().material = material1;
			level7wall9.GetComponent<Renderer> ().material = material1;

			level7floor1.GetComponent<Renderer> ().material = material1;
			level7floor2.GetComponent<Renderer> ().material = material1;
			cieling.GetComponent<Renderer> ().material = material1;

			currentmaterial = material1;
			materialcounter = 0;
			break;


		}
		if (materialswitch.isPlaying)materialswitch.Stop ();
		materialswitch.Play ();
		spotlight.enabled = false;
		Invoke ("ResetSpotlight", .05f);

	}








	}


	void ResetSpotlight()
	{


		spotlight.enabled=true;


}






		void DistanceChecker()
		{

	distance = Vector3.Distance (GameObject.Find("FPSController (eye)").transform.position, boss.transform.position);
		Debug.Log ("DISTANCE = " + distance);





		}



void Together()

{		
		bosssound.Stop ();
		bossanimator.SetInteger("Deathcounter",2);
		red.SetFloat ("_Cutoff", 0);
		green.SetFloat ("_Cutoff", 0);
		blue.SetFloat ("_Cutoff", 0);
		cyan.SetFloat ("_Cutoff", 0);
		yellow.SetFloat ("_Cutoff", 0);
		magenta.SetFloat ("_Cutoff", 0);
		dotsound.volume = 0;
		soundtogether.volume = 0;
		soundtogether.Play ();
		alltogether = true;
		holdoff = false;
		floor_rest.transform.position = flooroffposition;

}


void Death()
{
	//END2
	end = true;
		Fadeout (0);
		alltogether = false;
	//wallsound.Play();
	//startcube.transform.position = startcubestartposition;
	//spotlight.enabled = false;
	//floor_start.transform.position = floor_startonposition;
	startcube.gameObject.layer = 0;
	//floor_start.gameObject.layer = 0;
	//	startpointlight.enabled = true;
	//level8.transform.position = level1offposition;
	//floor.transform.position = flooroffposition;
	//boss.transform.position = bossoffposition;
	//structure.transform.position = structureoffposition;
	//cieling.transform.position = cielingoffposition;
	grid.transform.position = gridonposition;

	//roomsound.Stop ();

}


void BoxCollider()
{
	GameObject.Find (currentroach).GetComponent<BoxCollider> ().enabled = false;
	levelcounter = 0;

}


void Restart()
{
	Application.LoadLevel(Application.loadedLevel);


}




void ResetPattern()
{
	P1.transform.localPosition = p1offposition;
	P2.transform.localPosition = p2offposition;
	P3.transform.localPosition = p3offposition;
	P4.transform.localPosition = p4offposition;
	P5.transform.localPosition = p5offposition;
	P6.transform.localPosition = p6offposition;
		scorecount = 0;
		level1.transform.localPosition = level1offposition;

	red.SetFloat ("_Cutoff", 0);
	green.SetFloat ("_Cutoff", 0);
	blue.SetFloat ("_Cutoff", 0);
	cyan.SetFloat ("_Cutoff", 0);
	yellow.SetFloat ("_Cutoff", 0);
	magenta.SetFloat ("_Cutoff", 0);
		

}


void Idler()
{


		if ( Mathf.Abs(idleposition.x - GameObject.Find ("FPSController (head)").transform.position.x) < .001f) {
		if (Mathf.Abs(idleposition.z - GameObject.Find ("FPSController (head)").transform.position.z) < .001f) {
			if (Mathf.Abs(idlerotation.x - GameObject.Find ("FPSController (head)").transform.rotation.x) < .001f) {
				if (Mathf.Abs(idlerotation.z - GameObject.Find ("FPSController (head)").transform.rotation.z) < .001f) {
					if (Mathf.Abs(idlerotation.y - GameObject.Find ("FPSController (head)").transform.rotation.y) < .001f) {
						

							Debug.Log ("deadDDDDDD");
							idlethreshhold += Time.deltaTime;
								}else idlethreshhold = 0;
						}else idlethreshhold = 0;
				}else idlethreshhold = 0;
			}else idlethreshhold = 0;
		}
		else {
			idlethreshhold = 0;
		}




	idleposition=GameObject.Find("FPSController (head)").transform.position;
	idlerotation=GameObject.Find("FPSController (head)").transform.rotation;



	Debug.Log ("idlethresh: " + idlethreshhold + " idlepos : " + idleposition + " player: " + GameObject.Find ("FPSController (head)").transform.position );

		if (idlethreshhold > 2f) {
			Restart ();
		}


}


void Setupplayerreset()
{

		setupplayer = false;
		forcedprogress = false;
}


}


