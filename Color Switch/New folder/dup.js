#pragma strict
var dupobj:Transform;
var duptime =1.2;
function Start () {
InvokeRepeating("Spawn",duptime,duptime);
}

function Spawn () {
Instantiate(dupobj,transform.position,transform.rotation);
}