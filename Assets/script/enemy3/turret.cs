using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class turret : MonoBehaviour
{
    public List<Transform> turretbarrels;
    //public turretdata turretdata;

    public GameObject bulletprefab;
    public float reloaddelay = 1;
    private bool canshoot = true;
    private Collider2D[] enemycollider;
    public float currentdelay = 0;

    private objectpool bulletpool;
    [SerializeField] private int bulletpoolcount = 10;
    private void Awake()
    {
        enemycollider = GetComponentsInParent<Collider2D>();
        bulletpool = GetComponent<objectpool>();
    }
    private void Start()
    {
        bulletpool.Initialized(bulletprefab, bulletpoolcount);
    }
    private void Update()
    {
        if (canshoot == false)
        {
            currentdelay -= Time.deltaTime;
            if (currentdelay <= 0)
            {
                canshoot = true;
            }
        }
    }
    public void shoot()
    {
        if (canshoot)
        {
            canshoot = false;
            currentdelay = reloaddelay;
            foreach (var barrel in turretbarrels)
            {
                //GameObject bullet = Instantiate(bulletprefab);
                GameObject bullet = bulletpool.createobject();
                bullet.transform.position = barrel.position;
                bullet.transform.localRotation = barrel.rotation;
                bullet.GetComponent<bullet>().initialize();
                foreach (var collider in enemycollider)
                {
                    Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), collider);
                }
            }
        }
    }
}
