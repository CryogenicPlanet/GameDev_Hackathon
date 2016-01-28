#pragma strict
var level : String;
function OnTriggerEnter (myCollision : Collider) {

 if(myCollision.tag == "Player")
    Application.LoadLevel(level);
  }

