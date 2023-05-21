using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aidetector : MonoBehaviour
{
    [Range(1, 20)] // 
    [SerializeField]
    private float vieawradius = 11; // ban kinh pham vi
    [SerializeField]
    private float detectioncheckdelay = 0.1f;
    [SerializeField]
    private Transform target = null;
    [SerializeField] private LayerMask playerlayerMask;
    [SerializeField] private LayerMask visibillitylayer;
    [field: SerializeField]
    public bool targetvisible { get; private set; } // set : cai dat san, get lay ra
    public Transform Target
    {
        get => target;
        set
        {
            target = value;
            targetvisible = false;
        }
    }
    private void Start()
    {
        StartCoroutine(DetectionCoroutine()); // muc dich goi corotine ngay tu dau va se khong bao gio dung lai neu enemy khong bi tieu diet
    }
    private void Update() // muc dich la ngung ban khi doi tung nup sau ngai v?t
    {
        if (Target != null)
        {
            targetvisible = checktargetvisible();
        }
    }
    private bool checktargetvisible()
    {
        //var result = Physics2D.Raycast(transform.position,Target.position - transform.position,vieawradius,visibillitylayer);

        if (Target == true) // se co 1 va cham co gia tri / /result.collider != null
        {
            return true;// (playerlayerMask & (1 << result.collider.gameObject.layer)) != 0; // = return true a!= b = true

        }
        return true;
    }
    private void detectarget()//2
    {
        if (Target == null) // neu vo gia tri thì kiem tra player co trong pham vi hay khong
        {
            checkifplayerinrange();
        }
        else if (Target != null) // muc tieu co the di chuyen ra khoi pham vi nay
        {
            detectifoutofrange();// kiem tra muc tieu co di chuyen ra khoi khu vuc khong
        }

    }
    private void detectifoutofrange()
    {                                               //distance(vitri1,vitri2) vi tri tu may do den player co lon on ban kinh khong
        if (Target == null || Target.gameObject.activeSelf == false || Vector2.Distance(transform.position, Target.position) > vieawradius)//gameobject.activesefl
        {
            Target = null; // thi target vo gia tri
        }
    }
    private void checkifplayerinrange()
    {
        Collider2D collision1 = Physics2D.OverlapCircle(transform.position, vieawradius, playerlayerMask);// tap vong pham vi phat hien
        if (collision1 != null)
        {
            Target = collision1.transform;    // dat lam muc tieu vi tri va cham voi player = vi tri target?
        }
    }
    IEnumerator DetectionCoroutine()//1 
    {
        yield return new WaitForSeconds(detectioncheckdelay); // do tre phat hien ra player
        detectarget(); // thuc hien phat hien muc tieu
        StartCoroutine(DetectionCoroutine());// chay lai quy trinh tinh diem
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, vieawradius);

    }
}
