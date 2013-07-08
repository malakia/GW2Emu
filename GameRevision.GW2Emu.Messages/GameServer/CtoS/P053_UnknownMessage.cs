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
    public class P053_UnknownMessage : GenericTriggerableMessage
    {
        public int Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        
        public override ushort Header
        {
            get
            {
                return 53;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.Unknown1 = deserializer.ReadVarint();
            this.Unknown2 = deserializer.ReadByte();
            this.Unknown3 = deserializer.ReadByte();
            this.Unknown4 = deserializer.ReadByte();
        }
    }
}
