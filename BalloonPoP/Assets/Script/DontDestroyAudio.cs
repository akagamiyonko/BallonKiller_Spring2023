using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public static DontDestroyAudio Instance;
    void Awake() {
        if (Instance == null)
            {
                DontDestroyOnLoad(this);
                Instance = this;
            }
            else
                Destroy(gameObject);
   }
}
