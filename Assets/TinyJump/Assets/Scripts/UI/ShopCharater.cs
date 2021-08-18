using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCharater : Singleton<ShopCharater>
{
        public GameObject charaterPlayer;
    public GameObject charaterPlayer2;
    public GameObject charaterPlayer3;
    public GameObject charaterPlayer4;

    public GameObject platform;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;

//     public void charaterPlayer2(){
//     if(charaterPlayer2)
//     charaterPlayer2.en;
//      charaterPlayer3.Show(false);
//       charaterPlayer4.Show(false);
//        charaterPlayer.Show(false);
     
// }
public void char2(){
    if(charaterPlayer2)
    // charaterPlayer2.enabled = true;
    charaterPlayer2.SetActive(true);
    charaterPlayer.SetActive(false);
    charaterPlayer3.SetActive(false);
    charaterPlayer4.SetActive(false);
}
public void char3(){
    if(charaterPlayer3)
    // charaterPlayer2.enabled = true;
    charaterPlayer2.SetActive(false);
    charaterPlayer.SetActive(false);
    charaterPlayer3.SetActive(true);
    charaterPlayer4.SetActive(false);
}
public void char4(){
    if(charaterPlayer4)
    // charaterPlayer2.enabled = true;
    charaterPlayer2.SetActive(false);
    charaterPlayer.SetActive(false);
    charaterPlayer3.SetActive(false);
    charaterPlayer4.SetActive(true);
}


// public void plat4(){
//     if(platform4)
//     // charaterPlayer2.enabled = true;
//     platform2.SetActive(false);
//     platform.SetActive(false);
//     platform3.SetActive(false);
//     platform4.SetActive(true);
// }
// public void plat2(){
//     if(platform2)
//     // charaterPlayer2.enabled = true;
//     platform2.SetActive(true);
//     platform.SetActive(false);
//     platform3.SetActive(false);
//     platform4.SetActive(false);
// }
// public void plat3(){
//     if(platform3)
//     // charaterPlayer2.enabled = true;
//     platform2.SetActive(false);
//     platform.SetActive(false);
//     platform3.SetActive(true);
//     platform4.SetActive(false);
// }

}
