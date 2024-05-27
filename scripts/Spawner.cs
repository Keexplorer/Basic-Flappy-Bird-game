using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird_script birdy;
    public GameObject borular;
    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(spawner_boru(time));
    }

    public IEnumerator spawner_boru(float time)
    {
        while(!birdy.Isdead)
        {
            Instantiate(borular,new Vector3(2,Random.Range(0,height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
        
    }
}
