using Vintagestory.API.Common.Entities;
using Vintagestory.API.Config;
using Vintagestory.GameContent;

namespace TemporalStone;

public class EntityTemporalStone : EntityProjectile
{
    public override void OnCollided()
    {
        EntityPos pos = SidedPos;
        FiredBy?.TeleportTo(pos);
        Die();
    }

    public override void OnCollideWithLiquid()
    {
        EntityPos pos = SidedPos;
        FiredBy?.TeleportTo(pos);
        Die();
    }
}