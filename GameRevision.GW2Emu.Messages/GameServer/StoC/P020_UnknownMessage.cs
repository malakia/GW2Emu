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
    public class P020_UnknownMessage : GenericMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public WorldPosition Unknown3;
        public WorldPosition Unknown4;
        public short Unknown5;
        public Vector3 Unknown6;
        public float Unknown7;
        public float Unknown8;
        public byte Unknown9;
        
        public override ushort Header
        {
            get
            {
                return 20;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.WriteWorldPosition(this.Unknown3);
            serializer.WriteWorldPosition(this.Unknown4);
            serializer.Write(this.Unknown5);
            serializer.WriteVector3(this.Unknown6);
            serializer.Write(this.Unknown7);
            serializer.Write(this.Unknown8);
            serializer.Write(this.Unknown9);
        }
    }
}
