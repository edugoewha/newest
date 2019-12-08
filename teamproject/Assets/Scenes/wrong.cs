using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrong : MonoBehaviour
{
    //public Text status;
    public int count;
    private AudioSource Xaudio;
    public AudioClip XSound;
    
    public GameObject rock;
    
    //Vector3 rockpos;

    // Start is called before the first frame update
    void Start()
    {
		//rockpos=rock.transform.position;
		
		this.Xaudio = this.gameObject.AddComponent<AudioSource>();
        this.Xaudio.clip = this.XSound;
        this.Xaudio.loop = false;
           //status = gameObject.GetComponentInChildren<Text>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rock"))
        {
			grab.newText[2].enabled = true;
			other.gameObject.transform.parent=null;
            //other.gameObject.SetActive (false);
            this.Xaudio.Play();
            grab.newText[2].text="다른 물건을 찾아보세요";
            //grab.rock.transform.localPosition=rockpos;
            //Invoke("removeMyself", 1f);
            rock.transform.localPosition=new Vector3(5.02f,0,2.7f);
   
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //void removeMyself(){
		//gameObject.SetActive(false);
	//}
}
