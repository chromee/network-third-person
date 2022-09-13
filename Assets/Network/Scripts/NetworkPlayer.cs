using Cinemachine;
using StarterAssets;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Network.Scripts
{
    public class NetworkPlayer : NetworkBehaviour
    {
        [SerializeField] private ThirdPersonController _thirdPersonController;
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private Transform _cameraRoot;

        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();

            _thirdPersonController.enabled = IsLocalPlayer;
            _playerInput.enabled = IsLocalPlayer;

            if (IsLocalPlayer)
            {
                var vCamera = GameObject.Find("PlayerFollowCamera").GetComponent<CinemachineVirtualCamera>();
                vCamera.Follow = _cameraRoot;
            }
        }
    }
}
