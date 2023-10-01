using System;
using UnityEngine;
using Unity.BossRoom.Gameplay.GameplayObjects.Character;

namespace Unity.BossRoom.Gameplay.GameplayObjects
{
    public class ManaReceiver : MonoBehaviour, IManaable
    {
        public event Action<ServerCharacter, int> ManaReceived;

        public void ReceiveMana(ServerCharacter inflicter, int mana)
        {
            ManaReceived?.Invoke(inflicter, mana);
        }
    }
}
