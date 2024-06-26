using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MasterScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene_2");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Scene_3");
    }
}