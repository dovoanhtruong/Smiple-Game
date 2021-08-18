using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuDialog : Dialog
{
    public Dialog menuDialog;
    public Dialog infoDialog;

    public void ShowInfoDialog(){
    if(infoDialog)
    infoDialog.Show(true);
    menuDialog.Show(false);
      }
}
