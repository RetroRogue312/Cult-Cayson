using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class GameScript : MonoBehaviour
{
    public TMP_Text health;
    public TMP_Text enemyHealth;
    public double hp;
    public double enemyHp;
    public TMP_Text endText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 100;
        enemyHp = 100;
        health = GameObject.FindObjectWithTag("enemyHealth");
        enemyHealth = GameObject.FindObjectWithTag("yourHealth");
        endText = GameObject.FindObjectWithTag("end");
    }

    // Update is called once per frame
    void Update()
    {
        hp -= 0.01;
        if (Keyboard.current.spaceKey.isPressedThisFrame || Mouse.current.leftButton.isPressedThisFrame)
        {
            enemyHp -= 5;
            enemyHealth.SetText(enemyHp + "%");
        }

        if (hp == 0)
        {
            endText.SetActive(true);
        }else if (enemyHp = 0)
            endText.SetActive(true);
            endText.SetText("Game Over");
    }
}
