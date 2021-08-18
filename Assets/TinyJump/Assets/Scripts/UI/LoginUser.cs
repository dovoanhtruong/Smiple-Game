using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUser : MonoBehaviour
{
  public InputField ID_USER;
  public InputField NAME;
  public InputField PASSWORD;

  

  string loginphp="http://localhost/php/login.php";
  public void themoi(){
      StartCoroutine(connect());

  }
  IEnumerator connect(){
      WWWForm wf= new WWWForm();
wf.AddField("id_chuyen",ID_USER.text);
wf.AddField("user_chuyen",NAME.text);
wf.AddField("pass_chuyen",PASSWORD.text);

WWW w= new WWW(loginphp,wf);
yield return w;

string tam=w.text;
string tam1=tam.TrimStart();
string tam11=tam1.TrimEnd();

if(w.text=="thanh cong"){
  print("Login sucsses");
}else{
  print("Login faild"); 
}
  }

}
