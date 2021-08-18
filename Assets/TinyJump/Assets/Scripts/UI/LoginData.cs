using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginData : MonoBehaviour

{
    public InputField NAME;
  public InputField PASSWORD;
  public Dialog sucsessLoginDialog;
    public Dialog userDialog;
        public Dialog failDialog;

  public void ShowsucsessLoginDialog(){
    if(sucsessLoginDialog)
    sucsessLoginDialog.Show(true);
    userDialog.Show(false);
      }
              public void ShowFailDialog(){
    if(failDialog)
    failDialog.Show(true);
    userDialog.Show(false);
      }

    string LoginDataphp="http://localhost/php/LoginData.php";
    public void dangnhap(){
      StartCoroutine(connect());


  }
  IEnumerator connect(){
      WWWForm wf= new WWWForm();
wf.AddField("user_chuyen",NAME.text);
wf.AddField("pass_chuyen",PASSWORD.text);

WWW w= new WWW(LoginDataphp,wf);
yield return w;

string tam=w.text;
string tam1=tam.TrimStart();
string tam11=tam1.TrimEnd();

if(w.text=="thanh cong"){
  print("Login sucsses");
      ShowsucsessLoginDialog();

}else{
  print("Login faild");
  ShowFailDialog(); 
}
  }
}
