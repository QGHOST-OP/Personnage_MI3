using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionnaireClic : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] private GestionnairePeripherique gestionnairePeripherique;

    private Camera mainCamera;



    #endregion



    // Start is called before the first frame update
    void Start()
    {
        gestionnairePeripherique.clic.AddListener(ProduireClic);
        mainCamera = Camera.main;
    }



    // Update is called once per frame
    void Update()
    {

    }



    private void ProduireClic()
    {
        Vector2 milieuEcran = new Vector2(Screen.width / 2, Screen.height / 2);
        GameObject objetCollision;

        Ray ray = mainCamera.ScreenPointToRay(milieuEcran);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                objetCollision = hit.transform.gameObject;

                Debug.Log(objetCollision.name);


                if (hit.collider.gameObject.tag == "Cube")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }



}
