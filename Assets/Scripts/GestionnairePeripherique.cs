using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnairePeripherique : MonoBehaviour
{
    [SerializeField] private Vector2 deplacement;
    [SerializeField] private Vector2 regard;

    private PeripheriqueEntree peripheriqueEntree;





    private void Awake()
    {
        peripheriqueEntree = new PeripheriqueEntree();

        peripheriqueEntree.JoueurAuSol.Deplacer.performed += LireMouvmentDeplacement;
        peripheriqueEntree.JoueurAuSol.Deplacer.canceled += LireMouvmentDeplacement;

        peripheriqueEntree.JoueurAuSol.Regarder.performed += LireMouvmentRegard;
        peripheriqueEntree.JoueurAuSol.Regarder.canceled += LireMouvmentRegard;
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

    private void LireMouvmentRegard(InputAction.CallbackContext context)
    {
        regard = Vector2.ClampMagnitude(context.ReadValue<Vector2>(), 1);
        Debug.Log("Regarde");
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
