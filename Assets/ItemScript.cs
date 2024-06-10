using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //DestroySelf();
        animator.SetTrigger("Get");
        Debug.Log("Enter");
    }
    //�ڐG��
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    //���E����
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");

    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
