using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
public Player playerPrefab;
public Platform platformPrefab;
public float minSpawmX;
public float maxSpawmX;
public float minSpawmY;
public float maxSpawmY;
public CamController mainCam;
public float powerBarUp;
  public GameObject move;
    public GameObject vitri;

Player m_player;
int m_score;
int m_coin;
public static int m_coinEnd;

bool m_isGameStarted;

public bool IsGameStarted{get => m_isGameStarted;}


public override void Awake(){
    MakeSingleton(false);
}
public override void Start(){
    base.Start();
    GameGUIManager.Ins.UpdateScoreCounting(m_score);
    GameGUIManager.Ins.UpdateCoinCounting(m_coin);
    // GameGUIManager.Ins.ShowGameGUI(false);
    GameGUIManager.Ins.UpdatePowerBar(0,1);

    AudioController.Ins.PlayBackgroundMusic();
}


public void PlayGame(){
    StartCoroutine(PlatformInit());
    GameGUIManager.Ins.ShowGameGUI(true);

}

IEnumerator PlatformInit(){
    Platform platformClone=null;
    if (platformPrefab){
        platformClone = Instantiate(platformPrefab,new Vector2(0,Random.Range(minSpawmY,maxSpawmY)),Quaternion.identity);
        platformClone.id = platformClone.gameObject.GetInstanceID();
    }
    yield return new WaitForSeconds(0.5f);
    if (playerPrefab){
        m_player = Instantiate(playerPrefab, Vector3.zero,Quaternion.identity);
        m_player.lastPlatformId = platformClone.id;
    }
   if (platformPrefab){
       float spawnX=m_player.transform.position.x + minSpawmX;
       float spawnY=Random.Range(minSpawmY,maxSpawmY);
       Platform platformClone02 = Instantiate(platformPrefab,new Vector2(spawnX,spawnY),Quaternion.identity);
       platformClone02.id = platformClone02.gameObject.GetInstanceID();
   }

    yield return new WaitForSeconds(0.5f);
m_isGameStarted =true;
}
public void CreatePlatform(){
    if(!platformPrefab || !m_player)
    return;
    float spawnX = Random.Range(m_player.transform.position.x + minSpawmX, m_player.transform.position.x+maxSpawmX);
    float spawnY = Random.Range(minSpawmY,maxSpawmY);

    Platform platformClone = Instantiate(platformPrefab,new Vector2(spawnX,spawnY),Quaternion.identity);
    platformClone.id = platformClone.gameObject.GetInstanceID();

  Vector3 temp=vitri.transform.position;
   temp.x= Random.Range(m_player.transform.position.x + minSpawmX, m_player.transform.position.x+maxSpawmX);
        // temp.x=Random.Range(-1.5f,1.5f);
        temp.y=Random.Range(6.5f,6.6f);
        Instantiate(move,temp,Quaternion.identity);
}
public void CreatePlatformAndLerp(float playerXpos){
    if(mainCam)
    mainCam.LerpTrigger(playerXpos + minSpawmX);
    CreatePlatform();
}
public void AddScore(){
    m_score++;
    Prefs.bestScore = m_score;
    GameGUIManager.Ins.UpdateScoreCounting(m_score);
    AudioController.Ins.PlaySound(AudioController.Ins.getScore);
}
public void AddCoin(){
    m_coin++;
}
public void ShowCoin(){
    m_coinEnd =+ m_coin;
        PlayerPrefs.SetInt("coin",m_coinEnd);
        // PlayerPrefs.Save();
            GameGUIManager.Ins.UpdateCoinCounting(m_coinEnd);
}
}
