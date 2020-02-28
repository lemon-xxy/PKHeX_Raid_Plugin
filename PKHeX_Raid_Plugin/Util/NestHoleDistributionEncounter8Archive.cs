// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace PKHeX_Raid_Plugin
{

    using global::System;
    using global::FlatBuffers;

    public struct NestHoleDistributionEncounter8Archive : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
        public static NestHoleDistributionEncounter8Archive GetRootAsNestHoleDistributionEncounter8Archive(ByteBuffer _bb) { return GetRootAsNestHoleDistributionEncounter8Archive(_bb, new NestHoleDistributionEncounter8Archive()); }
        public static NestHoleDistributionEncounter8Archive GetRootAsNestHoleDistributionEncounter8Archive(ByteBuffer _bb, NestHoleDistributionEncounter8Archive obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
        public NestHoleDistributionEncounter8Archive __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table? Tables(int j) { int o = __p.__offset(4); return o != 0 ? (PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table?)(new PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
        public int TablesLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Archive> CreateNestHoleDistributionEncounter8Archive(FlatBufferBuilder builder,
            VectorOffset TablesOffset = default(VectorOffset))
        {
            builder.StartTable(1);
            NestHoleDistributionEncounter8Archive.AddTables(builder, TablesOffset);
            return NestHoleDistributionEncounter8Archive.EndNestHoleDistributionEncounter8Archive(builder);
        }

        public static void StartNestHoleDistributionEncounter8Archive(FlatBufferBuilder builder) { builder.StartTable(1); }
        public static void AddTables(FlatBufferBuilder builder, VectorOffset TablesOffset) { builder.AddOffset(0, TablesOffset.Value, 0); }
        public static VectorOffset CreateTablesVector(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
        public static VectorOffset CreateTablesVectorBlock(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
        public static void StartTablesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Archive> EndNestHoleDistributionEncounter8Archive(FlatBufferBuilder builder)
        {
            int o = builder.EndTable();
            return new Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Archive>(o);
        }
        public static void FinishNestHoleDistributionEncounter8ArchiveBuffer(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Archive> offset) { builder.Finish(offset.Value); }
        public static void FinishSizePrefixedNestHoleDistributionEncounter8ArchiveBuffer(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Archive> offset) { builder.FinishSizePrefixed(offset.Value); }
    };

    public struct NestHoleDistributionEncounter8Table : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
        public static NestHoleDistributionEncounter8Table GetRootAsNestHoleDistributionEncounter8Table(ByteBuffer _bb) { return GetRootAsNestHoleDistributionEncounter8Table(_bb, new NestHoleDistributionEncounter8Table()); }
        public static NestHoleDistributionEncounter8Table GetRootAsNestHoleDistributionEncounter8Table(ByteBuffer _bb, NestHoleDistributionEncounter8Table obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
        public NestHoleDistributionEncounter8Table __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public ulong TableID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
        public uint GameVersion { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public sbyte Field02 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte Field03 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public PKHeX_Raid_Plugin.NestHoleDistributionEncounter8? Entries(int j) { int o = __p.__offset(12); return o != 0 ? (PKHeX_Raid_Plugin.NestHoleDistributionEncounter8?)(new PKHeX_Raid_Plugin.NestHoleDistributionEncounter8()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
        public int EntriesLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table> CreateNestHoleDistributionEncounter8Table(FlatBufferBuilder builder,
            ulong TableID = 0,
            uint GameVersion = 0,
            sbyte Field_02 = 0,
            sbyte Field_03 = 0,
            VectorOffset EntriesOffset = default(VectorOffset))
        {
            builder.StartTable(5);
            NestHoleDistributionEncounter8Table.AddTableID(builder, TableID);
            NestHoleDistributionEncounter8Table.AddEntries(builder, EntriesOffset);
            NestHoleDistributionEncounter8Table.AddGameVersion(builder, GameVersion);
            NestHoleDistributionEncounter8Table.AddField03(builder, Field_03);
            NestHoleDistributionEncounter8Table.AddField02(builder, Field_02);
            return NestHoleDistributionEncounter8Table.EndNestHoleDistributionEncounter8Table(builder);
        }

        public static void StartNestHoleDistributionEncounter8Table(FlatBufferBuilder builder) { builder.StartTable(5); }
        public static void AddTableID(FlatBufferBuilder builder, ulong TableID) { builder.AddUlong(0, TableID, 0); }
        public static void AddGameVersion(FlatBufferBuilder builder, uint GameVersion) { builder.AddUint(1, GameVersion, 0); }
        public static void AddField02(FlatBufferBuilder builder, sbyte Field02) { builder.AddSbyte(2, Field02, 0); }
        public static void AddField03(FlatBufferBuilder builder, sbyte Field03) { builder.AddSbyte(3, Field03, 0); }
        public static void AddEntries(FlatBufferBuilder builder, VectorOffset EntriesOffset) { builder.AddOffset(4, EntriesOffset.Value, 0); }
        public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
        public static VectorOffset CreateEntriesVectorBlock(FlatBufferBuilder builder, Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
        public static void StartEntriesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table> EndNestHoleDistributionEncounter8Table(FlatBufferBuilder builder)
        {
            int o = builder.EndTable();
            return new Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8Table>(o);
        }
    };

    public struct NestHoleDistributionEncounter8 : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_11_1(); }
        public static NestHoleDistributionEncounter8 GetRootAsNestHoleDistributionEncounter8(ByteBuffer _bb) { return GetRootAsNestHoleDistributionEncounter8(_bb, new NestHoleDistributionEncounter8()); }
        public static NestHoleDistributionEncounter8 GetRootAsNestHoleDistributionEncounter8(ByteBuffer _bb, NestHoleDistributionEncounter8 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
        public NestHoleDistributionEncounter8 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public uint EntryIndex { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Species { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint AltForm { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Level { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public ushort DynamaxLevel { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
        public uint Field05 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field06 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field07 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field08 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field09 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field0A { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public sbyte Ability { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public bool IsGigantamax { get { int o = __p.__offset(28); return o != 0 ? 0 != __p.bb.Get(o + __p.bb_pos) : (bool)false; } }
        public ulong DropTableID { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
        public ulong BonusTableID { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
        public uint Probabilities(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
        public int ProbabilitiesLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetProbabilitiesBytes() { return __p.__vector_as_span<uint>(34, 4); }
#else
        public ArraySegment<byte>? GetProbabilitiesBytes() { return __p.__vector_as_arraysegment(34); }
#endif
        public uint[] GetProbabilitiesArray() { return __p.__vector_as_array<uint>(34); }
        public sbyte Gender { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte FlawlessIVs { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte ShinyForced { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte Field13 { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte Field14 { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public sbyte Nature { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetSbyte(o + __p.bb_pos) : (sbyte)0; } }
        public uint Field16 { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Move0 { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Move1 { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Move2 { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Move3 { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public float DynamaxBoost { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
        public uint Field1C { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field1D { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field1E { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field1F { get { int o = __p.__offset(66); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field20 { get { int o = __p.__offset(68); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field21 { get { int o = __p.__offset(70); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field22 { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field23 { get { int o = __p.__offset(74); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
        public uint Field24 { get { int o = __p.__offset(76); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8> CreateNestHoleDistributionEncounter8(FlatBufferBuilder builder,
            uint EntryIndex = 0,
            uint Species = 0,
            uint AltForm = 0,
            uint Level = 0,
            ushort DynamaxLevel = 0,
            uint Field_05 = 0,
            uint Field_06 = 0,
            uint Field_07 = 0,
            uint Field_08 = 0,
            uint Field_09 = 0,
            uint Field_0A = 0,
            sbyte Ability = 0,
            bool IsGigantamax = false,
            ulong DropTableID = 0,
            ulong BonusTableID = 0,
            VectorOffset ProbabilitiesOffset = default(VectorOffset),
            sbyte Gender = 0,
            sbyte FlawlessIVs = 0,
            sbyte ShinyForced = 0,
            sbyte Field_13 = 0,
            sbyte Field_14 = 0,
            sbyte Nature = 0,
            uint Field_16 = 0,
            uint Move0 = 0,
            uint Move1 = 0,
            uint Move2 = 0,
            uint Move3 = 0,
            float DynamaxBoost = 0.0f,
            uint Field_1C = 0,
            uint Field_1D = 0,
            uint Field_1E = 0,
            uint Field_1F = 0,
            uint Field_20 = 0,
            uint Field_21 = 0,
            uint Field_22 = 0,
            uint Field_23 = 0,
            uint Field_24 = 0)
        {
            builder.StartTable(37);
            NestHoleDistributionEncounter8.AddBonusTableID(builder, BonusTableID);
            NestHoleDistributionEncounter8.AddDropTableID(builder, DropTableID);
            NestHoleDistributionEncounter8.AddField24(builder, Field_24);
            NestHoleDistributionEncounter8.AddField23(builder, Field_23);
            NestHoleDistributionEncounter8.AddField22(builder, Field_22);
            NestHoleDistributionEncounter8.AddField21(builder, Field_21);
            NestHoleDistributionEncounter8.AddField20(builder, Field_20);
            NestHoleDistributionEncounter8.AddField1F(builder, Field_1F);
            NestHoleDistributionEncounter8.AddField1E(builder, Field_1E);
            NestHoleDistributionEncounter8.AddField1D(builder, Field_1D);
            NestHoleDistributionEncounter8.AddField1C(builder, Field_1C);
            NestHoleDistributionEncounter8.AddDynamaxBoost(builder, DynamaxBoost);
            NestHoleDistributionEncounter8.AddMove3(builder, Move3);
            NestHoleDistributionEncounter8.AddMove2(builder, Move2);
            NestHoleDistributionEncounter8.AddMove1(builder, Move1);
            NestHoleDistributionEncounter8.AddMove0(builder, Move0);
            NestHoleDistributionEncounter8.AddField16(builder, Field_16);
            NestHoleDistributionEncounter8.AddProbabilities(builder, ProbabilitiesOffset);
            NestHoleDistributionEncounter8.AddField0A(builder, Field_0A);
            NestHoleDistributionEncounter8.AddField09(builder, Field_09);
            NestHoleDistributionEncounter8.AddField08(builder, Field_08);
            NestHoleDistributionEncounter8.AddField07(builder, Field_07);
            NestHoleDistributionEncounter8.AddField06(builder, Field_06);
            NestHoleDistributionEncounter8.AddField05(builder, Field_05);
            NestHoleDistributionEncounter8.AddLevel(builder, Level);
            NestHoleDistributionEncounter8.AddAltForm(builder, AltForm);
            NestHoleDistributionEncounter8.AddSpecies(builder, Species);
            NestHoleDistributionEncounter8.AddEntryIndex(builder, EntryIndex);
            NestHoleDistributionEncounter8.AddDynamaxLevel(builder, DynamaxLevel);
            NestHoleDistributionEncounter8.AddNature(builder, Nature);
            NestHoleDistributionEncounter8.AddField14(builder, Field_14);
            NestHoleDistributionEncounter8.AddField13(builder, Field_13);
            NestHoleDistributionEncounter8.AddShinyForced(builder, ShinyForced);
            NestHoleDistributionEncounter8.AddFlawlessIVs(builder, FlawlessIVs);
            NestHoleDistributionEncounter8.AddGender(builder, Gender);
            NestHoleDistributionEncounter8.AddIsGigantamax(builder, IsGigantamax);
            NestHoleDistributionEncounter8.AddAbility(builder, Ability);
            return NestHoleDistributionEncounter8.EndNestHoleDistributionEncounter8(builder);
        }

        public static void StartNestHoleDistributionEncounter8(FlatBufferBuilder builder) { builder.StartTable(37); }
        public static void AddEntryIndex(FlatBufferBuilder builder, uint EntryIndex) { builder.AddUint(0, EntryIndex, 0); }
        public static void AddSpecies(FlatBufferBuilder builder, uint Species) { builder.AddUint(1, Species, 0); }
        public static void AddAltForm(FlatBufferBuilder builder, uint AltForm) { builder.AddUint(2, AltForm, 0); }
        public static void AddLevel(FlatBufferBuilder builder, uint Level) { builder.AddUint(3, Level, 0); }
        public static void AddDynamaxLevel(FlatBufferBuilder builder, ushort DynamaxLevel) { builder.AddUshort(4, DynamaxLevel, 0); }
        public static void AddField05(FlatBufferBuilder builder, uint Field05) { builder.AddUint(5, Field05, 0); }
        public static void AddField06(FlatBufferBuilder builder, uint Field06) { builder.AddUint(6, Field06, 0); }
        public static void AddField07(FlatBufferBuilder builder, uint Field07) { builder.AddUint(7, Field07, 0); }
        public static void AddField08(FlatBufferBuilder builder, uint Field08) { builder.AddUint(8, Field08, 0); }
        public static void AddField09(FlatBufferBuilder builder, uint Field09) { builder.AddUint(9, Field09, 0); }
        public static void AddField0A(FlatBufferBuilder builder, uint Field0A) { builder.AddUint(10, Field0A, 0); }
        public static void AddAbility(FlatBufferBuilder builder, sbyte Ability) { builder.AddSbyte(11, Ability, 0); }
        public static void AddIsGigantamax(FlatBufferBuilder builder, bool IsGigantamax) { builder.AddBool(12, IsGigantamax, false); }
        public static void AddDropTableID(FlatBufferBuilder builder, ulong DropTableID) { builder.AddUlong(13, DropTableID, 0); }
        public static void AddBonusTableID(FlatBufferBuilder builder, ulong BonusTableID) { builder.AddUlong(14, BonusTableID, 0); }
        public static void AddProbabilities(FlatBufferBuilder builder, VectorOffset ProbabilitiesOffset) { builder.AddOffset(15, ProbabilitiesOffset.Value, 0); }
        public static VectorOffset CreateProbabilitiesVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
        public static VectorOffset CreateProbabilitiesVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
        public static void StartProbabilitiesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
        public static void AddGender(FlatBufferBuilder builder, sbyte Gender) { builder.AddSbyte(16, Gender, 0); }
        public static void AddFlawlessIVs(FlatBufferBuilder builder, sbyte FlawlessIVs) { builder.AddSbyte(17, FlawlessIVs, 0); }
        public static void AddShinyForced(FlatBufferBuilder builder, sbyte ShinyForced) { builder.AddSbyte(18, ShinyForced, 0); }
        public static void AddField13(FlatBufferBuilder builder, sbyte Field13) { builder.AddSbyte(19, Field13, 0); }
        public static void AddField14(FlatBufferBuilder builder, sbyte Field14) { builder.AddSbyte(20, Field14, 0); }
        public static void AddNature(FlatBufferBuilder builder, sbyte Nature) { builder.AddSbyte(21, Nature, 0); }
        public static void AddField16(FlatBufferBuilder builder, uint Field16) { builder.AddUint(22, Field16, 0); }
        public static void AddMove0(FlatBufferBuilder builder, uint Move0) { builder.AddUint(23, Move0, 0); }
        public static void AddMove1(FlatBufferBuilder builder, uint Move1) { builder.AddUint(24, Move1, 0); }
        public static void AddMove2(FlatBufferBuilder builder, uint Move2) { builder.AddUint(25, Move2, 0); }
        public static void AddMove3(FlatBufferBuilder builder, uint Move3) { builder.AddUint(26, Move3, 0); }
        public static void AddDynamaxBoost(FlatBufferBuilder builder, float DynamaxBoost) { builder.AddFloat(27, DynamaxBoost, 0.0f); }
        public static void AddField1C(FlatBufferBuilder builder, uint Field1C) { builder.AddUint(28, Field1C, 0); }
        public static void AddField1D(FlatBufferBuilder builder, uint Field1D) { builder.AddUint(29, Field1D, 0); }
        public static void AddField1E(FlatBufferBuilder builder, uint Field1E) { builder.AddUint(30, Field1E, 0); }
        public static void AddField1F(FlatBufferBuilder builder, uint Field1F) { builder.AddUint(31, Field1F, 0); }
        public static void AddField20(FlatBufferBuilder builder, uint Field20) { builder.AddUint(32, Field20, 0); }
        public static void AddField21(FlatBufferBuilder builder, uint Field21) { builder.AddUint(33, Field21, 0); }
        public static void AddField22(FlatBufferBuilder builder, uint Field22) { builder.AddUint(34, Field22, 0); }
        public static void AddField23(FlatBufferBuilder builder, uint Field23) { builder.AddUint(35, Field23, 0); }
        public static void AddField24(FlatBufferBuilder builder, uint Field24) { builder.AddUint(36, Field24, 0); }
        public static Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8> EndNestHoleDistributionEncounter8(FlatBufferBuilder builder)
        {
            int o = builder.EndTable();
            return new Offset<PKHeX_Raid_Plugin.NestHoleDistributionEncounter8>(o);
        }
    };


}
