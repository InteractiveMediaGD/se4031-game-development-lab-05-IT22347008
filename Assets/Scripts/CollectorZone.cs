using UnityEngine;

public class CollectorZone : MonoBehaviour
{
    public string collectableTag = "Collectable";

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(collectableTag))
        {
            return;
        }

        var item = other.GetComponent<CollectableItem>();
        if (item != null && GameManager.Instance != null)
        {
            if (item.type == CollectableType.Gem) GameManager.Instance.AddGem();
            if (item.type == CollectableType.Key) GameManager.Instance.AddKey();
        }

        other.gameObject.SetActive(false);
    }
}
