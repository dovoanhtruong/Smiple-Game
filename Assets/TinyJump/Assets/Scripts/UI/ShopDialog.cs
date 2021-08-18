using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ShopDialog : Dialog
{
public Dialog platformDialog;
public Dialog shopDialog;

       public void ShowPlatformDialog(){
    if(platformDialog)
    platformDialog.Show(true);
    shopDialog.Show(false);
      }
       public void abc(){
   print("vwev");
      }
}

