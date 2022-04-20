using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Player player;
    public Text coinText;
    public Image[] hearts;
    public Sprite isLife, nonLife;
    public GameObject PauseScreen;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    float timer = 0f;
    public Text timeText;
    public TimeWork timeWork;
    public float countdown;

    public void Reloadlvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Start()
    {
        if ((int)timeWork == 2) 
        {
            timer = countdown;
        }
    }

    public void Update()
    {
        coinText.text = player.GetCoins().ToString();

        for(int i=0; i<hearts.Length;i++)
        {
            if (player.GetHP() > i)
            {
                hearts[i].sprite = isLife;
            }
            else
            {
                hearts[i].sprite = nonLife;
            }
        }


        if ((int)timer == 1)
        {
            timer += Time.deltaTime;
            timeText.text = timer.ToString("F2").Replace(",", ":");
        }
        else if ((int)timer == 2)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Lose();
            }
        }
        else
            {
                timeText.gameObject.SetActive(false);
            }
    }

    public void PauseOn()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        PauseScreen.SetActive(true);
    }   
    
    public void PauseOff()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        PauseScreen.SetActive(false);
    }

    public void Win()
    {
        Time.timeScale = 0f;
        player.enabled = true;
        WinScreen.SetActive(true);

        if (!PlayerPrefs.HasKey("Lvl") || PlayerPrefs.GetInt("Lvl") < SceneManager.GetActiveScene().buildIndex) 
        {
            PlayerPrefs.SetInt("Lvl", SceneManager.GetActiveScene().buildIndex);
        }

        if (PlayerPrefs.HasKey("coins"))
        {
            PlayerPrefs.SetInt("coins",  + player.GetCoins());
        }
        else
        {
            PlayerPrefs.SetInt("coins", player.GetCoins());
        }

    }
    public void Lose()
    {
        Time.timeScale = 0f;
        player.enabled = true;
        LoseScreen.SetActive(true);
    }

    public void Menulvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene("Menu");
    }

    public void NextLvl()
    {
        Time.timeScale = 1f;
        player.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

public enum TimeWork
{
    None,
    StopWatch,
    Timer
}
