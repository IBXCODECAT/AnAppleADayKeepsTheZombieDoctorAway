using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{

    public static UserInterface instance;

    public GameObject healthBar;
    public GameObject tint;
    public GameObject button1;
    public GameObject button2;
    public Image tintImage;

    [HideInInspector]
    public bool gameOver;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameOver = false;
        healthBar.SetActive(true);
        tint.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        Time.timeScale = 1f;
    }

    public void dead()
    {
        gameOver = true;
        Debug.Log("dead called");
        Time.timeScale = 0f;
        healthBar.SetActive(false);
        tint.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void respawn()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        Application.Quit();
    }
}
