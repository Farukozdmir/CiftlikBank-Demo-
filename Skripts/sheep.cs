using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sheep : MonoBehaviour
{
    
    public Button sheepbuton;
    public float a;
    public GameManager GM;
	
    void Start () {
        
		Button btn = sheepbuton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
        
	}


    private void Update() {
        
        
    }

	void TaskOnClick()
    {
        GM.sheep_al();
                             
	}



    
}