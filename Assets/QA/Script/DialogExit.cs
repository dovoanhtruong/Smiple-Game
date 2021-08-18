using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogExit : Dialog
{
     public void Show(bool isShow){
       gameObject.SetActive(isShow);
   }
   public void ShowQAScene()
	{
		Application.LoadLevel("QA_Main");
	}
}
