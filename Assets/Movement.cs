using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
  //This also works with joystick, PS this is topdown movement

 private Rigidbody2D rb;
 public float MoveSpeed = 15f;
 private float vertical;
 private float horizontal; 

 void Start ()
 {
  rb = GetComponent<Rigidbody2D>(); 
 }

 void Update ()
 {
 
  horizontal = Input.GetAxisRaw("Horizontal");
  vertical = Input.GetAxisRaw("Vertical"); 
 }

 private void FixedUpdate()
 {  
  rb.velocity = new Vector2(horizontal * MoveSpeed, vertical * MoveSpeed);
 }
}