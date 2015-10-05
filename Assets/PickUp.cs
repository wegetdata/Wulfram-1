﻿using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	public AudioClip pickup;
	public AudioClip dropdown;
	public GameObject blueft;
	public bool isCreated;


	void Update () {
		

		}
		
void  OnTriggerEnter(Collider player) {
	

		
	}
	
	
	
	
	public void OnTriggerStay(Collider other){
		bool canClone = true;
		
		if (Input.GetKeyDown ("z")) {
			//drop item code
			GetComponent<AudioSource>().PlayOneShot (dropdown, 1.0f);
			transform.GetComponent<Renderer>().enabled = true;
			transform.parent = null;
		} 

		
	if(Input.GetKeyDown("q")){
			
			if (other.tag == "Ship"){ // only be picked by the player!
				
				transform.parent = Camera.main.transform; 
				transform.GetComponent<Renderer>().enabled = false;// pick this object...
				GetComponent<AudioSource>().PlayOneShot(pickup, 1.0f);
				
			}
			
			
		}

		if(Input.GetKeyDown("m")){
			
			if (other.tag == "Ship"){ // only be picked by the player!
				
				GUI.Box(new Rect(50, 180, 150, 50), "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@test");
				
			}
			
			
		}


		if (Input.GetKeyDown (",")) {
			if (other.tag == "Ship"){
						if (gameObject.tag == "FlakCargo" && !isCreated) {
			PhotonNetwork.Instantiate("blueft", new Vector3 (transform.position.x, transform.position.y + 1.4f, transform.position.z), Quaternion.identity, 0);
				isCreated = true;	
				
						}
				if (other.tag == "Ship"){
				if (gameObject.tag == "bluegt" && !isCreated) {
					PhotonNetwork.Instantiate("bluegt", new Vector3 (transform.position.x, transform.position.y + 1.4f, transform.position.z), Quaternion.identity, 0);
					isCreated = true;	
				}
						GameObject.Destroy (gameObject);

				}
			}
			}
		}

	}

	

