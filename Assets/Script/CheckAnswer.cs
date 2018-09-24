using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour {
	public GameObject sp,x,whiteBox;
	public GameObject questionMr;
	void Start(){
		GameCntrl.instance.first.gameObject.SetActive (true);

	}
	public void OnCollisionEnter2D(Collision2D other){

		questionMr.GetComponent<rotator> ().enabled = false;
		if(GameCntrl.instance.isFirst){
			print ("trigger");

			GameCntrl.instance.DeactiveAll ();
			//Invoke ("DeactiveFirst",0.2f);
		}else if(GameCntrl.instance.isSecond){
			print ("trigger");

			print ("DeactiveSecond");

			GameCntrl.instance.DeactiveSecond();
			//Invoke("DeactiveSecond",2f);
		}else if(GameCntrl.instance.isThird){
			GameCntrl.instance.DeactiveThird();
		}else if(GameCntrl.instance.isFourth){
			GameCntrl.instance.DeactiveFour();
		}else if(GameCntrl.instance.isFive){
			GameCntrl.instance.DeactiveFive ();
			GameCntrl.instance.ui.BtnNext.gameObject.SetActive (true);
			//Invoke ("LoadLevelTwo",0.5f);

		}
		if(other.gameObject.CompareTag("Correct")){
			x = other.gameObject;
			if (!GameCntrl.instance.isFive) {
				
				Invoke ("Deactive", 2f);
			}

		GameCntrl.instance.UpdateScore ();
		//	Move.instance.DeactivateRotate ();
		//	AlphaCheckCtrl.instance.Deactive ();
//
		//	GameCntrl.instance.first.gameObject.SetActive (false);
			//GameCntrl.instance.second.SetActive (true);
			//GameCntrl.instance.second.SetActive (false);
			//GameCntrl.instance.third.SetActive (true);

//			print ("ssssss");
//
			gameObject.GetComponent<SpriteRenderer> ().sprite = sp.gameObject.GetComponent<SpriteRenderer>().sprite;
			//GameCntrl.instance.ActiveSecondQ ();
			//GameCntrl.instance.chooseQ();

		}
		else if(other.gameObject.CompareTag("Incorrect")){
			gameObject.GetComponent<SpriteRenderer> ().color = Color.red;

			x = other.gameObject;
			if (!GameCntrl.instance.isFive) {
				Invoke("Deactive",2f);

			}

			GameCntrl.instance.MiniseScore ();
//
//			Move.instance.DeactivateRotate ();
//			AlphaCheckCtrl.instance.Deactive ();
//			GameCntrl.instance.DestroyAll ();
//		
//			GameCntrl.instance.chooseQ();
//
//			print ("fffffff");
//

		}



	}
	public void Deactive(){
		gameObject.GetComponent<SpriteRenderer> ().color = Color.white;

		gameObject.GetComponent<SpriteRenderer> ().sprite = whiteBox.gameObject.GetComponent<SpriteRenderer>().sprite;
		x.gameObject.SetActive (false);
		questionMr.GetComponent<rotator> ().enabled = true;
	}
	public void LoadLevelTwo(){
		//GameCntrl.instance.DeactiveAll ();
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Level2");

	}




}

