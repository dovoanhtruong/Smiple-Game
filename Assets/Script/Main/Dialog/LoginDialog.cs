using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginDialog : Dialog
{
    public Dialog registerDialog;
    public Dialog loginDialog;
    public Dialog loginSucsessDialog;
    public Dialog failLoginDialog;

    public void ShowloginSucsessDialog()
    {
    if(loginSucsessDialog)
    loginSucsessDialog.Show(true);
    loginDialog.Show(false);
    }

    public void ShowfailLoginDialog(){
    if(failLoginDialog)
    failLoginDialog.Show(true);
    loginDialog.Show(false);
      }

   public void ShowregisterDialog(){
    if(registerDialog)
    registerDialog.Show(true);
    loginDialog.Show(false);
      }
}
