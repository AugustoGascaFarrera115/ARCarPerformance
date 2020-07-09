using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSelection : MonoBehaviour
{

    //we craete an empty gameobject lsit
    GameObject[] carList;
    int currentCar = 0;

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

    public void toggleCar(string direction)
    {
        carList[currentCar].SetActive(false);

        if(direction == "Right")
        {
            currentCar++;

            if(currentCar > carList.Length - 1)
            {
                currentCar = 0;
            }


        }
        else if(direction == "Left")
        {
            currentCar--;

            if(currentCar < 0)
            {
                currentCar = carList.Length - 1;

            }

        }

        //set the car to be activate
        carList[currentCar].SetActive(true);

        GameObject cloudSystem = Instantiate(Resources.Load("cloudParticle")) as GameObject;
        ParticleSystem cloudPuff = cloudSystem.GetComponent<ParticleSystem>();
        cloudPuff.Play();
        cloudPuff.transform.position = new Vector3(22f, -0.1f, -1f);
        Destroy(cloudSystem, 2f);


    }
}
