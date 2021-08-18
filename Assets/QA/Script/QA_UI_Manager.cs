using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QA_UI_Manager : MonoBehaviour
{
public static QA_UI_Manager Ins;
public Text timeText;
public Text QText;
public Dialog QA_Dialog;
public Dialog Exit_Dialog;
public AnswerButton[] answerButtons;

public void Awake(){
    MakeSingleton();
}

// private void Start(){
//     ShuffleAnswers();
// }

public void SetTimeText(string content){
    if(timeText){
        timeText.text=content;
    }
}

public void SetQText(string content){
    if(QText){
        QText.text=content;
    }
}

public void ShuffleAnswers(){
    if(answerButtons != null && answerButtons.Length >0){
        for(int i=0;i<answerButtons.Length; i++){
            if(answerButtons[i]){
                answerButtons[i].tag="Untagged";
            }
        }
        int randIdx=Random.Range(0, answerButtons.Length);
        if(answerButtons[randIdx]){
            answerButtons[randIdx].tag="RightAnswer";
        }
    }
}

public void MakeSingleton(){
     if(Ins == null){
         Ins = this;
     }else{
         Destroy(gameObject);
     }
}
}
