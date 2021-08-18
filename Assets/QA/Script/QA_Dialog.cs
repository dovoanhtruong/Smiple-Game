using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QA_Dialog : Dialog
{
   public Text dialogContentText;
   
   public void Show(bool isShow){
       gameObject.SetActive(isShow);
   }
// public void SetDialogContent(string content){
//        if(dialogContentText){
//            dialogContentText.text=content;
//        }
//    }

   public void ShowQAScene()
	{
		Application.LoadLevel("QA_Main");
	}

}
