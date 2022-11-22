#pragma strict
var cube :GameObject;
var ran =1;
function Start () {

}

function Update () {
cube.GetComponent.<Rigidbody>().velocity.y = ran;
}