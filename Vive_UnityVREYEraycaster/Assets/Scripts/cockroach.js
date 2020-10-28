#pragma strict


private var rotation1:Quaternion;
private var rotation2:Quaternion;
private var rotation3:Quaternion;
private var rotation4:Quaternion;
private var rotation5:Quaternion;
private var rotation6:Quaternion;
private var rotation7:Quaternion;
private var rotation8:Quaternion;
private var rotation9:Quaternion;
private var rotation10:Quaternion;
private var rotation11:Quaternion;
private var rotation12:Quaternion;
private var rotation13:Quaternion;
private var rotation14:Quaternion;
private var rotation15:Quaternion;
private var rotation16:Quaternion;
private var rotation17:Quaternion;


private var targetrotation:Quaternion;
private var counter:int;
private var comehome:boolean;
private var playertransform:Transform;
private var proximitylimit = 3.0;
private var proximityminlimit = 1.0;
private var animator:Animator;
private var stop:boolean;
private var direction:int;
private var hardreset:boolean;
private var speed:float;
private var cockroachsound:AudioSource;
private var playertouch:boolean;
private var temppitch:float;
public var start:boolean;
public var cameraposition:CameraPosition;
public var roachinteraction:RoachInteraction;
private var headstart:boolean;
public var mastercontrols:MasterControls;
public var on:boolean;
private var turnaround:boolean;
private var counter2:int;

public var roachname:String;
public var storageposition:Vector3;
public var snakematerial:Material;
private var currentdead:Transform;
private var killed:boolean;

private var explosion1:GameObject;
private var explosion2:GameObject;
private var explosion3:GameObject;
private var explosion4:GameObject;
private var explosion5:GameObject;
private var explosion6:GameObject;


public var r1p:Vector3;
public var r2p:Vector3;
public var r3p:Vector3;
public var r4p:Vector3;
public var r5p:Vector3;
public var r6p:Vector3;
public var r7p:Vector3;
public var r8p:Vector3;
public var r9p:Vector3;
public var r10p:Vector3;
public var r11p:Vector3;
public var r12p:Vector3;
public var r13p:Vector3;
public var r14p:Vector3;
public var r15p:Vector3;
public var r16p:Vector3;
public var r17p:Vector3;
public var r18p:Vector3;
public var r19p:Vector3;
public var r20p:Vector3;
public var r21p:Vector3;
public var r22p:Vector3;
public var r23p:Vector3;
public var r24p:Vector3;
public var r25p:Vector3;

private var collthresh:int;
private var collthresh2:float;
private var tempPos:Vector3;

private var hardreset2:boolean;
private var level7scaler:boolean;
private var level8distance:boolean;
private var quadrant:int;
private var playerpos:Vector3;
private var bossposq1:Vector3;
private var bossposq2:Vector3;
private var bossposq3:Vector3;
private var bossposq4:Vector3;

private var speed1:float=.7f;
private var speed2:float=.8f;
private var speed3:float=.9f;
private var speed4:float=1f;
private var speed5:float=1f;
private var speed6:float=1f;
private var speed7:float=1f;
private var speed8:float=1f;


/*private var speed4:float = 1f;
private var speed3:float =.85f;
private var speed2:float = .7f;
private var speed1:float=.6f;*/
//private var speed5:float=1f;
//private var speed6:float=1.1;
//private var speed7:float=1.2f;
//private var speed8:float=1;




private var cockroachspawnpoint:Vector3=Vector3(.668,-.201,-0.568);



