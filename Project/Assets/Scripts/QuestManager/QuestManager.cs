﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager: MonoBehaviour
{
    public Quest[] quest;   

    public int selectedQuest;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    public Quest GivePlayerQuest()
    {
        return quest[selectedQuest];
    }

}