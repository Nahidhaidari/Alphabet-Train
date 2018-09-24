using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Transform pos1,pos2,startPos;
	public float speed;
	public GameObject abc;
	public static Move instance;
	Vector3 nextPos;
	public Sprite st;


	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		nextPos = startPos.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position==pos1.position){
			nextPos = pos2.position;
		}
		if (transform.position == pos2.position) {
	//		abc.gameObject.SetActive (true);
			
		}
		transform.position = Vector3.MoveTowards (transform.position,nextPos,speed*Time.deltaTime);
	    Invoke("showRotate", 9f);
		//FindObjectOfType<AlphaCheckCtrl> ().enabled = true;
		//Invoke("DeactivateRotate", 3f);
	}

	void showRotate(){
		FindObjectOfType<rotator> ().enabled=true;
	}
	public void DeactivateRotate(){
	//	FindObjectOfType<rotator> ().enabled=false;
		GameObject.Find ("?_box").GetComponent<rotator>().enabled=false;
		GameObject.Find ("?_box").GetComponent<SpriteRenderer>().sprite=st;
	}
}
