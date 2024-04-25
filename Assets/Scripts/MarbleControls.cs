using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MarbleControls : MonoBehaviour  
{  
   public float speed = 10;
   public bool isGrounded;

   Vector3 marble;

   void Start(){
   }

   void Update(){
      if (isGrounded == true){
         marble = transform.localPosition;
         marble.x += Input.GetAxis("Horizontal") * Time.deltaTime * speed;  
         marble.z += Input.GetAxis("Vertical") * Time.deltaTime * speed;  
         transform.localPosition = marble;
      }
   }

   void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.tag == "Ground"){
         isGrounded = true;
      }
   }

   void OnCollisionExit(Collision other)
   {
      if (other.gameObject.tag == "Ground"){
         isGrounded = false;
      }
   }
}