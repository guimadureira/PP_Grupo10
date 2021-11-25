using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    private int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            if(cont==0)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cont =1;
            }
            else if(cont==1)
            {
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(true);
                cam4.SetActive(false);
                cont =2;
            }
            else if(cont==2)
            {
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(true);
                cont =3;
            }
            else
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                cam3.SetActive(false);
                cam4.SetActive(false);
                cont =0;
            }
        }
    }
}
