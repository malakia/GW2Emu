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
    public class P27_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public struct Struct1
        {
            public int Unknown2;
            public int Unknown3;
            
            public void Serialize(Serializer serializer)
            {
                serializer.WriteVarint(this.Unknown2);
                serializer.WriteVarint(this.Unknown3);
            }
        }
        public Struct1[] Unknown4;
        
        public override ushort Header
        {
            get
            {
                return 27;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                Unknown4[i].Serialize(serializer);
            }
        }
    }
}
