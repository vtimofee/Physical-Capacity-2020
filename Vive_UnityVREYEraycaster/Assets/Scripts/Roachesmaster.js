#pragma strict

public var ccamera:Camera;
//public var ssound:AudioSource;
function Start () {

ccamera.fieldOfView=140;

//ssound.time=4;


}

function Update () {

if (Input.GetKey("t"))
{
ccamera.fieldOfView-=10*Time.deltaTime;
}
if (Input.GetKey("g"))
{
ccamera.fieldOfView+=10*Time.deltaTime;
}


}