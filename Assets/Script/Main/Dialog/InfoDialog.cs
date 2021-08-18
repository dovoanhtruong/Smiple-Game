using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoDialog : Dialog
{
    public Dialog infoDialog;
    public Dialog menuDialog;
    public Dialog logoutDialog;

    public void ShowLogoutDialog(){
    if(logoutDialog)
    logoutDialog.Show(true);
    infoDialog.Show(false);
      }
      public void ShowMenuDialog(){
    if(menuDialog)
    menuDialog.Show(true);
    infoDialog.Show(false);
      }
}
