using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxCtrl : MonoBehaviour {
	public Sfx sfx;
	public static SfxCtrl instance;
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	public void AlphabetSfx(Vector3 pos){

		Instantiate (sfx.AlphabetPlay, pos, Quaternion.identity);


	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
