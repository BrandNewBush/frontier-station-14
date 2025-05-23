namespace Content.Server._NF.Salvage;

/// <summary>
///     This component is attached to grids when a salvage mob is
///     spawned on them.
///     This attachment is done by SalvageMobRestrictionsSystem.
///     *Simply put, when this component is removed, the mobs die.*
///     *This applies even if the mobs are off-grid at the time.*
/// </summary>
[RegisterComponent]
public sealed partial class SalvageMobRestrictionsGridComponent : Component
{
    [ViewVariables(VVAccess.ReadOnly)]
    [DataField("mobsToKill")]
    public List<EntityUid> MobsToKill = new();
}
