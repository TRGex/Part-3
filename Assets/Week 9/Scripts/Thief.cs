using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float dashSpeed = 7;
    Coroutine dashing;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    //protected override void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        speed = 3;
    //    }
    //    base.Update();

    //}

    protected override void Attack()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(dashing != null)
        {
            StopCoroutine(dashing);
        }
        dashing = StartCoroutine(Dash());
    }

    IEnumerator  Dash()
    {
        speed += dashSpeed;
        while (speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);
    }


}
