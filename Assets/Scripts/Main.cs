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

    public void Lose()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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

    }
}
