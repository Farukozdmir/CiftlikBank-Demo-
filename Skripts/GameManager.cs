using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basla;
    public float gold;
    public float ciftci;
    public Text yetersiz;
    public Text yazi;
    public Text cifci;
    
    public float tavuk;
    public Text tavukyazi;
    public GameObject inek;

    public GameObject sheepopen;
    public float sheep;
    public Text sheeptext;

    public float cow;
    public Text cowtext;
    public GameObject trucobj;

    public float truc;
    public Text tructext;

    void Start()
    {
        InvokeRepeating ("gold_arttir", 1, 1);
        gold = 0;
        ciftci = 1;
        tavuk = 0;
    }

    // Update is called once per frame
    void Update()
    {

        yazi.text = "GOLD = "+ gold;

        cifci.text = ("Bir cifci (10 gold) = 1g/s \n"+ ciftci + " ciftcin var = "+ ciftci +" gold/s"); 
        tavukyazi.text = ("Bir tavuk (100 gold) = 12g/s \n"+ tavuk + " tavugun var = "+ (tavuk*12) +" gold/s"); 
        sheeptext.text = ("Bir koyun (1500 gold) = 200g/s \n"+ sheep + " koyunun var = "+ (sheep*200) +" gold/s");  
        cowtext.text = ("Bir inek (20000 gold) = 2500g/s \n"+ cow + " inegin var = "+ (cow*2500) +" gold/s"); 
        tructext.text = ("Bir traktor (250000 gold) = 35000g/s \n"+ truc + " inegin var = "+ (truc*35000) +" gold/s");     
    
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    
    }

    void gold_arttir()
    {
        gold = ciftci + (tavuk*12) + (sheep*200) + (cow*2500) + (truc*35000) + gold;
        
    }

    public void ciftci_al()
    {
        if(gold < 10)
            {
                yetersiz.text = "Bakiye yetersiz !!!";
            }
        
        else
        {
            gold = gold - 10;
            ciftci = ciftci + 1;
            yetersiz.text = "";
            basla.SetActive(false);
        }
    }

     public void tavuk_al()
    {
        if(gold < 100)
            {
                yetersiz.text = "Bakiye yetersiz !!!";
            }
        
        else
        {
            gold = gold - 100;
            tavuk = tavuk + 1;
            yetersiz.text = "";
            sheepopen.SetActive(true);
        }
    }

     public void sheep_al()
    {
        if(gold < 1500)
            {
                yetersiz.text = "Bakiye yetersiz !!!";
            }
        
        else
        {
            gold = gold - 1500;
            sheep = sheep + 1;
            yetersiz.text = "";
            inek.SetActive(true);
        }
    }

    public void inek_al()
    {
        if(gold < 20000)
            {
                yetersiz.text = "Bakiye yetersiz !!!";
            }
        
        else
        {
            gold = gold - 20000;
            cow = cow + 1;
            yetersiz.text = "";
            trucobj.SetActive(true);
        }
    }

    public void truc_al()
    {
        if(gold < 250000)
            {
                yetersiz.text = "Bakiye yetersiz !!!";
            }
        
        else
        {
            gold = gold - 250000;
            truc = truc + 1;
            yetersiz.text = "";
            trucobj.SetActive(true);
        }
    }
}
