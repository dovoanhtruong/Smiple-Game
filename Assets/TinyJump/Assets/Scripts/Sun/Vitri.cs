using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitri : MonoBehaviour
{
      public GameObject move;
    public GameObject vitri;
    // Start is called before the first frame update
    void Start()
    {
          StartCoroutine(tao());
    }

    IEnumerator tao(){
        yield return  new WaitForSeconds(2f);
        Vector3 temp=vitri.transform.position;
        temp.x=Random.Range(-1.5f,1.5f);
        temp.y=Random.Range(6.5f,6.6f);
        Instantiate(move,temp,Quaternion.identity);
         StartCoroutine(tao());
    }
}
