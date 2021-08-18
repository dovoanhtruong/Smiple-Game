using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPlatform : Singleton<ShopPlatform>
{

    public GameObject platform;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
 
 public void plat4(){
    if(platform4)
    // charaterPlayer2.enabled = true;
    platform2.SetActive(false);
    platform.SetActive(false);
    platform3.SetActive(false);
    platform4.SetActive(true);
}
public void plat2(){
    if(platform2)
    // charaterPlayer2.enabled = true;
    platform2.SetActive(true);
    platform.SetActive(false);
    platform3.SetActive(false);
    platform4.SetActive(false);
}
public void plat3(){
    if(platform3)
    // charaterPlayer2.enabled = true;
    platform2.SetActive(false);
    platform.SetActive(false);
    platform3.SetActive(true);
    platform4.SetActive(false);
}
}
