using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFX : MonoBehaviour {
	public static AudioFX instance;
	public PlayerAudio playerAudio;



	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AudioA(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.A,pos);

	}
	public void AudioB(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.B,pos);

	}
	public void AudioC(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.C,pos);

	}
	public void AudioD(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.D,pos);

	}
	public void AudioE(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.E,pos);

	}
	public void AudioF(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.F,pos);

	}
	public void AudioG(Vector3 pos){
		AudioSource.PlayClipAtPoint (playerAudio.G,pos);

	}

}
