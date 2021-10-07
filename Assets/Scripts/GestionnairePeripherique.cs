using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GestionnairePeripherique : MonoBehaviour
{
    #region VARIABLES
    private Vector2 deplacement;
    private Vector2 regard;
    public bool sprint;
    private PeripheriqueEntree peripheriqueEntree;


    public float deplacementX;
    public float deplacementZ;

    public float regardVertical;
    public float regardHorizontale;

    public UnityEvent sauter;

    public UnityEvent clic;


    #endregion

    #region AWAKE
    private void Awake()
    {
        peripheriqueEntree = new PeripheriqueEntree();

        peripheriqueEntree.JoueurAuSol.Deplacer.performed += LireMouvementDeplacement;
        peripheriqueEntree.JoueurAuSol.Deplacer.canceled += LireMouvementDeplacement;

        peripheriqueEntree.JoueurAuSol.Regarder.performed += LireMouvementRegard;
        peripheriqueEntree.JoueurAuSol.Regarder.canceled += LireMouvementRegard;

        peripheriqueEntree.JoueurAuSol.Sprint.performed += LireSprint;
        peripheriqueEntree.JoueurAuSol.Sprint.canceled += LireSprint;

        peripheriqueEntree.JoueurAuSol.Sauter.started += LireSaut;

        peripheriqueEntree.JoueurAuSol.Cliquer.started += LireClic;
    }

    private void OnEnable()
    {
        peripheriqueEntree.JoueurAuSol.Enable();
    }

    private void OnDisable()
    {
        peripheriqueEntree.JoueurAuSol.Disable();
    }
    #endregion

    private void LireSaut(InputAction.CallbackContext context) //Saut
    {
        sauter.Invoke();
    }

    private void LireSprint(InputAction.CallbackContext context) //Sprinting
    {
        Debug.Log(context.ReadValue<float>());
        sprint = true;


    }

    private void LireMouvementDeplacement(InputAction.CallbackContext context) //Deplacement
    {
        deplacement = context.ReadValue<Vector2>();

        deplacementX = deplacement.x;
        deplacementZ = deplacement.y;


        Debug.Log("Moved");
    }

    private void LireMouvementRegard(InputAction.CallbackContext context) //Regard
    {
        regard = Vector2.ClampMagnitude(context.ReadValue<Vector2>(), 1);

        regardHorizontale = regard.x;
        regardVertical = regard.y;

        Debug.Log("Regarde");
    }


    private void LireClic(InputAction.CallbackContext context)
    {
        clic.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    #region Methodes externes
     #endregion
}

