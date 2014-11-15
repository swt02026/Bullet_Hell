using UnityEngine;
using System.Collections;
//shoot circle clockwise
public sealed class shoot_cw : shooter
{
    private shoot_cw() { }
    private static shooter instance = new shoot_cw();
    public static shooter Instance
    {
        get
        {
            return instance;
        }
    }
    public override void shoot()
    {
        float each_angle = fanAngle / density, CurAngle = 0;
        for (int j = 0; j < density; j++)
        {
            GameObject bullet = MonoBehaviour.Instantiate(bulletPrefab
                , shotpoint
                , Quaternion.Euler(0, 0, CurAngle)) as GameObject;
            bullet.transform.Translate(new Vector3(1, 0, 1));
            bullet.rigidbody2D.velocity = bullet.transform.rotation * new Vector2(0, 1);
            CurAngle += each_angle;
        }
    }
}
