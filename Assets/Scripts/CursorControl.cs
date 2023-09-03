using UnityEngine;

public class CursorControl : MonoBehaviour
{
    private bool isCursorLocked = true;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mouse'u ekran�n i�ine kilitle
        Cursor.visible = false; // Mouse'u gizle
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ESC tu�una bas�ld���nda veya belirli bir ko�ulu sa�lad���n�zda mouse kilidini a�abilirsiniz.
            isCursorLocked = !isCursorLocked;
            if (isCursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}

