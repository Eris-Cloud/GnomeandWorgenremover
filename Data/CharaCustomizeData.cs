using Dalamud.Game.ClientState.Objects.Enums;
using System.Runtime.InteropServices;

namespace PotatoFamine2
{
    [StructLayout((LayoutKind.Explicit))]
    public struct CharaCustomizeData {
        [FieldOffset(0)] public Race Race;
        [FieldOffset(1)] public byte Gender;
        [FieldOffset(2)] public byte ModelType;
        [FieldOffset(3)] public byte Tribe;
        [FieldOffset(4)] public byte FaceType;
        [FieldOffset(5)] public byte HairStyle;
        [FieldOffset(6)] public byte LipColor;
    }
}
