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

namespace GameRevision.GW2Emu.Messages.GameServer.StoC
{
    public class P025_UnknownMessage : GenericMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public Vector4 Unknown5;
        public int Unknown6;
        public Vector4 Unknown7;
        public byte Unknown8;
        public byte Unknown9;
        public byte Unknown10;
        
        public override ushort Header
        {
            get
            {
                return 25;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.WriteVarint(this.Unknown3);
            serializer.Write((byte)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                serializer.Write(Unknown4[i]);
            }
            serializer.WriteVector4(this.Unknown5);
            serializer.WriteVarint(this.Unknown6);
            serializer.WriteVector4(this.Unknown7);
            serializer.Write(this.Unknown8);
            serializer.Write(this.Unknown9);
            serializer.Write(this.Unknown10);
        }
    }
}
