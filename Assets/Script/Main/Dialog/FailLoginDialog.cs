using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailLoginDialog : Dialog
{
    public Dialog loginDialog;
    public Dialog failLoginDialog;

    public void ShowLoginDialog(){
    if(loginDialog)
    loginDialog.Show(true);
    failLoginDialog.Show(false);
      }
}