function Start () {


bossposq1=Vector3(-.239,-.210655,-1.0499);
bossposq2=Vector3(1.378,-.210655,-.94418);
bossposq3=Vector3(-.236,-.210655,.063);
bossposq4=Vector3(1.409,-.210655,.08);

transform.position=Vector3(4,-20,4);


explosion1=GameObject.Find("Smoke1");
explosion2=GameObject.Find("Smoke2");
explosion3=GameObject.Find("Smoke3");
explosion4=GameObject.Find("Smoke4");
explosion5=GameObject.Find("Smoke5");
explosion6=GameObject.Find("Smoke6");


r1p=Vector3(-24.3,-81.387,-96.09);
r2p=Vector3(-22.9,-81.387,-95.74);
r3p=Vector3(-24.995,-81.387,-94.6);
//r3p=Vector3(-22.714,-81.387,-95.749);debug

r4p=Vector3(-23.54,-81.387,-95.36);
r5p=Vector3(-23.74,-81.387,-95.768);
//r5p=Vector3(-23.53,-81.387,-95.155);debug
r6p=Vector3(-23.4,-81.387,-94.793);
//r6p=Vector3(-23.7,-81.387,-95.229);debug
r7p=Vector3(-22.77,-81.387,-96.144);
r8p=Vector3(-24.6,-81.387,-96.015);
r9p=Vector3(-22.5,-81.387,-94.2);
r10p=Vector3(-24.3,-81.387,-94.2);
r11p=Vector3(-25.14,-81.357,-95.85);
r12p=Vector3(-24.28,-81.326,-94.473);
r13p=Vector3(-22.7,-81.357,-96.09);
r14p=Vector3(-22.775,-81.3266,-96.234);
r15p=Vector3(-23.378,-81.357,-95.472);
r16p=Vector3(-24.501,-81.357,-95.119);
r17p=Vector3(-22.7,-81.357,-95.448);
r18p=Vector3(-23.27,-81.357,-94.96);
r19p=Vector3(-24.662,-81.357,-94.636);
r20p=Vector3(-24.662,-81.357,-95.568);

r21p=Vector3(-25.155,-81.357,-95.119);
r22p=Vector3(-22.7,-81.357,-96.082);
r23p=Vector3(-23.832,-81.357,-96.082);
r24p=Vector3(-23.267,-81.357,-95.681);
r25p=Vector3(-24.05,-81.357,-95.383);



roachname=gameObject.name;
storageposition=Vector3(-24.3,-71.3,-96);
speed=.8f;
cockroachsound = GetComponent.<AudioSource>();
animator = GetComponent(Animator);
InvokeRepeating("Reset",0,.5f);
rotation1=GameObject.Find("cockroach_1").transform.rotation;
rotation2=GameObject.Find("cockroach_2").transform.rotation;
rotation3=GameObject.Find("cockroach_3").transform.rotation;
rotation4=GameObject.Find("cockroach_4").transform.rotation;
rotation5=GameObject.Find("cockroach_5").transform.rotation;
rotation6=GameObject.Find("cockroach_6").transform.rotation;
rotation7=GameObject.Find("cockroach_7").transform.rotation;
rotation8=GameObject.Find("cockroach_8").transform.rotation;
rotation9=GameObject.Find("cockroach_9").transform.rotation;
rotation10=GameObject.Find("cockroach_10").transform.rotation;
rotation11=GameObject.Find("cockroach_11").transform.rotation;
rotation12=GameObject.Find("cockroach_12").transform.rotation;
rotation13=GameObject.Find("cockroach_13").transform.rotation;
rotation14=GameObject.Find("cockroach_14").transform.rotation;
rotation15=GameObject.Find("cockroach_15").transform.rotation;
rotation16=GameObject.Find("cockroach_16").transform.rotation;
rotation17=GameObject.Find("cockroach_17").transform.rotation;
targetrotation=rotation1;
direction=1;
temppitch=Random.Range(70,120);
temppitch=temppitch/100;
cockroachsound.pitch=temppitch;
animator.SetBool ("Pause", true);
//Invoke("Distancechecker",1);


}

