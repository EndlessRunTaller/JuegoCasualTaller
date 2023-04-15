using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController current;
    public float MaxScore;

    // Start is called before the first frame update
    private void Awake()
    {
        if(current == null)
        {
            current = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
