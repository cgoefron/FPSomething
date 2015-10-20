 function EggVel(target: Transform, angle: float): Vector3 {
     var dir = target.position - transform.position;  // get target direction
     var h = dir.y;  // get height difference
     dir.y = 0;  // retain only the horizontal direction
     var dist = dir.magnitude ;  // get horizontal distance
     var a = angle * Mathf.Deg2Rad;  // convert angle to radians
     dir.y = dist * Mathf.Tan(a);  // set dir to the elevation angle
     dist += h / Mathf.Tan(a);  // correct for small height differences
     // calculate the velocity magnitude
     var vel = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
     return vel * dir.normalized;
 }
 
 var myTarget: Transform;  // drag the target here
 var egg: GameObject;  // drag the cannonball prefab here
 var shootAngle: float = 30;  // elevation angle
 
 function Update(){
     if (Input.GetKeyDown("b")){  // press b to shoot
         var ball: GameObject = Instantiate(egg, transform.position, Quaternion.identity);
         ball.GetComponent.<Rigidbody>().velocity = EggVel(myTarget, shootAngle);
         Destroy(ball, 10);
     }
 }