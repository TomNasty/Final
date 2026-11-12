using System.Collections;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    [SerializeField]// ref to music library and music source
    private MusicLibrary musicLibrary;
    [SerializeField]
    private AudioSource musicSource;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);//unecessary duplicate. deadly force authorized
        }
        else
        {
            instance = this;// wait a second boys, he's chill
            DontDestroyOnLoad(gameObject);
        }
    }
    public void PlayMusic(string trackName, float fadeDuration = 0.5f)
    {//basically play the song and get info about it on a separate thread (for performance reasons)
        StartCoroutine(AnimateMusicCrossfade(musicLibrary.GetClipFromName(trackName), fadeDuration));
    }
    /* take in audio clip we want to play as well as a fade duration (by default 0.5 seconds)
     * 
     * */
    IEnumerator AnimateMusicCrossfade(AudioClip nextTrack, float fadeDuration = 0.5f)
    {
        float percent = 0;// temp float percent
        while (percent < 1)
        {
            percent += Time.deltaTime * 1 / fadeDuration;
            musicSource.volume = Mathf.Lerp(1f, 0, percent);
            yield return null;//idk what this does
        }
        musicSource.clip = nextTrack;//replace track with new track
        musicSource.Play();//play next track
        percent = 0;
        while (percent < 1)//fade in next song
        {
            percent += Time.deltaTime * 1 / fadeDuration;
            musicSource.volume = Mathf.Lerp(0, 1f, percent);
            yield return null;
        }
    }
}
