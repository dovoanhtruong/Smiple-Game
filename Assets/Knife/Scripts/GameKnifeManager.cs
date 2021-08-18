using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameKnifeManager : MonoBehaviour {

	public static GameKnifeManager Ins;
	private bool gameHasEnded = false;

	public Rotator rotator;
	public Spawner spawner;
	public Dialog endDialog;
	public Dialog startDialog;
	public Animator animator;
	public Text timeText;

public void Awake(){
    MakeSingleton();
}

public void SetTimeText(string content){
    if(timeText){
        timeText.text=content;
    }
}

	public void EndGame (){
		if (gameHasEnded)
			return;
		rotator.enabled = false;
		spawner.enabled = false;
		animator.SetTrigger("EndGame");
		gameHasEnded = true;
		// AudioControler.Ins.PlayDartNotOkSound();
		endDialog.Show(true);
	}
public void MakeSingleton(){
     if(Ins == null){
         Ins = this;
     }else{
         Destroy(gameObject);
     }
}
public void RestartLevel(){}
}
