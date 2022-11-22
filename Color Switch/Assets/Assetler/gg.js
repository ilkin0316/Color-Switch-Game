#pragma strict
var ray:Ray;
var hit:RaycastHit;
var player:GameObject;
var ran =1;
function Start () {

}

function Update () {
 if(Input.GetMouseButtonDown(0)){
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,hit)){
            if(hit.transform.name == "Screen"){
                player.GetComponent.<Rigidbody>().velocity.y =ran;
            }
        }

    }
}