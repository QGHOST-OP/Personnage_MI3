using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnairePeripherique : MonoBehaviour
{
    [SerializeField] private Vector2 deplacement;

    private PeripheriqueEntree peripheriqueEntree;





    private void Awake()
    {
        peripheriqueEntree = new PeripheriqueEntree();

        peripheriqueEntree.JoueurAuSol.Deplacer.performed += LireMouvmentDeplacement;
        peripheriqueEntree.JoueurAuSol.Deplacer.canceled += LireMouvmentDeplacement;
    }



    private void OnEnable()
    {
        peripheriqueEntree.JoueurAuSol.Enable();
    }

    private void OnDisable()
    {
        peripheriqueEntree.JoueurAuSol.Disable();
    }


    private void LireMouvmentDeplacement(InputAction.CallbackContext context)
    {
        deplacement = context.ReadValue<Vector2>();
        Debug.Log("Moved");
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