function Update () {

//Debug.Log("MY NAME IS : " + gameObject.name + " and direction is " + direction + " and colltresh is " + collthresh + " hardreset:" + hardreset);

//if (mastercontrols.pattern && start)start=false;


if (gameObject.transform.position.y<-83 && gameObject.tag!=tag)
{
transform.position=cockroachspawnpoint;

}



if (mastercontrols.gamestart && !start && (roachname=="1"))
{
if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=.5f;
//speed=0;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
gameObject.transform.localPosition=r1p;
start=true;


}

else if (mastercontrols.levelcounter==2 && !start && !mastercontrols.pattern && (roachname=="2" || roachname=="3"))
{
//gameObject.transform.position=r2p;

	gameObject.layer=0;
	if (gameObject.name=="2")transform.localPosition=r2p;
	if (gameObject.name=="3")transform.localPosition=r3p;

	if (!cockroachsound.isPlaying)cockroachsound.Play();
	speed=speed2;
	//speed=0;
	gameObject.GetComponent.<Rigidbody>().isKinematic=false;
	start=true;

}



else if (mastercontrols.levelcounter==3 && !start &&  !mastercontrols.pattern && (roachname=="4" || roachname=="5" || roachname=="6"))
{

	if (gameObject.name=="4")transform.localPosition=r4p;
	if (gameObject.name=="5")transform.localPosition=r5p;
	if (gameObject.name=="6")transform.localPosition=r6p;

if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=speed3;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;

}
//(roachname=="7" || roachname=="8" || roachname=="9" || roachname=="10")
//|| roachname=="8" || roachname=="9" || roachname=="10"
else if (mastercontrols.levelcounter==4 && !start && !mastercontrols.pattern && (roachname=="7" || roachname=="8" || roachname=="9" || roachname=="10" ))
{

	if (gameObject.name=="7")transform.localPosition=r7p;
	if (gameObject.name=="8")transform.localPosition=r8p;
	if (gameObject.name=="9")transform.localPosition=r9p;
	if (gameObject.name=="10")transform.localPosition=r10p;


if (!cockroachsound.isPlaying)cockroachsound.Play();

speed=speed4;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;


}
else if( mastercontrols.levelcounter==5 && !start && !mastercontrols.pattern && (roachname=="11" || roachname=="12" || roachname=="13" || roachname=="14")) 
{
	if (gameObject.name=="11")transform.localPosition=r11p;
	if (gameObject.name=="12")transform.localPosition=r12p;
	if (gameObject.name=="13")transform.localPosition=r13p;
	if (gameObject.name=="14")transform.localPosition=r14p;

if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=speed5;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;

}

else if( mastercontrols.levelcounter==6 && !start && !mastercontrols.pattern && (roachname=="15" || roachname=="16" || roachname=="17" || roachname=="18" || roachname=="19")) 
{

	if (gameObject.name=="15")transform.localPosition=r15p;
	if (gameObject.name=="16")transform.localPosition=r16p;
	if (gameObject.name=="17")transform.localPosition=r17p;
	if (gameObject.name=="18")transform.localPosition=r18p;
	if (gameObject.name=="19")transform.localPosition=r19p;


if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=speed6;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;

}
//(roachname=="20" || roachname=="21" || roachname=="22" || roachname=="23" || roachname=="24" || roachname=="25" )
else if( mastercontrols.levelcounter==7 && !start && !mastercontrols.pattern && (roachname=="20" || roachname=="21" || roachname=="22" || roachname=="23" || roachname=="24" || roachname=="25" )) 
{
	if (gameObject.name=="20")transform.localPosition=r20p;
	if (gameObject.name=="21")transform.localPosition=r21p;
	if (gameObject.name=="22")transform.localPosition=r22p;
	if (gameObject.name=="23")transform.localPosition=r23p;
	if (gameObject.name=="24")transform.localPosition=r24p;
	if (gameObject.name=="25")transform.localPosition=r25p;

if (!level7scaler)
{
level7scaler=true;
InvokeRepeating("Level7scaler",1,1);
}
if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=speed7;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;
Physics.IgnoreCollision (GameObject.Find ("77wall0").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall1").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall2").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall3").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall4").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall5").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall6").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall7").GetComponent.<Collider> (), GetComponent.<Collider> ());
Physics.IgnoreCollision (GameObject.Find ("77wall8").GetComponent.<Collider> (), GetComponent.<Collider> ());
//Physics.IgnoreCollision (GameObject.Find ("77wall9").GetComponent.<Collider> (), GetComponent.<Collider> ());
//Physics.IgnoreCollision (GameObject.Find ("77wall10").GetComponent.<Collider> (), GetComponent.<Collider> ());

}

else if( mastercontrols.levelcounter==8 && !start && !mastercontrols.pattern && (roachname=="26"))
{


CancelInvoke("Reset");
animator.SetBool ("Pause", false);
if (!cockroachsound.isPlaying)cockroachsound.Play();
speed=0f;
gameObject.GetComponent.<Rigidbody>().isKinematic=false;
start=true;

}



