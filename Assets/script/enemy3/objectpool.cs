using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectpool : MonoBehaviour
{
    [SerializeField]
    protected GameObject objecttopool1;
    [SerializeField]
    protected int poolsize = 10;
    protected Queue<GameObject> Objectpool;
    public Transform spawnedobjectparent;


    private void Awake()
    {
        Objectpool = new Queue<GameObject>();
    }
    public void Initialized(GameObject objecttoppol, int poolsize = 10)
    {
        this.objecttopool1 = objecttoppol; // dan
        this.poolsize = poolsize; // so luong
    }
    public GameObject createobject()
    {
        createobjectparentifneeded();
        GameObject spawnedobject = null;
        if (Objectpool.Count < poolsize)
        {
            spawnedobject = Instantiate(objecttopool1, transform.position, Quaternion.identity);
            spawnedobject.name = transform.root.name + "-" + objecttopool1.name + "-" + Objectpool.Count;
            spawnedobject.transform.SetParent(spawnedobjectparent);
            spawnedobject.AddComponent<distroydisdable>();// cho het thanh phan cua script distroydisdable vao 

        }
        else
        {                                            //lay ra dau
            spawnedobject = Objectpool.Dequeue(); // ch?y het phan tu duoc them vao boi enqueue thì dequeue cho phep dung lai
           spawnedobject.transform.position = transform.position;
            spawnedobject.transform.rotation = Quaternion.identity;
            spawnedobject.SetActive(true);

        }
        Objectpool.Enqueue(spawnedobject);//them vao cuoi
        return spawnedobject;
    }
    private void createobjectparentifneeded()
    {
        if (spawnedobjectparent == null)
        {
            string name = "objectpool_" + objecttopool1.name;
            var parentobjeact = GameObject.Find(name);
            if (parentobjeact != null)
            {
                spawnedobjectparent = parentobjeact.transform;

            }
            else
            {
                spawnedobjectparent = new GameObject(name).transform;
                
            }
        }
    }
    private void OnDestroy()
    {
        foreach (var item in Objectpool)
        {
            if (item == null)
            {
                continue;
            }
            else if (item.activeSelf == false)
            {
                Destroy(item);
            }
            else
            {
                item.GetComponent<distroydisdable>().selfdestructionenabled = true;
            }
        }
    }
}
