using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGUIManager : Singleton<GameGUIManager>
{
   public GameObject homeGui;
   public GameObject gameGui;
   public Text scoreCountingText;
    public Text coinCountingText;
   public Image powerBarSlider;
    public Dialog bXHDialog;
   public Dialog achievementDialog;
   public Dialog helpDialog;
   public Dialog gameOverDialog;
   public Dialog userDialog;
    public Dialog insertDialog;
    public Dialog sucsessDialog;
    public Dialog sucsessLoginDialog;
    public Dialog shopDialog;
    public Dialog platformDialog;
    public GameObject vitriSun;
    public GameObject creatSun;
    // public AudioController audioTiny;

    



public override void Awake(){
    MakeSingleton(false);
}

public void ShowMainScene()
	{
		Application.LoadLevel("Main");
        AudioController.Ins.StopPlayMusic();

	}

    // public void StopMusic(){
    //     audioTiny.StopPlayMusic();
    // }
public void ShowGameGUI(bool isShow){
    if(gameGui)
    gameGui.SetActive(isShow);
    if(homeGui)
    homeGui.SetActive(!isShow);
}
public void UpdateScoreCounting(int score){
    if(scoreCountingText)
    scoreCountingText.text = score.ToString();
}

public void UpdateCoinCounting(int coin){
    if(coinCountingText)
    coinCountingText.text = coin.ToString();
}

public void UpdatePowerBar(float curVal,float totaVal){
    if(powerBarSlider)
    powerBarSlider.fillAmount = curVal / totaVal;
}
public void ShowAchievementDialog(){
    if(achievementDialog)
    achievementDialog.Show(true);
}
public void ShowBXHDialog(){
    if(bXHDialog)
    bXHDialog.Show(true);
}

public void ShowHelpDialog(){
    if(helpDialog)
    helpDialog.Show(true);
}
public void ShowGameOverDialog(){
    if(gameOverDialog)
    gameOverDialog.Show(true);
}
public void ShowUserDialog(){
    if(userDialog)
    userDialog.Show(true);
}
public void ShowShopDialog(){
    if(shopDialog)
    shopDialog.Show(true);
}
   

}
