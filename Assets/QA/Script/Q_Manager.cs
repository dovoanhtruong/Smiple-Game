using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Q_Manager : MonoBehaviour
{
    public static Q_Manager Ins;
  public Q_Data[] questions;
  List<Q_Data> m_questions;
  Q_Data m_curQuestions;
  public Q_Data CurQuestion {get => m_curQuestions; set => m_curQuestions = value; }

private void Awake(){
m_questions=questions.ToList();
MakeSingleton();

}

public Q_Data GetRandomQuestion(){
if(m_questions != null && m_questions.Count > 0){
    int randIdx = Random.Range(0, m_questions.Count);
    m_curQuestions = m_questions[randIdx];
    m_questions.RemoveAt(randIdx);
}
return m_curQuestions;
}
public void MakeSingleton(){
    if(Ins == null){
        Ins = this;
    }else{
        Destroy(gameObject);
    }
}
}
