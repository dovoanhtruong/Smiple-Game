using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QA_Main_Manager : MonoBehaviour
{
public void ShowMain_QAScene()
	{
		Application.LoadLevel("Main");
	}

     public void ShowQA_EnteScene()
	{
		Application.LoadLevel("QA_GiaiTri");
	}

     public void ShowQA_SchoolScene()
	{
		Application.LoadLevel("QA_School");
	}

     public void ShowQA_TechScene()
	{
		Application.LoadLevel("QA_Tech");
	}

     public void ShowQAS_Engcene()
	{
		Application.LoadLevel("QA_Eng");
	}
}
