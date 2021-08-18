using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogoutDialog : Dialog
{
    public Dialog logoutDialog;
    public Dialog infoDialog;
    public Dialog sucsessLogoutDialog;

    public void ShowSucsessLogoutDialog(){
    if(sucsessLogoutDialog)
    sucsessLogoutDialog.Show(true);
    logoutDialog.Show(false);
      }
      public void ShowInfoDialog(){
    if(infoDialog)
    infoDialog.Show(true);
    logoutDialog.Show(false);
      }

    
}
