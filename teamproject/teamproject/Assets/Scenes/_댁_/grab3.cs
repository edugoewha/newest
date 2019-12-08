using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class grab3 : MonoBehaviour
{

    private AudioSource audio;
    public AudioClip jumpSound;

    public GameObject Chairword;
    public GameObject Duckword;
    public GameObject Monkeyword;
    public GameObject Milkword;
    public GameObject Penword;
    public GameObject Umbrellaword;

    public GameObject Chairobject;
    public GameObject Duckobject;
    public GameObject Monkeyobject;
    public GameObject Milkobject;
    public GameObject Penobject;
    public GameObject Umbrellaobject;

    public GameObject Board;

    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Plane4;
    public GameObject Plane5;
    public GameObject Plane6;

    public GameObject myHand;

    Vector3 ChairobjectPos;
    Vector3 DuckobjectPos;
    Vector3 MonkeyobjectPos;
    Vector3 MilkobjectPos;
    Vector3 PenobjectPos;
    Vector3 UmbrellaobjectPos;

    Vector3 ChairwordPos;
    Vector3 DuckwordPos;
    Vector3 MonkeywordPos;
    Vector3 MilkwordPos;
    Vector3 PenwordPos;
    Vector3 UmbrellawordPos;

    Camera cam;

    public float handPower;
    public static bool inHand1;
    public static bool inHand2;
    public static bool inHand3;
    public static bool inHand4;
    public static bool inHand5;
    public static bool inHand6;

    public static bool inHand11;
    public static bool inHand22;
    public static bool inHand33;
    public static bool inHand44;
    public static bool inHand55;
    public static bool inHand66;

    Ray ray;
    RaycastHit hit;

    public static Text[] newText;
    public static int count;



    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        newText = GetComponentsInChildren<Text>();
        
        count = 6;

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;

        Chairobject.SetActive(false);
        Duckobject.SetActive(false);
        Monkeyobject.SetActive(false);
        Milkobject.SetActive(false);
        Penobject.SetActive(false);
        Umbrellaobject.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {

        if (count == 0)
        {
            Invoke("DisableText", 1f);
            this.audio.Play();
            newText[0].text = "비를 맞는 원숭이를 도와주세요!";
            Destroy(Board);
            Destroy(Plane1);
            Destroy(Plane2);
            Destroy(Plane3);
            Destroy(Plane4);
            Destroy(Plane5);
            Destroy(Plane6);
            Chairobject.SetActive(true);
            Duckobject.SetActive(true);
            Monkeyobject.SetActive(true);
            Milkobject.SetActive(true);
            Penobject.SetActive(true);
            Umbrellaobject.SetActive(true);
            count--;

        } else if (count > 0)
         {
            newText[0].text = "물건을 집어서 맞는 단어를 누르세요";
          }


        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.tag == "Chairword")
                {
                    Chairword.transform.SetParent(myHand.transform);
                    Chairword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand1 = true;

                }

                if (hit.collider.tag == "Duckword")
                {
                    Duckword.transform.SetParent(myHand.transform);
                    Duckword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand2 = true;
                }

                if (hit.collider.tag == "Monkeyword")
                {
                    Monkeyword.transform.SetParent(myHand.transform);
                    Monkeyword.transform.localPosition = new Vector3(-1.4f, 1.0f, 0.5f);
                    inHand3 = true;
                }

                if (hit.collider.tag == "Milkword")
                {
                    Milkword.transform.SetParent(myHand.transform);
                    Milkword.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand4 = true;
                }

                if (hit.collider.tag == "Penword")
                {
                    Penword.transform.SetParent(myHand.transform);
                    Penword.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand5 = true;
                }

                if (hit.collider.tag == "Umbrellaword")
                {
                    Umbrellaword.transform.SetParent(myHand.transform);
                    Umbrellaword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand6 = true;
                }


                if (hit.collider.tag == "Chairobject")
                {
                    Chairobject.transform.SetParent(myHand.transform);
                    Chairobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand11 = true;

                }

                if (hit.collider.tag == "Duckobject")
                {
                    Duckobject.transform.SetParent(myHand.transform);
                    Duckobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand22 = true;
                }

                
                if (hit.collider.tag == "Monkeyobject")
                {
                    //Monkeyobject.transform.SetParent(myHand.transform);
                    //Monkeyobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    //inHand33 = true;
                }
                

                if (hit.collider.tag == "Milkobject")
                {
                    Milkobject.transform.SetParent(myHand.transform);
                    Milkobject.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand44 = true;
                }

                if (hit.collider.tag == "Penobject")
                {
                    Penobject.transform.SetParent(myHand.transform);
                    Penobject.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand55 = true;
                }

                if (hit.collider.tag == "Umbrellaobject")
                {
                    Umbrellaobject.transform.SetParent(myHand.transform);
                    Umbrellaobject.transform.localPosition = new Vector3(-0.8f, 0.8f, 0);
                    inHand66 = true;
                }

            }
        
         }

        /*
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.tag == "Chairobject")
                {
                    Chairobject.transform.SetParent(myHand.transform);
                    Chairobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand11 = true;

                }

                if (hit.collider.tag == "Duckobject")
                {
                    Duckobject.transform.SetParent(myHand.transform);
                    Duckobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand22 = true;
                }

                if (hit.collider.tag == "Monkeyobject")
                {
                    Monkeyobject.transform.SetParent(myHand.transform);
                    Monkeyobject.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand33 = true;
                }

                if (hit.collider.tag == "Milkobject")
                {
                    Milkobject.transform.SetParent(myHand.transform);
                    Milkobject.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand44 = true;
                }

                if (hit.collider.tag == "Penobject")
                {
                    Penobject.transform.SetParent(myHand.transform);
                    Penobject.transform.localPosition = new Vector3(0.8f, 2.0f, 0);
                    inHand55 = true;
                }

                if (hit.collider.tag == "Umbrellaobject")
                {
                    Umbrellaobject.transform.SetParent(myHand.transform);
                    Umbrellaobject.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand66 = true;
                }
            }
        }
        */

    }

    void DisableText()
    {
        newText[1].enabled = false;
    }

}