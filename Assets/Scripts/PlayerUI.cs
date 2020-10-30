using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    private PlayerPoints _points;
    private PlayerDamage _damage;

    [SerializeField]
    private GameObject _deathScreen;

    public List<Animator> livesUI = new List<Animator>();
    public TMP_Text ScoreTxt;

    void Awake()
    {
        _points = FindObjectOfType<PlayerPoints>();
        _damage = FindObjectOfType<PlayerDamage>();
        _points.UpdatePoints += UpdatePointsTxt;
        _damage.UpdateHp += UpdateHpUI;
        _damage.PlayerDie += ToggleDeathScreen;
    }

    private void ToggleDeathScreen()
    {
        _deathScreen.SetActive(true);
    }

    private void UpdatePointsTxt(int points)
    {
        string value = "Score: " + points;

        ScoreTxt.text = value;
    }

    private void UpdateHpUI(int hp)
    {
        for (int i = 0; i < hp; i++)
        {
            livesUI[i].SetBool("isActive", true);
        }


        for (int i = hp; i < livesUI.Count; i++)
        {
            livesUI[i].SetBool("isActive", false);
        }
    }
}
