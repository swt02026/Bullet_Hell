using UnityEngine;
using System;
using System.Collections;

public class shot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float fanAngle;
    public int density = 20;
    shooter Shooter;
    bool Shooting = false;
    // Use this for initialization
    void Start()
    {
        changeShootStyle(1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Shooting)
        {
            Shooter.shoot();
            Shooting = false;
        }
    }
    public void BeginningShot()
    {
        Shooting = true ;
    }
    public void changeShootStyle(int style){
        switch (style){
            case 0:
                Shooter = shoot_ccw.Instance;
                break;
            case 1:
                Shooter = shoot_cross_ellipse.Instance;
                break;
            case 2:
                Shooter = shoot_cw.Instance;
                break;
        }
        Shooter.BulletPrefab = bulletPrefab;
        Shooter.ShotPoint = transform.position;
    }
}
