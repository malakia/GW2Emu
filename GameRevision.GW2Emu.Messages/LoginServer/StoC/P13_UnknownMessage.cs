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

namespace GameRevision.GW2Emu.Messages.LoginServer.StoC
{
    public class P13_UnknownMessage : GenericMessage
    {
        public struct Struct0
        {
            public short Unknown1;
            public short Unknown2;
            public int Unknown3;
            public int Unknown4;
            public int Unknown5;
            
            public void Serialize(Serializer serializer)
            {
                serializer.Write(this.Unknown1);
                serializer.Write(this.Unknown2);
                serializer.WriteVarint(this.Unknown3);
                serializer.WriteVarint(this.Unknown4);
                serializer.WriteVarint(this.Unknown5);
            }
        }
        public Struct0[] Unknown6;
        
        public override ushort Header
        {
            get
            {
                return 13;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write((byte)Unknown6.Length);
            for (int i = 0; i < Unknown6.Length; i++)
            {
                Unknown6[i].Serialize(serializer);
            }
        }
    }
}
