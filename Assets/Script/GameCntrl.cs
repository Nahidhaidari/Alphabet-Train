using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCntrl : MonoBehaviour {
	public static GameCntrl instance;
	public GameObject[] alpha,secondQ,firstQ,LevelQ,fourQ,fiveQ,thirdQ;
	public GameObject ob1,first,second,third,fourth,five,x,y,q,fq;
	public Transform qPos;
	public Transform[] alphaPos;
	public UI ui;
	public float maxTime;
	float timeLeft;
	bool timerOn;
	public bool isFirst,isSecond,isThird,isFourth,isFive;
	public GameData data;
	List<GameObject> list;
	public int randomNum;
	public GameObject cBox;
	public GameObject dBox;
//
	bool isFinshed;
	void Awake(){
		if (instance == null) {
			instance = this;
		}
	//	first.gameObject.SetActive (true);
	}
//
//
//	// Use this for initialization
	void Start () {
		timeLeft = maxTime;
		timerOn = true;
		isFirst = true;
		//ChangeAlp ();
	}
//	
//	// Update is called once per frame
	void Update () {
		if(timeLeft>0 && timerOn){
			UpdateTimer ();
	    }

//		//ChangeLevelQ ();
//		if (isFirst || isSecond || isFourth|| isThird || isFive) {
//			DeactiveAll ();
//		}
			
	}
//	public void ChangeLevelQ(){
//		if (isFirst) {
//			for (int i = 0; i < LevelQ.Length; i++) {
//				LevelQ [i].gameObject.SetActive (false);
//				if (i == 0 || i == 2) {
//					//LevelQ [i].gameObject.SetActive (true);
//
//
//				}
//			}
//			ActivefiveQ ();
//			isFirst = false;
//		
//		}else if (isSecond) {
//			for (int i = 0; i < LevelQ.Length; i++) {
//				LevelQ [i].gameObject.SetActive (false);
//				if (i == 2 || i == 3) {
//					LevelQ [i].gameObject.SetActive (true);
//					foreach (Transform child in second.transform) {
//						child.gameObject.SetActive (true);
//					}
//
//				}
//			}
//			isSecond = false;
//		}else if (isThird) {
//			for (int i = 0; i < LevelQ.Length; i++) {
//				LevelQ [i].gameObject.SetActive (false);
//				if (i == 4 || i == 5) {
//					LevelQ [i].gameObject.SetActive (true);
//					foreach (Transform child in third.transform) {
//						child.gameObject.SetActive (true);
//					}
//
//				}
//			}
//			isThird = false;;
//		}else if (isFourth) {
//			for (int i = 0; i < LevelQ.Length; i++) {
//				LevelQ [i].gameObject.SetActive (false);
//				if (i == 6 || i == 7) {
//					LevelQ [i].gameObject.SetActive (true);
//
//				}
//			}
//
//			isFourth = false;
//		}else if (isFive) {
//			for (int i = 0; i < LevelQ.Length; i++) {
//				LevelQ [i].gameObject.SetActive (false);
//				if (i == 8 || i == 9) {
//					LevelQ [i].gameObject.SetActive (true);
//
//				}
//			}
//			isFive = false;
//		}
//
//		//list.Add (ob1);
//	}
	public void DeactiveAll(){
//		isFirst = false;
		first.SetActive (false);
//		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
//		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [6].gameObject.GetComponent<SpriteRenderer> ().sprite;
		Invoke("ChangeFirstQ",2f);
		q.gameObject.SetActive (false);

		//second.SetActive (true);
//		foreach (Transform child in first.transform) {
//			child.gameObject.SetActive (false);
//		}
//		foreach (Transform child in second.transform) {
//			child.gameObject.SetActive (false);
//		}
//		foreach (Transform child in third.transform) {
//			child.gameObject.SetActive (false);
//		}
//		foreach (Transform child in fourth.transform) {
//			child.gameObject.SetActive (false);
//		}
//		foreach (Transform child in five.transform) {
//			child.gameObject.SetActive (false);
//		}
		Invoke ("ActiveSecondQ", 2f);
		//Invoke ("ActiveThirdQ", 2f);

	}
	public void DeactiveSecond (){
		print ("DeactiveSecond!!!!!!!");
		isSecond = false;
		first.SetActive (false);
		second.SetActive (false);
//		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
//		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [4].gameObject.GetComponent<SpriteRenderer> ().sprite;
		Invoke("ChangeSecondQ",2f);

		q.gameObject.SetActive (false);

		Invoke ("ActiveThirdQ", 2f);

	}
	public void DeactiveThird (){
		isThird = false;

		first.SetActive (false);
		second.SetActive (false);
		third.SetActive (false);
//		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [5].gameObject.GetComponent<SpriteRenderer> ().sprite;
//		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
		Invoke("ChangeThirdQ",2f);

		q.gameObject.SetActive (false);

		Invoke ("ActivefourQ", 2f);

	}
	public void DeactiveFour (){
		isFourth = false;

		first.SetActive (false);
		second.SetActive (false);
		third.SetActive (false);
		fourth.SetActive (false);
//		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [2].gameObject.GetComponent<SpriteRenderer> ().sprite;
//		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
		Invoke("ChangeFourQ",2f);

		q.gameObject.SetActive (false);

		Invoke ("ActivefiveQ", 2f);

	}
	public void DeactiveFive (){
		//isFive = false;
		first.SetActive (false);
		second.SetActive (false);
		third.SetActive (false);
		fourth.SetActive (false);
		five.SetActive (false);
		q.gameObject.SetActive (false);
	}

//	public void ActiveFirstQ(){
//		print ("1");
//		for(int i=0;i<firstQ.Length;i++){
//			firstQ [i].gameObject.SetActive (true);	
//		}
//
//		isFirst = false;
//	}
//
	public void ActiveSecondQ(){
		isFirst = false;
		isSecond = true;
		print ("2");
//		for(int i=0;i<secondQ.Length;i++){
//			secondQ [i].gameObject.SetActive (true);	
//		}
		first.gameObject.SetActive (false);

		second.gameObject.SetActive(true);
	//	isSecond = false;	
		q.gameObject.SetActive (true);

	//	fq.gameObject.SetActive (true);

	}

//
	public void ActiveThirdQ(){
		isThird = true;
		print ("3");
		
//		for(int i=0;i<thirdQ.Length;i++){
//			thirdQ [i].gameObject.SetActive (true);	
//		}
//		third.gameObject.SetActive(true);
//		isThird = false;
		first.gameObject.SetActive(false);
		second.gameObject.SetActive (false);
		third.SetActive (true);
		q.gameObject.SetActive (true);
	}

	public void ActivefourQ(){
		isFourth = true;
		print ("4");

		//		for(int i=0;i<thirdQ.Length;i++){
		//			thirdQ [i].gameObject.SetActive (true);	
		//		}
		//		third.gameObject.SetActive(true);
		//		isThird = false;
		first.gameObject.SetActive(false);
		second.gameObject.SetActive (false);
		third.gameObject.SetActive (false);
		fourth.SetActive (true);
		q.gameObject.SetActive (true);
//		for(int i=0;i<fourQ.Length;i++){
//			fourQ [i].gameObject.SetActive (true);	
//		}
		//isFourth = false;
	}

	public void ActivefiveQ(){
		isFive = true;
		print ("5");

		//		for(int i=0;i<thirdQ.Length;i++){
		//			thirdQ [i].gameObject.SetActive (true);	
		//		}
		//		third.gameObject.SetActive(true);
		//		isThird = false;
		first.gameObject.SetActive(false);
		second.gameObject.SetActive (false);
		third.gameObject.SetActive (false);
		fourth.gameObject.SetActive (false);
		five.SetActive (true);
		q.gameObject.SetActive (true);
//		for(int i=0;i<fiveQ.Length;i++){
//			firstQ [i].gameObject.SetActive (true);	
//		}
//		isFive = false;
	}
//
//	public void DestroyAll(){
//		
//	}
	void UpdateTimer(){
		timeLeft -= Time.deltaTime;
		ui.textTimer.text = "Timer :" + (int)timeLeft;

		if (timeLeft <= 0) {
			SceneManager.LoadScene ("GameOver");
			ui.textTimer.text = "Timer : 0";

			
		}
	}
	 public void UpdateScore(){
		data.Score += 5;
		ui.textScore.text = "Score :" + data.Score;
	}
	public void MiniseScore(){
		data.Score -= 5;
		ui.textScore.text = "Score :" + data.Score;
	}
//
//	public void chooseQ(){
//		randomNum = Random.Range (1,6);
//		switch(randomNum){
//		case 1:
//			isFirst = true;
//			isSecond = false;
//			isThird = false;
//			isFourth = false;
//			isFive =  false;
//			//DeactiveAll ();
//			print ("isFirst");
//			break;
//		case 2:
//			isFirst = false;
//			isSecond = true;
//			isThird = false;
//			isFourth = false;
//			isFive =  false;
//			//DeactiveAll ();
//			print ("isSecond");
//			break;
//		case 3:
//			isFirst = false;
//			isSecond = false;
//			isThird = true;
//			isFourth = false;
//			isFive =  false;
//
//			//DeactiveAll ();
//			print ("is3");
//			break;
//		case 4:
//			isFirst = false;
//			isSecond = false;
//			isThird = false;
//			isFourth = true;
//			isFive =  false;
//			//DeactiveAll ();
//			print ("is4");
//			break;
//		case 5:
//			isFirst = false;
//			isSecond = false;
//			isThird = false;
//			isFourth = false;
//			isFive =  true;
//			//DeactiveAll ();
//			print ("is5");
//			break;
//
//		}
//
//	}

//	public void ChangeQ(){
//		if(isFirst){
//		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
//		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [6].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			isFirst = false;
//		}else if(isSecond){
//			cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [4].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			isSecond = false;
//		}else if(isThird){
//			cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [5].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			isThird = false;
//		}else if(isFourth){
//			cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [2].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
//			isFourth = false;
//		}
//
//		}
	public void ChangeFirstQ(){
				cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
				dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [6].gameObject.GetComponent<SpriteRenderer> ().sprite;
	}
	public void ChangeSecondQ(){
		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [4].gameObject.GetComponent<SpriteRenderer> ().sprite;
	}
	public void ChangeThirdQ(){
		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [5].gameObject.GetComponent<SpriteRenderer> ().sprite;
		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [8].gameObject.GetComponent<SpriteRenderer> ().sprite;
					
	}
	public void ChangeFourQ(){
		cBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [2].gameObject.GetComponent<SpriteRenderer> ().sprite;
		dBox.gameObject.GetComponent<SpriteRenderer> ().sprite = secondQ [3].gameObject.GetComponent<SpriteRenderer> ().sprite;
	}
}
