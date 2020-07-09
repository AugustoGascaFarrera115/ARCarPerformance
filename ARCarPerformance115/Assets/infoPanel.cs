using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoPanel : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void showInfo()
    {
        anim.Play("infoAnimation");
    }

    public void closeInfo()
    {
        anim.Play("infoAnimationReverse");
    }
}
