using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject zemin;
    public GameObject otob�s;
    public GameObject next;
    public Animator myAnimator;
    public Animator kartAnimator;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            zemin.SetActive(true);
            otob�s.SetActive(true);
            next.SetActive(true);
            Time.timeScale = 0;
            myAnimator.SetBool("otob�s", true);
            kartAnimator.enabled = true;
        }
        
    }
}
