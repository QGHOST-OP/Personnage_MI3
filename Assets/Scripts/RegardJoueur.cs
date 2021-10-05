using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegardJoueur : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private GestionnairePeripherique gestionnairePeripherique;

    [SerializeField] private Transform personnage;

    private float xRotation = 0f;

    [SerializeField] private float vitesseCamVertical = 100f;
    [SerializeField] private float vitesseCamHorizontale = 100f;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = gestionnairePeripherique.regardHorizontale * Time.deltaTime * vitesseCamHorizontale;
        float mouseY = gestionnairePeripherique.regardVertical * Time.deltaTime * vitesseCamVertical;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 50f);


        transform.localRotation = Quaternion.Euler(xRotation ,0f ,0f) ;

        personnage.Rotate(Vector3.up * mouseX);
    }
}
