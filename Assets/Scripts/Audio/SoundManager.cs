using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField]
    private SoundLibrary sfxLibrary;
    [SerializeField]
    private AudioSource sfx2DSource;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void PlaySound3D(AudioClip clip, Vector3 pos)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, pos);// spawns audio at position
        }
    }
    public void PlaySound3D(string soundName, Vector3 pos)//overload that takes string instead of clip
    {
        PlaySound3D(sfxLibrary.GetClipFromName(soundName), pos);
    }
    public void PlaySound2D(string soundName)//play sound in 2d for ui
    {
        sfx2DSource.PlayOneShot(sfxLibrary.GetClipFromName(soundName));
    }
}
