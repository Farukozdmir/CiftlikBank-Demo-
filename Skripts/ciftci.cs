using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ciftci : MonoBehaviour
{
    
    public Button yourButton;
    public float a;
    public GameManager GM;
	
    void Start () 
    {
        
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);      
	}


    private void Update() {
        
        
    }

	void TaskOnClick(){
		
                  
        a = a + 1;
        GM.ciftci_al();
        
        
        
        
	}



    
}

   
        
    