if (gameObject.tag=="deaded")
{
gameObject.transform.position=storageposition;
animator.SetBool ("Dead", true);
gameObject.GetComponent.<Rigidbody>().isKinematic=true;
gameObject.GetComponent.<BoxCollider> ().enabled = true;
cockroachsound.Stop();

}


if (gameObject.tag=="dead" && !killed)
{


if (mastercontrols.roachexplode && mastercontrols.levelcounter!=8 )
{
/*
var tempposition1=gameObject.transform.position;
tempposition1.y+=.15f;

/*if (mastercontrols.explosioncounter==1)
explosion1.transform.position=tempposition1;
else if (mastercontrols.explosioncounter==2)
explosion2.transform.position=tempposition1;*/


//gameObject.transform.position=storageposition;
}

animator.SetBool ("Dead", true);
gameObject.GetComponent.<Rigidbody>().isKinematic=true;
gameObject.GetComponent.<BoxCollider> ().enabled = true;
cockroachsound.Stop();
gameObject.GetComponent.<AudioSource>().volume=0;
gameObject.tag="deaded";
CancelInvoke("Reset");
on=false;
killed=true;
Invoke("ResetKilled",.5f);

}



if (start && gameObject.tag!="dead" && gameObject.tag!="deaded" )
{



if (collthresh>0){
Hardreset();

}
//Debug.Log("comehome" + comehome);
playertransform=GameObject.Find("FPSController (origin)").transform;

var offset=playertransform.position-transform.position;
var sqrLen=offset.sqrMagnitude;

/*if (sqrLen > proximitylimit*proximitylimit)
{
comehome=true;
}

if (sqrLen < proximityminlimit*proximityminlimit)
{
comehome=false;
}*/

playertransform=GameObject.Find("FPSController (origin)").transform;

if (Input.GetKey("h"))
{
//comehome=true;
}

if (Input.GetKey("j"))
{
comehome=false;
}


		


		if (mastercontrols.levelcounter!=8)
		{


		if (stop)
		{
		animator.SetBool ("Pause", true);
		cockroachsound.Stop();

		}
		else
		{
		animator.SetBool ("Pause", false);
		if (!cockroachsound.isPlaying)cockroachsound.Play();


		}

		//Debug.Log(transform.rotation.y);
			if (!stop && !mastercontrols.pattern)
			{
			animator.SetBool ("Pause", false);	
			if (!cockroachsound.isPlaying)cockroachsound.Play();


			transform.Translate (Vector3.forward * speed* Time.deltaTime);
			if(!comehome)
			transform.rotation=Quaternion.Lerp(transform.rotation,targetrotation,10*Time.deltaTime);
			}
			if(comehome){
			transform.rotation.x=0;
			transform.LookAt(playertransform);
			}
		}

		}
}

function Reset()
{		

if (!start || gameObject.tag=="dead" || gameObject.tag=="deaded" || gameObject.name =="26")return;
	//if (hardreset || turnaround)return;
	//Debug.Log(" Hello, my name is cockroach " + gameObject.name + " and I calling Reset");

//	if (comehome)return;

	var random=Random.Range(1,10);
	if (random==1)
	{
	stop=true;
	animator.SetBool ("Pause", true);
	cockroachsound.Stop();


	}
	else if (random>6)
	{
	animator.SetBool ("Pause", false);
		if (!cockroachsound.isPlaying)cockroachsound.Play();


	//speed=(Random.Range(4,8));
	//speed=speed/10;
	//speed=.5;
	//Debug.Log("speed:" + speed);
		
		stop=false;

		if (comehome)return;
		counter=Random.Range(1,9);
		switch(counter)
		{
		case 1:
		targetrotation=rotation1;
		direction=1;
		break;

		case 2:
		targetrotation=rotation2;
		direction=2;
		break;

		case 3:
		targetrotation=rotation3;
		direction=3;
		break;

		case 4:
		targetrotation=rotation4;
		direction=4;
		break;

		case 5:
		targetrotation=rotation5;
		direction=5;
		break;

		case 6:
		targetrotation=rotation6;
		direction=6;
		break;

		case 7:
		targetrotation=rotation7;
		direction=7;
		break;

		case 8:
		targetrotation=rotation8;
		direction=8;
		break;
	
		}
	}
	else
	{
	animator.SetBool ("Pause", false);
	if (!cockroachsound.isPlaying)cockroachsound.Play();

	}




}


