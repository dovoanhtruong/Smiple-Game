using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailDialog : Dialog
{
public Dialog userDialog;
public Dialog failDialog;
public void ShowUserDialog(){
    if(userDialog){
        userDialog.Show(true);
failDialog.Show(false);
    }
}
}
