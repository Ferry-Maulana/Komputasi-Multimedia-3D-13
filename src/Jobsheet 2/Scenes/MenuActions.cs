﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour
{
    public void MENU_ACTION_GotoPage(string scheneName)
    {
        Application.LoadLevel(scheneName);
    }
}
