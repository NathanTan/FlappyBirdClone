using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird {

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public Difficulty difficulty;

    private void Awake()
    {
        if (Instance == null)
        {
            this.difficulty = Difficulty.Normal;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
}
