using LogicAPI.Server;

namespace FoxFireFive_BasicLogicWorldMod.Server
{
    public class Loader : ServerMod
    {
        protected override void Initialize()
        {
            this.Logger.Info("Basic Logic World mod has been initialized!");
            // useful for extra, per-mod setup stuff (this is called right after the mod was loaded)
        }
    }
}
