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
    public class P014_UnknownMessage : GenericTriggerableMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public short Unknown5;
        public short Unknown6;
        
        public override ushort Header
        {
            get
            {
                return 14;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadInt16();
            this.Unknown1 = deserializer.ReadVarint();
            this.Unknown2 = deserializer.ReadByte();
            this.Unknown3 = deserializer.ReadVarint();
            byte unknown4Length = deserializer.ReadByte();
            if (unknown4Length > 81)
            {
                throw new InvalidDataException();
            }
            Unknown4 = new byte[unknown4Length];
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i] = deserializer.ReadByte();
            }
            this.Unknown5 = deserializer.ReadInt16();
            this.Unknown6 = deserializer.ReadInt16();
        }
    }
}
