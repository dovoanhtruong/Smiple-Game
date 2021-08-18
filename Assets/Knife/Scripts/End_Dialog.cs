using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Dialog : Dialog
{
 public void Show(bool isShow){
       gameObject.SetActive(isShow);
   }
   public void ShowMainScene()
	{
		Application.LoadLevel("Main");
	}
    public void Reload(){
        Application.LoadLevel("Dart");
    }
}
