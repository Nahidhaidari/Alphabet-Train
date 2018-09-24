using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnCtrl : MonoBehaviour {
	public GameObject alphabetPanel, colorsPanel, weeksPanel, monthsPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AlphabetLearnBtn(string name){
		alphabetPanel.SetActive (false);
		SceneManager.LoadScene (name);

	}
	public void AlphabetQiuzBtn(string name){
		alphabetPanel.SetActive (false);
		SceneManager.LoadScene (name);
	}
	public void AlphabetBtn(){
		alphabetPanel.SetActive (true);
	}
	public void DeactiveAlphabetPanel(){
		alphabetPanel.SetActive (false);
	}


}
