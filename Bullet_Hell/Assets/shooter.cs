using UnityEngine;
using System.Collections;

public abstract class shooter {
    protected GameObject bulletPrefab;
    public float fanAngle=360;
    public int density = 20;
    protected Vector3 shotpoint;
    public GameObject BulletPrefab
    {
        set
        {
            bulletPrefab = value;
        }
    }
    public Vector3 ShotPoint
    {
        set
        {
            shotpoint = value;
        }
    }
    abstract public void shoot();
}

