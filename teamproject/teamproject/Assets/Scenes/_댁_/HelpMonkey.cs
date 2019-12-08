using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpMonkey : MonoBehaviour
{
    private AudioSource Oaudio;
    private AudioSource Xaudio;
    public AudioClip OSound;
    public AudioClip XSound;
    public GameObject Chairobject;
    public GameObject Duckobject;
    public GameObject Monkeyobject;
    public GameObject Milkobject;
    public GameObject Penobject;
    public GameObject Umbrellaobject;

    void Start()
    {
        this.Oaudio = this.gameObject.AddComponent<AudioSource>();
        this.Oaudio.clip = this.OSound;
        this.Oaudio.loop = false;

        this.Xaudio = this.gameObject.AddComponent<AudioSource>();
        this.Xaudio.clip = this.XSound;
        this.Xaudio.loop = false;

    }

    void OnMouseDown()
    {
        if (grab3.inHand66)
        {
            grab3.newText[2].enabled = true;
            grab3.newText[2].text = "참 잘했어요!";
            this.Oaudio.Play();
            Destroy(Umbrellaobject);
            Invoke("DisableText", 1f);
            Invoke("ChangeScene", 2f);
        }

        else if (grab3.inHand11)
        {
            grab3.newText[2].enabled = true;
            grab3.newText[2].text = "원숭이를 젖지 않게 해 주세요!";
            this.Xaudio.Play();
            Destroy(Chairobject);
            Invoke("DisableText", 1f);
        }
        else if (grab3.inHand22)
        {
            grab3.newText[2].enabled = true;
            grab3.newText[2].text = "원숭이를 젖지 않게 해 주세요!";
            this.Xaudio.Play();
            Destroy(Duckobject);
            Invoke("DisableText", 1f);
        }
        else if (grab3.inHand44)
        {
            grab3.newText[2].enabled = true;
            grab3.newText[2].text = "원숭이를 젖지 않게 해 주세요!";
            this.Xaudio.Play();
            Destroy(Milkobject);
            Invoke("DisableText", 1f);
        }
        else if (grab3.inHand55)
        {
            grab3.newText[2].enabled = true;
            grab3.newText[2].text = "원숭이를 젖지 않게 해 주세요!";
            this.Xaudio.Play();
            Destroy(Penobject);
            Invoke("DisableText", 1f);
        }
            
    }
    void DisableText()
    {
        grab3.newText[2].enabled = false;
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("gameend");
    }
}
