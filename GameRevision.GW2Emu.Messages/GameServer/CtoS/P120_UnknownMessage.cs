/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.GameServer.CtoS
{
    public class P120_UnknownMessage : GenericTriggerableMessage
    {
        public byte Unknown0;
        public int Unknown1;
        public short Unknown2;
        public string Unknown3;
        public int Unknown4;
        public string Unknown5;
        public short Unknown6;
        public int Unknown7;
        public int Unknown8;
        public int Unknown9;
        public short Unknown10;
        public int Unknown11;
        public short Unknown12;
        public short Unknown13;
        public short Unknown14;
        public short Unknown15;
        public short Unknown16;
        public byte Unknown17;
        public UID Unknown18;
        public string Unknown19;
        
        public override ushort Header
        {
            get
            {
                return 120;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadByte();
            this.Unknown1 = deserializer.ReadVarint();
            this.Unknown2 = deserializer.ReadInt16();
            this.Unknown3 = deserializer.ReadUtf16String();
            this.Unknown4 = deserializer.ReadVarint();
            this.Unknown5 = deserializer.ReadUtf16String();
            this.Unknown6 = deserializer.ReadInt16();
            this.Unknown7 = deserializer.ReadVarint();
            this.Unknown8 = deserializer.ReadVarint();
            this.Unknown9 = deserializer.ReadVarint();
            this.Unknown10 = deserializer.ReadInt16();
            this.Unknown11 = deserializer.ReadVarint();
            this.Unknown12 = deserializer.ReadInt16();
            this.Unknown13 = deserializer.ReadInt16();
            this.Unknown14 = deserializer.ReadInt16();
            this.Unknown15 = deserializer.ReadInt16();
            this.Unknown16 = deserializer.ReadInt16();
            this.Unknown17 = deserializer.ReadByte();
            this.Unknown18 = deserializer.ReadUID();
            this.Unknown19 = deserializer.ReadUtf16String();
        }
    }
}
