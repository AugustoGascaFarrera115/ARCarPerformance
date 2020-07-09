using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;





public class gameController : MonoBehaviour
{

    public static string currentSelectedCar = "myLamboConvert";

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        print(currentSelectedCar);
    }


    public void changeScene(string scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }

}
