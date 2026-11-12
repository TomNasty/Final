using UnityEngine;

public class TestAudio : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")){
            MusicManager.instance.PlayMusic("BossRend1");
        }
        else if (Input.GetKeyDown("w"))
        {
            MusicManager.instance.PlayMusic("TheLick");
        }
    }
}
