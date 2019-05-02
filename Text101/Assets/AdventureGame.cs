﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    [SerializeField]
    Text textComponent;

    [SerializeField]
    State startingState;

    private State currentState;

    // Start is called before the first frame update
    void Start() {
        currentState = startingState;
        textComponent.text = currentState.getStoryText();
    }

    // Update is called once per frame
    void Update() {

    }
}
