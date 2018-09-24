using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaCheckCtrl : MonoBehaviour {
	public Transform pos;
	bool isClicked;
	GameObject x;
	public static AlphaCheckCtrl instance;
	public GameObject box3;
	// Use this for initialization

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	void Start () {
		isClicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isClicked && gameObject.tag == "Incorrect") {
			//box3.gameObject.GetComponent<SpriteRenderer> ().color = Color.red;
			transform.position = Vector3.Lerp (transform.position, pos.position, 0.1f);

		}
		else if (isClicked) {
			transform.position = Vector3.Lerp (transform.position, pos.position, 0.1f);
		}
	
		
	}
	void OnMouseDown(){
		gameObject.transform.parent = null;
		//if(gameObject.tag=="Correct"){
			isClicked = true;
		gameObject.GetComponent<rotator>().speed=-10;
			//gameObject.GetComponent<rotator> ().enabled = true;
		Invoke ("Deactive",1f);
		//}
	//	Deactive();
	}
	public void  Deactive(){
		
		gameObject.transform.rotation = Quaternion.identity;
		gameObject.GetComponent<rotator> ().speed = 0;
	}

}
