using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingMaker : MonoBehaviour
{
    Coroutine building;

    public Transform[] pieces;

    public float pieceBuildTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        building = StartCoroutine(Builder());

        for (int i = 0; i < pieces.Length; i++)
        {
            pieces[i].localScale = Vector3.zero;
        }
    }

    IEnumerator Builder()
    {
       for(int i = 0; i < pieces.Length; i++)
        {
            float timer = 0;

            while (timer < pieceBuildTime)
            {
                timer += Time.deltaTime;

                pieces[i].localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timer/pieceBuildTime);

                yield return null;
            }
        }
    }
}
