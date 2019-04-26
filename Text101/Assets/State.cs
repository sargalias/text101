﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State")]
public class State : ScriptableObject {
    // Start is called before the first frame update
    [SerializeField]
    [TextArea(10, 14)]
    string storyText;

    [SerializeField]
    State nextState;

    public string getStoryText() {
        return storyText;
    }

    public State getNextState() {
        return nextState;
    }
}
