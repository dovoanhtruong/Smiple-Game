using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDialog : Dialog
{
     public Dialog insertDialog;
      public Dialog userDialog;
      public Dialog sucsessLoginDialog;
      public Dialog failDialog;


    public void ShowsucsessLoginDialog(){
    if(sucsessLoginDialog)
    sucsessLoginDialog.Show(true);
    userDialog.Show(false);
      }

         public void ShowFailDialog(){
    if(failDialog)
    failDialog.Show(true);
    userDialog.Show(false);
      }

      public void ShowInsertDialog(){
    if(insertDialog)
    insertDialog.Show(true);
    userDialog.Show(false);
      }
}
