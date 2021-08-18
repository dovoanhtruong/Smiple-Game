using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformDialog : Dialog
{
   public Dialog platformDialog;
public Dialog shopDialog;

    public void ShowShopDialog(){
    if(shopDialog)
    shopDialog.Show(true);
    platformDialog.Show(false);
      }

}
