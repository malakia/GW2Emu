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
    public class P199_UnknownMessage : GenericTriggerableMessage
    {
        public UID Unknown0;
        public int Unknown1;
        public int[] Unknown2;
        public string Unknown3;
        public string Unknown4;
        public string Unknown5;
        public byte Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public short Unknown10;
        public byte Unknown11;
        public byte Unknown12;
        
        public override ushort Header
        {
            get
            {
                return 199;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadUID();
            this.Unknown1 = deserializer.ReadVarint();
            byte unknown2Length = deserializer.ReadByte();
            if (unknown2Length > 161)
            {
                throw new InvalidDataException();
            }
            Unknown2 = new int[unknown2Length];
            for (int i = 0; i < Unknown2.Length; i++)
            {
                Unknown2[i] = deserializer.ReadVarint();
            }
            this.Unknown3 = deserializer.ReadUtf16String();
            this.Unknown4 = deserializer.ReadUtf16String();
            this.Unknown5 = deserializer.ReadUtf16String();
            this.Unknown6 = deserializer.ReadByte();
            this.Unknown7 = deserializer.ReadByte();
            this.Unknown8 = deserializer.ReadByte();
            this.Unknown9 = deserializer.ReadByte();
            this.Unknown10 = deserializer.ReadInt16();
            this.Unknown11 = deserializer.ReadByte();
            this.Unknown12 = deserializer.ReadByte();
        }
    }
}
