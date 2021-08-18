using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class QA_Controler_Eng : MonoBehaviour
{
      public float timePerQuestion;
    int m_RightCount;
  
    float m_curTime;
    private void Awake(){
        m_curTime=timePerQuestion;
    }
    
    // Start is called before the first frame update
    void Start()
    {
          QA_UI_Manager.Ins.SetTimeText("00 :"+ m_curTime);
        CreateQuestion();
        StartCoroutine(TimeCoutingDown());
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void CreateQuestion(){
        Q_Data qs =Q_Manager.Ins.GetRandomQuestion();
        if(qs != null){
            QA_UI_Manager.Ins.SetQText(qs.question);
            string [] wrongAnswers=new string[] {qs.answer1,qs.answer2,qs.answer3};
            QA_UI_Manager.Ins.ShuffleAnswers();
            var temp = QA_UI_Manager.Ins.answerButtons;
            if(temp != null && temp.Length >0){
                int wrongAnswerCount =0;
                for(int i = 0 ; i<temp.Length; i++){
                    int answerId=i;
                    if(string.Compare(temp[i].tag,"RightAnswer")==0){
                        temp[i].SetAnswerText(qs.rightAnswer);
                    }else{
temp[i].SetAnswerText(wrongAnswers[wrongAnswerCount]);
wrongAnswerCount++;
                    }
                    temp[answerId].btnComp.onClick.RemoveAllListeners();
                    temp[answerId].btnComp.onClick.AddListener(()=>CheckRightAnswerEvent(temp[answerId]));
                }
            }
        }
    }

    void CheckRightAnswerEvent(AnswerButton AnswerButton){
if(AnswerButton.CompareTag("RightAnswer")){
    m_curTime=timePerQuestion;
    QA_UI_Manager.Ins.SetTimeText("00 : "+m_curTime);
     m_RightCount++; 
    if(m_RightCount==Q_Manager.Ins.questions.Length){
        // QA_UI_Manager.Ins.QA_Dialog.SetDialogContent("Bạn đã trả lời đúng toàn bộ câu hỏi");
        QA_UI_Manager.Ins.QA_Dialog.Show(true);
        StopAllCoroutines();  
        AudioControler.Ins.PlayWinSound();
    }else{
   
    CreateQuestion();
    Debug.Log("Cau tra loi dung");
    AudioControler.Ins.PlayRightSound();
    }
}else{
      Debug.Log("Cau tra loi sai");
      AudioControler.Ins.PlayLoseSound();
    // QA_UI_Manager.Ins.QA_Dialog.SetDialogContent("Tro choi ket thuuc");
 QA_UI_Manager.Ins.Exit_Dialog.Show(true);
}
    }

    IEnumerator TimeCoutingDown(){
        yield return new WaitForSeconds(1);
        if(m_curTime>0){
            m_curTime--;
            StartCoroutine(TimeCoutingDown());
            QA_UI_Manager.Ins.SetTimeText("00 :"+ m_curTime);
        }else{
            QA_UI_Manager.Ins.Exit_Dialog.Show(true);
            StopAllCoroutines();
        }
    }
    public void Replay(){
        AudioControler.Ins.StopMusic();
SceneManager.LoadScene("QA_Eng");
    }
    public void Exit(){
        Application.Quit();
    }
}

