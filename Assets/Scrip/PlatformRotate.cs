using UnityEngine;

public class PlatformRotate : MonoBehaviour
{  
 void FixedUpdate()
  {
     if (transform.rotation.eulerAngles.z < 10 || transform.rotation.eulerAngles.z > 30)
     {
         GetComponent<Rigidbody>().angularVelocity = Vector3.forward;
     }
     else if (transform.rotation.eulerAngles.z < 10 || transform.rotation.eulerAngles.z > 30)
     {
         GetComponent<Rigidbody>().angularVelocity = Vector3.back;
     }else
     {
          GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
     }
  }
}