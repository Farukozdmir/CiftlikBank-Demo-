using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inek : MonoBehaviour
{
    
    public Button inekbuton;
    public float a;
    public GameManager GM;
	
    void Start () {
        
		Button btn = inekbuton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        
        
	}


    private void Update() {
        
        
    }

	void TaskOnClick()
    {
        GM.inek_al();
                             
	}



    
}