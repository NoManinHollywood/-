﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Tools : MonoBehaviour
{
    public ItemReader reader;
    void Start()
    {
        reader.LoadItemsFromXML();
    }

}