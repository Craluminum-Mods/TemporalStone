using Vintagestory.API.Common;

[assembly: ModInfo("Temporal Stone")]

namespace TemporalStone
{
    class Core : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);

            api.RegisterEntity("EntityTemporalStone", typeof(EntityTemporalStone));
            api.RegisterItemClass("ItemTemporalStone", typeof(ItemTemporalStone));

            api.World.Logger.Event("started 'Temporal Stone' mod");
        }
    }
}