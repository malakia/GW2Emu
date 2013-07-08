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

namespace GameRevision.GW2Emu.Messages.LoginServer.CtoS
{
    public class P03_UnknownMessage : GenericTriggerableMessage
    {
        public int Unknown0;
        public byte[] Unknown1;
        
        public override ushort Header
        {
            get
            {
                return 3;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadVarint();
            this.Unknown1 = new byte[16];
            for (int i = 0; i < this.Unknown1.Length; i++)
            {
                this.Unknown1[i] = deserializer.ReadByte();
            }
        }
    }
}
