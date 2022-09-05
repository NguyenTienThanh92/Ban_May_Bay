using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;


public class PlaneController : MonoBehaviour

{
    public BulletController bullet;
    public Transform transhoot;
    public float hp;
    public float level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void Shoot()
    {
        CreatBullet(transhoot);
    }
    public BulletController CreatBullet(Transform transhoot)
    {
        BulletController bulletclone = PoolingObject.createPooling<BulletController>(bullet);
        if (bulletclone == null)
        {
            return Instantiate(bullet, transhoot.position, transhoot.rotation);
        }
        bulletclone.time = 0;
        bulletclone.transform.position = transhoot.position;
        bulletclone.transform.rotation = transhoot.rotation;
        bulletclone.damage += level;
        bulletclone.tag = this.tag;
        return bulletclone;
    }

}
