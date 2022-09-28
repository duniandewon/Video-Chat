using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

[CreateAssetMenu(fileName = "MenuManager", menuName = "Managers/MenuManager")]
public class MenuManager : ScriptableObject
{
    #region Public Methods
    public void OpenMenu(GameObject menu)
    {
        menu.SetActive(true);
    }

    public void CloseMenu(GameObject menu)
    {
        menu.SetActive(false);
    }
    #endregion
}
