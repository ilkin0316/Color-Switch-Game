#pragma strict
var ran = 5;
function Start () {

}

function Update () {
GetComponent.<Rigidbody>().velocity.y=ran;
}