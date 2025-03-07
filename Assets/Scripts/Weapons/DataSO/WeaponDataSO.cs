using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/WeaponData")]
public class WeaponDataSO : ScriptableObject
{
    [field: SerializeField]
    public BulletDataSO BulletData { get; set; }

    [field: SerializeField]
    [field: Range(0, 999)]
    public int AmmoCapacity { get; set; } = 100;

    [field: SerializeField]
    public bool AutomaticFire { get; set; } = false;

    [field: SerializeField]
    [field: Range(0f, 2f)]
    public float WeaponDelay { get; set; } = 0f;

    [field: SerializeField]
    [field: Range(0f, 10f)]
    public float SpreadAngle { get; set; } = 5;

    [SerializeField]
    private bool multiBulletShoot = false;

    [SerializeField]
    [field: Range(1, 10)]
    private int bulletCount = 1;

    internal int GetBulletCountToSpawn()
    {
        if (multiBulletShoot)
        {
            return bulletCount;
        }
        else
        {
            return 1;
        }
    }
}
