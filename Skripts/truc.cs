using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class truc : MonoBehaviour
{
    
    public Button trucbuton;
    public GameManager GM;
	
    void Start () {
        
		Button btn = trucbuton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
        
	}


    private void Update() {
        
        
    }

	void TaskOnClick()
    {
        GM.truc_al();
                             
	}



    
}