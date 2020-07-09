using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelection : MonoBehaviour
{

    //we craete an empty gameobject lsit
    GameObject[] carList;

    // Start is called before the first frame update
    void Start()
    {
        carList = new GameObject[transform.childCount];


        //loop through the child items and fill the list in the corret slots
        for(int i=0;i<transform.childCount;i++)
        {
            carList[i] = transform.GetChild(i).gameObject;
        }

        //deactivate all the gameobject in the list
        foreach(GameObject gameObj in carList)
        {
            gameObj.SetActive(false);
        }


        //set the initial gameobject to be active
        if(carList[0])
        {
            carList[0].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
