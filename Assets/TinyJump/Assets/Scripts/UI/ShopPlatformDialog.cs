using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPlatformDialog : Dialog
{
public Dialog shopPlatformDialog;
public Dialog shopDialog;

    public void ShowShopDialog(){
    if(shopDialog)
    shopDialog.Show(true);
    shopPlatformDialog.Show(false);
      }
}