function OnTriggerEnter(other:Collider)
{
if (gameObject.tag=="dead" | gameObject.tag=="deaded" ||  gameObject.name =="26" )return;

	/*if (other.tag=="Player" && !playertouch)
	{
	Invoke("Playertouchreset",2);
	playertouch=true;
	comehome=false;
	}*/
	//Debug.Log("my name is cockroach " + gameObject.name + " and I am colliding with " + other.tag + " direction : " + direction + " hardreset : " + hardreset + " hardreset2 : " + hardreset2 + " turnaround: " + turnaround + "levelcounter : " + mastercontrols.levelcounter);

	if (other.tag=="border")
	{

	//Debug.Log("1");
	Turnaround();
	Invoke("Turnaroundreset",.1f);
	//collthresh++;
	}
	if (other.tag=="wall" && mastercontrols.levelcounter==7)
	{
//Physics.IgnoreCollision(other.collider,collider);
	}


	if (other.tag=="wall" && mastercontrols.levelcounter!=7)
	{
		//Debug.Log("3");

	Turnaround();
	Invoke("Turnaroundreset",.1f);

	}
	else if(other.tag=="Finish")
	{
	//	Debug.Log("4");

	Hardreset();
	Invoke("Hardresetreset",.1f);

	}

/*	else if (other.tag!=="Cube")
	{
	Debug.Log("NOTBORDERhitwall" + "direction=" + direction + "speed: " + speed);
	Hardreset();
	hardreset=true;
	Invoke("Hardresetreset",1);
	}*/

}
/*
function OnTriggerStay(other:Collider)
{
if (other.tag=="floor")return;

	Debug.Log("my name is cockroach " + gameObject.name + " and I am colliding with " + other.tag + " direction : " + direction + " hardreset : " + hardreset + " hardreset2 : " + hardreset2 + " turnaround: " + turnaround);

if (other.tag=="border" && collthresh2==0)
	{
	collthresh2+=Time.deltaTime;
	Debug.Log("COLLTHRESH2 : "  + collthresh2);
	Hardreset2();
	Invoke("Hardreset2reset",.5f);
	collthresh2=0;
	}
}
*/



function OnTriggerExit(other:Collider)
{
if (other.name=="Floor")return;
//Debug.Log(" Hello, my name is cockroach " + gameObject.name + " and I am leaving collider  " + other.tag);

collthresh=0;
collthresh2=0;


}




function Playertouchreset()
{
playertouch=false;
}






function Turnaround()
{
//Debug.Log("TURN AROUND CALLED");
if(gameObject.tag=="dead" || gameObject.tag=="deaded" || turnaround ||  gameObject.name =="26")return;

turnaround=true;

//Debug.Log("my name is cockroach " + gameObject.name + " and I am calling Turnaround" + "my direction is : " + direction);



switch(direction)
		{
		case 1:

			targetrotation=rotation2;
			direction=2;
		break;

		case 2:

			targetrotation=rotation1;
			direction=1;
	
		break;

		case 3:

			targetrotation=rotation4;
			direction=4;
		
		break;

		case 4:

	
			targetrotation=rotation3;
			direction=3;
		

		break;

		case 5:

			targetrotation=rotation8;
			direction=8;
		
		break;

		case 6:

			targetrotation=rotation7;
			direction=7;
		
		break;

		case 7:
	
			targetrotation=rotation6;
			direction=6;
		
		break;

		case 8:
	
			targetrotation=rotation5;
			direction=5;
		
		break;


		}

		/*switch(direction)
		{
		case 1:
		var tempnum1=Random.Range(1,5);
		if (tempnum1<=2){
			targetrotation=rotation2;
			direction=2;
		}
		else if(tempnum1==3)
		{
			targetrotation=rotation3;
			direction=3;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 2:
		var tempnum2=Random.Range(1,5);
		if (tempnum2<=2){
			targetrotation=rotation1;
			direction=1;
		}
		else if(tempnum2==3)
		{
			targetrotation=rotation3;
			direction=3;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 3:
			var tempnum3=Random.Range(1,5);
		if (tempnum3<=2){
			targetrotation=rotation4;
			direction=4;
		}
		else if(tempnum3==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}
		break;

		case 4:
		var tempnum4=Random.Range(1,5);
		if (tempnum4<=2){
			targetrotation=rotation3;
			direction=3;
		}
		else if(tempnum4==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}

		break;

		case 5:
	var tempnum5=Random.Range(1,5);
		if (tempnum5<=2){
			targetrotation=rotation2;
			direction=2;
		}
		else if(tempnum5==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 6:
		var tempnum6=Random.Range(1,5);
		if (tempnum6<=2){
			targetrotation=rotation4;
			direction=4;
		}
		else if(tempnum6==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}
		break;

		case 7:
	var tempnum7=Random.Range(1,5);
		if (tempnum7<=2){
			targetrotation=rotation2;
			direction=2;
		}
		else if(tempnum7==3)
		{
			targetrotation=rotation4;
			direction=4;
		}
		else
		{
			targetrotation=rotation3;
			direction=3;
		}
		break;

		case 8:
	var tempnum8=Random.Range(1,5);
		if (tempnum8<=2){
			targetrotation=rotation3;
			direction=3;
		}
		else if(tempnum8==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;
		}*/

//Debug.Log("my name is cockroach " + gameObject.name + " and I am calling Turnaround" + "my direction is : " + direction);




}






