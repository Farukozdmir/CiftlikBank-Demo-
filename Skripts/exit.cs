using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour
{
    
    public Button tavukbuton;
    public float a;
    public GameManager GM;
	
    void Start () {
        
		Button btn = tavukbuton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
        
	}


    private void Update() {
        
        
    }

	void TaskOnClick()
    {
        Application.Quit();
                             
	}



    
}