using Unity.VisualScripting;
using UnityEngine;



public class diceeye : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool touchcheck = false;

    void OnTriggerStay(Collider col){
        touchcheck = true;
        
    }

    void OnTriggerExit(Collider col){
        touchcheck=false;
    }

}
