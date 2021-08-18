using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterDialog : Dialog
{
    public Dialog sucsessRegisterDialog;
    public Dialog registerDialog;
    public Dialog loginDialog;

    
    public void ShowSucsessRegisterDialog(){
    if(sucsessRegisterDialog)
    sucsessRegisterDialog.Show(true);
    registerDialog.Show(false);
      }
       public void ShowLoginDialog(){
    if(loginDialog)
    loginDialog.Show(true);
    registerDialog.Show(false);
      }
}
