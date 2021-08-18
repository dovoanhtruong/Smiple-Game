using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeGUI : MonoBehaviour
{
  public Text bestCoinText;
   int coin1;
      int coin2;
   int coin3;
public void Start()
  {
       if(bestCoinText){
         
           coin1 = PlayerPrefs.GetInt("coin");
         bestCoinText.text=coin1.ToString();
      
      }
  }
// public int biendiem(){
//  PlayerPrefs.SetInt("coin3",coin3);
//          coin1 = PlayerPrefs.GetInt("coin");
//         coin2=PlayerPrefs.GetInt("coin3");
//         coin3=coin1+coin2;
//         if(coin3>coin2){
//            PlayerPrefs.SetInt("coin3",coin3);
//         }
//         int coin4=PlayerPrefs.GetInt("coin3");
//         return coin4;

}


