using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampointingSun : MonoBehaviour {

     public Transform targetPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
     void FixedUpdate () {
     transform.LookAt(new Vector3(targetPos.position.x,0f,targetPos.position.z));
     }
}
