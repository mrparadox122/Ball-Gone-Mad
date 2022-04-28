using UnityEngine;

public class PlatfromRotate : MonoBehaviour
{  
 void FixedUpdate()
  {
     if (transform.rotation.eulerAngles.z < 50 || transform.rotation.eulerAngles.z > 310)
     {
         GetComponent<Rigidbody>().angularVelocity = Vector3.forward;
     }
     else if ((transform))
  }
    







}