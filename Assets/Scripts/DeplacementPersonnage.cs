using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementPersonnage : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] private GestionnairePeripherique gestionnairePeripherique;
    [SerializeField] CharacterController characterController;
    
    [Header("Parametre Personnage")]
    [SerializeField] private float vitessePersonnage = 2f;
    [SerializeField] private float vitesseSprintPersonnage = 4f;
    [SerializeField] private float hauteurSaut;

    private float gravity = -9.81f;

    private Vector3 velocity;

    [Header("Verification Collisions")]
    [SerializeField] private Transform verifToucheSol;
    [SerializeField] private LayerMask layerSol;
    private float distanceAuSol = 0.2f;
    private bool toucheSol;

    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        gestionnairePeripherique.sauter.AddListener(Saut);
    }

    void Saut()
    {
        if (toucheSol)
        {
            velocity.y = Mathf.Sqrt(hauteurSaut * -2f * gravity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        toucheSol = Physics.CheckSphere(verifToucheSol.position, distanceAuSol, layerSol);

        Vector3 move = new Vector3(gestionnairePeripherique.deplacementX, 0, gestionnairePeripherique.deplacementZ);

        if (gestionnairePeripherique.sprint) vitessePersonnage = vitesseSprintPersonnage;

        characterController.Move(move * vitessePersonnage * Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

    }
}