function Hardreset()


{

//Debug.Log("HardReset called and hardreset : " + hardreset );

if(gameObject.tag=="dead" || gameObject.tag=="deaded" || hardreset ||  gameObject.name =="26" || !start)return;
hardreset=true;
//Debug.Log("my name is cockroach " + gameObject.name + " and I am calling HardReset" + "my direction is : " + direction + " hardreset : " + hardreset + " hardreset2 : " + hardreset2 + " turnaround: " + turnaround);
/*
		switch(direction)
		{
		case 1:
		var tempnum1=Random.Range(1,5);
		if (tempnum1<=2){
			targetrotation=rotation2;
			direction=2;
		}
		else if(tempnum1==3)
		{
			targetrotation=rotation3;
			direction=3;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 2:
		var tempnum2=Random.Range(1,5);
		if (tempnum2<=2){
			targetrotation=rotation1;
			direction=1;
		}
		else if(tempnum2==3)
		{
			targetrotation=rotation3;
			direction=3;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 3:
			var tempnum3=Random.Range(1,5);
		if (tempnum3<=2){
			targetrotation=rotation4;
			direction=4;
		}
		else if(tempnum3==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}
		break;

		case 4:
		var tempnum4=Random.Range(1,5);
		if (tempnum4<=2){
			targetrotation=rotation3;
			direction=3;
		}
		else if(tempnum4==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}

		break;

		case 5:
	var tempnum5=Random.Range(1,5);
		if (tempnum5<=2){
			targetrotation=rotation8;
			direction=8;
		}
		else if(tempnum5==3)
		{
			targetrotation=rotation2;
			direction=2;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 6:
		var tempnum6=Random.Range(1,5);
		if (tempnum6<=2){
			targetrotation=rotation7;
			direction=7;
		}
		else if(tempnum6==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation4;
			direction=4;
		}
		break;

		case 7:
	var tempnum7=Random.Range(1,5);
		if (tempnum7<=2){
			targetrotation=rotation6;
			direction=6;
		}
		else if(tempnum7==3)
		{
			targetrotation=rotation3;
			direction=3;
		}
		else
		{
			targetrotation=rotation2;
			direction=2;
		}
		break;

		case 8:
	var tempnum8=Random.Range(1,5);
		if (tempnum8<=2){
			targetrotation=rotation5;
			direction=5;
		}
		else if(tempnum8==3)
		{
			targetrotation=rotation1;
			direction=1;
		}
		else
		{
			targetrotation=rotation3;
			direction=3;
		}
		break;
		}


		*/
		do 
		{
		counter2=Random.Range(1,9);
		//Debug.Log("COUNTER2 : " + counter2);
		}while (counter2==direction);
		switch(counter2)
		{
		case 1:
		targetrotation=rotation1;
		direction=1;
		break;

		case 2:
		targetrotation=rotation2;
		direction=2;
		break;

		case 3:
		targetrotation=rotation3;
		direction=3;
		break;

		case 4:
		targetrotation=rotation4;
		direction=4;
		break;

		case 5:
		targetrotation=rotation5;
		direction=5;
		break;

		case 6:
		targetrotation=rotation6;
		direction=6;
		break;

		case 7:
		targetrotation=rotation7;
		direction=7;
		break;

		case 8:
		targetrotation=rotation8;
		direction=8;
		break;

	
		}




//Debug.Log("my name is cockroach " + gameObject.name + " and I am calling HardReset" + "my direction is : " + direction);


}




