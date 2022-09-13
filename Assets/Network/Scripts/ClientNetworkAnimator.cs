using Unity.Netcode.Components;
using UnityEngine;

namespace Network
{
    [AddComponentMenu("Netcode/" + nameof(ClientNetworkAnimator))]
    public class ClientNetworkAnimator : NetworkAnimator
    {
        protected override bool OnIsServerAuthoritative()
        {
            return false;
        }
    }
}
