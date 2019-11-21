using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Res_Send_Info : MonoBehaviour
{

    public GameObject []ShowObjs;
    public GameObject ShowBuilding;
    public bool IsShowBuilding = false;
    public bool IsRotate = false;
    public float degreesPerSec = 360f;
    public GameObject[] ShowSingle;

    // Start is called before the first frame update
    void Start()
    {

        foreach(var items in ShowObjs)
        {
            items.SetActive(false);
        }
        ShowBuilding.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ShowBuilding.transform.position.y <= 0.06f && IsShowBuilding == true)
            ShowBuilding.transform.position = new Vector3(ShowBuilding.transform.position.x, ShowBuilding.transform.position.y + 0.5f * Time.deltaTime, ShowBuilding.transform.position.z);




        if(IsRotate == true)
        {
            foreach (var items in ShowObjs)
            {
                items.transform.Rotate(0f, 0f, 90f*Time.deltaTime);
      

            }

        }


    }



    public void OnTriggerEnter(Collider other)
    {
        if(other.name== "ShowBuildingTag")
        {
            print("ShowBuildingTag");
            StartCoroutine(StartAnimationInf());

           
        }
    }


    IEnumerator StartAnimationInf()
    {
        yield return new WaitForSeconds(1f);
        ShowObjs[0].SetActive(true);

        yield return new WaitForSeconds(2f);
        ShowBuilding.SetActive(true);
        IsShowBuilding = true;

     

        yield return new WaitForSeconds(4f);
        foreach (var items in ShowObjs)
        {
            items.SetActive(true);
            IsRotate = true;
        }

        yield return new WaitForSeconds(2.5f);
        //resive sginal
        ShowSingle[0].SetActive(true);
        ShowSingle[1].SetActive(true);
        ShowSingle[2].SetActive(true);


        yield return new WaitForSeconds(3f);
        //Send signal
    }
}
