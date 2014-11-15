using UnityEngine;
using System.Collections;

public sealed class shoot_cross_ellipse : shooter
{
    private shoot_cross_ellipse() { }
    private static shooter instance = new shoot_cross_ellipse();
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
                , shotpoint + Quaternion.Euler(0, 0, -CurAngle) * new Vector3(1, 0, 1)
                , Quaternion.Euler(0, 0, CurAngle)) as GameObject;
            bullet.rigidbody2D.velocity = bullet.transform.rotation * new Vector2(0, 1);
            GameObject bullet2 = MonoBehaviour.Instantiate(bulletPrefab
                , shotpoint + Quaternion.Euler(0, 0, CurAngle) * new Vector3(-1, 0, 1)
                , Quaternion.Euler(0, 0, -CurAngle)) as GameObject;
            bullet2.rigidbody2D.velocity = bullet2.transform.rotation * new Vector2(0, 1);
            CurAngle += each_angle;
        }
    }
}
