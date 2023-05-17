using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;

public class script : MonoBehaviour
{
    public GameObject mainpanel;
    public GameObject storypanel;
    public GameObject creditspanel;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    // Start is called before the first frame update
    void Start()
    {
        mainpanel.SetActive(true);
        storypanel.SetActive(false);
        creditspanel.SetActive(false);
        wall1.SetActive(false);
        wall2.SetActive(false);
        wall3.SetActive(false);
        wall4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showcredits() {
        mainpanel.SetActive(false);
        creditspanel.SetActive(true);
    }

    public void showstory() {
        mainpanel.SetActive(false);
        storypanel.SetActive(true);
    }

    public void showmain() {
        creditspanel.SetActive(false);
        mainpanel.SetActive(true);
    }

    public void activegame() {
        creditspanel.SetActive(false);
        wall1.SetActive(true);
    }

    public void activewall1() {
        if (wall4.activeSelf) {
            wall4.SetActive(false);
            wall1.SetActive(true);
        }
        else {
            wall2.SetActive(false);
            wall1.SetActive(true);
        }
    }

    public void activewall2() {
        if (wall3.activeSelf) {
            wall3.SetActive(false);
            wall2.SetActive(true);
        }
        else {
            wall1.SetActive(false);
            wall2.SetActive(true);
        }
    }

    public void activewall3() {
        if (wall2.activeSelf) {
            wall2.SetActive(false);
            wall3.SetActive(true);
        }
        else {
            wall4.SetActive(false);
            wall3.SetActive(true);
        }
    }
    public void activewall4() {
        if (wall1.activeSelf) {
            wall1.SetActive(false);
            wall4.SetActive(true);
        }
        else {
            wall3.SetActive(false);
            wall4.SetActive(true);
        }
    }

    public void restart() {
        SceneManager.LoadScene(0);
    }

    public void quit() {
        Application.Quit();
    } 
}
