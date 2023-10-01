using Unity.BossRoom.Gameplay.GameplayObjects.Character;

namespace Unity.BossRoom.Gameplay.GameplayObjects
{
    public interface IManaable
    {
        void ReceiveMana(ServerCharacter inflicter, int mana);
    }
}
