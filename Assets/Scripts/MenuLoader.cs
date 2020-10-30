using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    public GameObject activeMenu;
    public GameObject menuToActivate;

    public void LoadMenu()
    {
        menuToActivate.SetActive(true);
        activeMenu.SetActive(false);
    }
}
