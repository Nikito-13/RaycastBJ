using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class raycast : MonoBehaviour

{
   public static bool atingiu = false;
    void Update()

    {

        if (Input.GetMouseButtonDown(0)) // Verifique se o botão esquerdo do mouse foi pressionado

        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;




            if (Physics.Raycast(ray, out hit))

            {

                Debug.Log("Hit Something" + hit.collider.gameObject.name); // Exibe uma mensagem no console

                if (hit.collider.gameObject.tag == "Inimigo") // Verifique se o Raycast atingiu o objeto atual

                {

                    Destroy(hit.collider.gameObject); // Destrua o objeto
                    atingiu = true;
                }

            }

        }



        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f))

        {

            Debug.Log("Hit Something");

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.green);

        }

        else

        {

            Debug.Log("Hit Nothing");

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.red);

        }

    }

}