function Hardreset2()


{

//Debug.Log("HardReset called and hardreset : " + hardreset );

if(gameObject.tag=="dead" || gameObject.tag=="deaded" || hardreset2 ||  gameObject.name =="26")return;
hardreset2=true;
Debug.Log("my name is cockroach " + gameObject.name + " and I am calling HardReset2" + "my direction is : " + direction + " hardreset : " + hardreset + " hardreset2 : " + hardreset2 + " turnaround: " + turnaround);

		do 
		{
		var counter3=Random.Range(1,9);
		//Debug.Log("COUNTER2 : " + counter2);
		}while (counter3==direction);
		switch(counter3)
		{
		case 1:
		targetrotation=rotation1;
		direction=1;
		break;

		case 2:
		targetrotation=rotation2;
		direction=2;
		break;

		case 3:
		targetrotation=rotation3;
		direction=3;
		break;

		case 4:
		targetrotation=rotation4;
		direction=4;
		break;

		case 5:
		targetrotation=rotation5;
		direction=5;
		break;

		case 6:
		targetrotation=rotation6;
		direction=6;
		break;

		case 7:
		targetrotation=rotation7;
		direction=7;
		break;

		case 8:
		targetrotation=rotation8;
		direction=8;
		break;

	
		}

	}


function Hardresetreset()
{
hardreset=false;
}

function Hardreset2reset()
{
hardreset2=false;
	collthresh2=0;

}

function Turnaroundreset()
{
turnaround=false;
}

function ResetKilled()
{
killed=false;



}

function DistanceChecker()
{
if (!start || gameObject.tag=="dead" || gameObject.tag=="deaded" )return;

tempPos=GameObject.Find("FPSController (origin)").transform.position;

if (Mathf.Abs (tempPos.x - transform.position.x) < .05f) {
			if (Mathf.Abs (tempPos.z - transform.position.z) < .05f)
				Debug.Log("DIFFERENCE IS NONE" +"x: " + (tempPos.x - transform.position.x) + " z:" + (tempPos.z - transform.position.z) );
		}
	else
	{
				Debug.Log("DIFFERENCE IS SOME" + "x:" + (tempPos.x - transform.position.x) + " z:" + (tempPos.z - transform.position.z));

	}

Debug.Log("temppos" + tempPos);


}


function Level7scaler()
{
if (gameObject.tag!="dead")

if (transform.localScale.x<.08)
{
transform.localScale.x+=.03*Time.deltaTime;
transform.localScale.y+=.03*Time.deltaTime;
transform.localScale.z+=.03*Time.deltaTime;

mastercontrols.level7dreamint1+=.5*Time.deltaTime;
mastercontrols.level7dreamint2+=.5*Time.deltaTime;

}

}


function QuadrantCheck()
{
return;
	playerpos=GameObject.Find("FPSController (head)").transform.position;


	if (playerpos.x>-.98 && playerpos.x<=.6145)
	{
		if (playerpos.z>-1.9 && playerpos.z<= -.553)
			quadrant=1;
		else quadrant=3;
	}
	else
	{
	if (playerpos.z>-1.9 && playerpos.z<= -.553)
			quadrant=2;
		else quadrant=4;

	}

	Debug.Log("PLAYER IS IN QUADRANT " + quadrant + " with position : " + playerpos);

	switch(quadrant)
	{
	case 1:
	transform.position=bossposq4;
	break;

	case 2:
	transform.position=bossposq3;
	break;

	case 3:
	transform.position=bossposq2;
	break;

	case 4:
	transform.position=bossposq1;
	break;



	}



}




