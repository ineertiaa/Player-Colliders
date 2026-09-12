using UnityEngine;
using Photon.Pun;

[RequireComponent(typeof(PhotonView))]

public class PlayerCollider : MonoBehaviourPun
{
    [Header("Script was madde by Inertia No need to give Credits")]
    private Collider col;

    private void Start()
    {
        col = GetComponent<Collider>();
    }

    void Update()
    {
        if (photonView.IsMine)
        {
            col.enabled = false;
        }
        else
        {
            col.enabled = true;
        }
    }
}
