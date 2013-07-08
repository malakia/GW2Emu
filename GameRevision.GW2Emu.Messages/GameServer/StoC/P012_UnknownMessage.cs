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
    public class P012_UnknownMessage : GenericMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public int Unknown3;
        public byte[] Unknown4;
        public byte Unknown5;
        public int Unknown6;
        public byte Unknown7;
        public byte Unknown8;
        public WorldPosition Unknown9;
        public short Unknown10;
        public short Unknown11;
        public float[] Unknown12;
        public float Unknown13;
        
        public override ushort Header
        {
            get
            {
                return 12;
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
            serializer.Write(this.Unknown5);
            serializer.WriteVarint(this.Unknown6);
            serializer.Write(this.Unknown7);
            serializer.Write(this.Unknown8);
            serializer.WriteWorldPosition(this.Unknown9);
            serializer.Write(this.Unknown10);
            serializer.Write(this.Unknown11);
            for (int i = 0; i < this.Unknown12.Length; i++)
            {
                serializer.Write(this.Unknown12[i]);
            }
            serializer.Write(this.Unknown13);
        }
    }
}
