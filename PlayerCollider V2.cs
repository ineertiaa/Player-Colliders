using UnityEngine;
using Photon.Pun;

// reworking this made me reflect on how STUPID i was
// do i have problems???? why was i disabling the gameobject
// (im a dumbass)

[RequireComponent(typeof(PhotonView))]

public class PlayerCollider : MonoBehaviourPun
{
    [Header("Script was madde by TV No need to give Credits :D")]
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
