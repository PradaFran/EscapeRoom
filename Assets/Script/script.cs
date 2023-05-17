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
    public GameObject cuadro;
    public GameObject jarron;
    public GameObject box;
    public GameObject imagehammer;
    public GameObject imagescrew;
    public GameObject cuadroroto;
    public GameObject panelLock;
    public GameObject clue1;
    public GameObject backclue1;
    public GameObject clue2;
    public GameObject backclue2;
    public GameObject clue3;
    public GameObject backclue3;
    public GameObject clue4;
    public GameObject backclue4;
    public GameObject panelderrota;
    public GameObject panelwin;
    public double time;
    public bool hammer=false;
    public bool screwdriver=false;
    public Text finalquizz;

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
        time=900;
    }

    // Update is called once per frame
    void Update()
    {
        if (!mainpanel.activeSelf) {
            time-=Time.deltaTime;
            if (finalquizz.text == "5297") {
                panelwin.SetActive(true);
                wall1.SetActive(false);
                wall2.SetActive(false);
                wall3.SetActive(false);
                wall4.SetActive(false);
            }
            else if (time < 0) {
                panelderrota.SetActive(true);
            }
        }
        
    }

    public void showcredits() {
        creditspanel.SetActive(true);
    }

    public void showstory() {
        storypanel.SetActive(true);
    }

    public void showmain() {
        creditspanel.SetActive(false);
    }

    public void activegame() {
        storypanel.SetActive(false);
        mainpanel.SetActive(false);
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

    public void givehammer() {
        imagehammer.SetActive(false);
        hammer = true;
    }

    public void givescrewdriver() {
        imagescrew.SetActive(false);
        screwdriver = true;
    }

    public void dropPaint() {
        cuadro.SetActive(false);
        cuadroroto.SetActive(true);
    }

    public void breakbox() {
        if (screwdriver) {
            box.SetActive(false);
        }
    }
    public void romperJarron() {
        if (hammer) {
            jarron.SetActive(false);
        }
    }

    public void restart() {
        SceneManager.LoadScene(0);
    }

    public void panelLockshow() {
        panelLock.SetActive(true);
    }

    public void clue1show() {
        clue1.SetActive(true);
    }

    public void clue1skip() {
        clue1.SetActive(false);
    }

    public void clue2show() {
        clue2.SetActive(true);
    }

    public void clue2skip() {
        clue2.SetActive(false);
    }

    public void clue3show() {
        clue3.SetActive(true);
    }

    public void clue3skip() {
        clue3.SetActive(false);
    }

    public void clue4kshow() {
        clue4.SetActive(true);
    }

    public void clue4kskip() {
        clue4.SetActive(false);
    }

    public void panelLockskip() {
        panelLock.SetActive(false);
    }

    public void quit() {
        Application.Quit();
    } 
}
