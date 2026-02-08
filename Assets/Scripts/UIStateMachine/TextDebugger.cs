using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDebugger : MonoBehaviour
{
    public static TextDebugger instance;
    [SerializeField] TextMeshProUGUI textMesh;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    public void DebugLog(string msg)
    {
        textMesh.text += "\n"+msg;
    }
    public void ClearAll()
    {
        textMesh.text = "";
    }
}
