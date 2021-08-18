using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : Singleton<MainManager>
{
    public GameObject main;
    public Dialog loginDialog;
    public Dialog registerDialog;
    public Dialog sucsessLoginDialog;
    public Dialog sucsessRegisterDialog;
    public Dialog failLoginDialog;
    public Dialog menuDialog;
    public Dialog infoDialog;


public override void Awake(){
    MakeSingleton(false);
}
public void ShowTinyScene()
	{
		Application.LoadLevel("Gameplay");
	}

    public void ShowQAScene()
	{
		Application.LoadLevel("QA_Main");
	}

      public void ShowDartScene()
	{
		Application.LoadLevel("Dart");
	}

public void ShowLoginDialog(){
    if(loginDialog)
    loginDialog.Show(true);
}
public void ShowMenuDialog(){
    if(menuDialog)
    menuDialog.Show(true);
}
}
