using UnityEngine;

public class CursorControl : MonoBehaviour
{
    private bool isCursorLocked = true;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mouse'u ekranýn içine kilitle
        Cursor.visible = false; // Mouse'u gizle
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ESC tuþuna basýldýðýnda veya belirli bir koþulu saðladýðýnýzda mouse kilidini açabilirsiniz.
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

