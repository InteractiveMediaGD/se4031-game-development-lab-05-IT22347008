using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int gems, keys;

    public TMP_Text gemsText;
    public TMP_Text keysText;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
    }

    private void Start() => RefreshUI();

    public void AddGem() { gems++; RefreshUI(); }
    public void AddKey() { keys++; RefreshUI(); }

    public void RefreshUI()
    {
        if (gemsText) gemsText.text = $"Gems: {gems}";
        if (keysText) keysText.text = $"Keys: {keys}";
    }
}