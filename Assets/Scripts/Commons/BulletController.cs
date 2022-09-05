using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController
{
    public float time = 0;
    public GameObject smoke;
    public float timeLimit;
    public float damage;
 

    void Update()
    {
        bulletEx();
        Move(this.transform.up);
    }

    protected virtual void bulletEx()
    {
        if (time == timeLimit)
        {
            PoolingObject.DestroyPooling<BulletController>(this);
            Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }
        time++;
    }
    protected virtual void OntriggerEnter2D(Collider2D colision)
    {
        Destroy(gameObject);
        Instantiate(smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
    }
    public virtual float CalculateHP(float hp)
    {
        var hpLeft = hp - damage;
        return hpLeft;
    }
}
