using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialog : Dialog
{
 public float timePerQuestion;
       float m_curTime;
    private void Awake(){
        m_curTime=timePerQuestion;
    }

      void Start()
    {
        AudioControler.Ins.PlayDartStartSound();
          GameKnifeManager.Ins.SetTimeText(""+m_curTime);
        StartCoroutine(TimeCoutingDown());
    }

    IEnumerator TimeCoutingDown(){
        yield return new WaitForSeconds(1);
        if(m_curTime>0){
            m_curTime--;
            StartCoroutine(TimeCoutingDown());
            GameKnifeManager.Ins.SetTimeText(""+m_curTime);
        }else{
            GameKnifeManager.Ins.startDialog.Show(false);
            StopAllCoroutines();
        }
}
}
