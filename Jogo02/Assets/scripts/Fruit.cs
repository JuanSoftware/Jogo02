using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private Rigidbody2D myRB;
    [SerializeField] private float startForce;
    public GameObject fruitSliced;
    private GameController gameController;
    void Start()
    {
        myRB = this.gameObject.GetComponent<Rigidbody2D> ();
        gameController = FindObjectOfType<GameController>();
        ApplyForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ApplyForce(){
        myRB.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }
    public Color32 ChangeSplashColor(GameObject GO){
        string cloneObjectName= GO.transform.name;
        Color32 defaultColor = new Color32(255,255,255,255);
        switch(cloneObjectName){
            case "Apple(Clone)":
            return gameController.appleColor;
            case "Orange(Clone)":
            return gameController.orangeColor;
            case "Coconout(Clone)":
            return gameController.coconutColor;
            case "Pear(Clone)":
            return gameController.pearColor;
            case "Pineapple(Clone)":
            return gameController.pineaplleColor;

        }
        return defaultColor;
    }
}
