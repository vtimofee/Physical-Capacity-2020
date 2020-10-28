#pragma strict

public var cockroachspawnpoint:Vector3;
private var currentroach:Vector3;

function Start () {
cockroachspawnpoint=Vector3(.668,-.201,-0.568);

}

function Update () {

}

function OnTriggerEnter(other:Collider)
{

if (other.tag=="Finish")
{
other.transform.position=cockroachspawnpoint;
//currentroach=GameObject.Find(other.name);
//currentroach.transform=cockroachspawnpoint;
}


}