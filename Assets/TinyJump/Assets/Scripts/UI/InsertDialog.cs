using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertDialog : Dialog
{
public Dialog sucssesDialog;
public Dialog insertDialog;
 public void ShowsucsessDialog(){
    if(sucssesDialog)
    sucssesDialog.Show(true);
    insertDialog.Show(false);
      }

}
